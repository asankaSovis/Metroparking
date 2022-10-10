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
    public partial class frmUserAcc : Form
    {
        int selectedID = -1; 
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString = "server=127.0.0.1;uid=root;pwd=Jqg9K4#2l3]i;database=intelligent_parking_system";

        public frmUserAcc(int _selectedID = -1)
        {
            InitializeComponent();
            selectedID = _selectedID;
        }

        private void frmUserAcc_Load(object sender, EventArgs e)
        {
            LoadData(""); 

        }

        private void LoadData(string filter)
        {
            DataSet reader = SqlQuery("SELECT `user_id`, `username`, `gender`, `vehicle_id` FROM `account` WHERE `username` LIKE '%" + filter + "%'" );

            dgvDataSet.AllowUserToAddRows = false;
            dgvDataSet.AllowUserToDeleteRows = false;
            dgvDataSet.AllowUserToResizeRows = false;
            dgvDataSet.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDataSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataSet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            dgvDataSet.AutoGenerateColumns = true;
            dgvDataSet.DataSource = reader;
            dgvDataSet.DataMember = reader.Tables[0].TableName;

            dgvDataSet.Columns[2].Visible = false;
            dgvDataSet.Columns[3].Visible = false;

            int contain = -1;
            foreach (DataGridViewRow item in dgvDataSet.Rows)
            {
                if (item.Cells[0].Value.ToString().Equals(selectedID.ToString()))
                {
                    contain = item.Index;
                }
            }
            

            if ((selectedID != -1) && (contain != -1))
                {
                dgvDataSet.ClearSelection();
                dgvDataSet.Rows[contain].Selected = true;
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

        private void dgvDataSet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDataSet.SelectedRows.Count > 0)
            {

                tbUserID.Text = dgvDataSet.SelectedRows[0].Cells[0].Value.ToString();
                tbUserName.Text = dgvDataSet.SelectedRows[0].Cells[1].Value.ToString();
                if ((bool)dgvDataSet.SelectedRows[0].Cells[2].Value)
                {
                    tbGender.Text = "Female";

                }

                else
                {
                    tbGender.Text = "Male";
                }

                textBox3.Text = dgvDataSet.SelectedRows[0].Cells[3].Value.ToString();
                btDelete.Enabled = true; 

            }

            else {
                tbUserID.Text = "";
                tbUserName.Text = "";
                tbGender.Text = "";
                textBox3.Text = "";
                btDelete.Enabled = false;
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {

                SqlQuery("DELETE FROM `account` WHERE `account`.`user_id`=" + dgvDataSet.SelectedRows[0].Cells[0].Value.ToString());
                LoadData(tbSearch.Text);
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData(tbSearch.Text);

        }
    }
}
