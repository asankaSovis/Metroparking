using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_admin
{
    public partial class frmSlots : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString = "server=127.0.0.1;uid=root;pwd=Jqg9K4#2l3]i;database=intelligent_parking_system";

        Button[] btns = null;

        public frmSlots()
        {
            InitializeComponent();
            LoadSlotState();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btSlot_Click(object sender, EventArgs e)
        {
            int ID = Array.FindIndex(btns, row => row == sender) + 1;
            int availability = 0;

            DataSet reader = SqlQuery("SELECT * FROM `slots` WHERE `slots`.`slot_id`=" + ID);

            if (reader.Tables[0].Rows.Count > 0)
            {
                availability = (int)reader.Tables[0].Rows[0][1];

                if (availability == 0)
                {
                    SqlQuery("UPDATE `slots` SET `availability` = '2' WHERE `slots`.`slot_id` =" + ID);

                }


                else if (availability == 1)
                {
                    SqlQuery("UPDATE `slots` SET `availability` = '0' WHERE `slots`.`slot_id` =" + ID);

                }


                else if (availability == 2)
                {
                    SqlQuery("UPDATE `slots` SET `availability` = '0' WHERE `slots`.`slot_id` =" + ID);

                }

                LoadSlotState();
            }
        }

        private void frmSlots_Load(object sender, EventArgs e)
        {



        }

        private void LoadSlotState()
        {
            btns = new Button[] { btSlot1, btSlot2, btSlot3, btSlot4, btSlot5, btSlot6, btSlot7, btSlot8, btslot9, btSlot10};

            DataSet reader = SqlQuery("SELECT * FROM `slots`");



            for (int i = 0; i < reader.Tables[0].Rows.Count; i++)
            {
                DataRow row = reader.Tables[0].Rows[i];

                if ((int)row[1] == 0)
                {
                    btns[i].BackColor = Color.Green;

                }
                else if ((int)row[1] == 1)
                {
                    btns[i].BackColor = Color.DarkKhaki;

                }
                else if ((int)row[1] == 2)
                {
                    btns[i].BackColor = Color.Red;

                }
            }

            }

       private DataSet SqlQuery(string query)
        {
            DataSet returnData = new DataSet();

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();

                MySql.Data.MySqlClient.MySqlDataAdapter reader = new MySql.Data.MySqlClient.MySqlDataAdapter(query, conn);
                reader.Fill(returnData);
                conn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return returnData;
        }
    }
}
