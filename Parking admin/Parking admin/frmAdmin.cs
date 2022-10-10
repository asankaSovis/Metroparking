using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json; // To handle JSON data
using System.IO.Ports; // Access ports

namespace Parking_admin
{
    public partial class frmAdminPanel : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString = "server=127.0.0.1;uid=root;pwd=Jqg9K4#2l3]i;database=intelligent_parking_system";

        List<string[]> devices = new List<string[]>();
        SerialPort myPort = null;

        int occupyingBookingID = -1;
        int unoccupyingBookingID = -1;

        bool deviceListUpdate = false; // Flag to update device list
        public bool deviceStatus = false; // Flag to update device status of the selected device

        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            drawBanner();
            loadDevices();
        }

        private void frmAdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                myPort.Close();
            } catch (Exception ex) { };
            Application.Exit();
        }

        private void LoadData()
        {
            DataSet reader = SqlQuery("SELECT * FROM `bookings`");

            dgvDataSet.AllowUserToAddRows = false;
            dgvDataSet.AllowUserToDeleteRows = false;
            dgvDataSet.AllowUserToResizeRows = false;
            dgvDataSet.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDataSet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDataSet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDataSet.AutoGenerateColumns = true;
            dgvDataSet.DataSource = reader;
            dgvDataSet.DataMember = reader.Tables[0].TableName;

            dgvDataSet.Columns[7].Visible = false;
            //dgvDataSet.Columns[3].Visible = false;


            int count = 0;
            foreach (DataGridViewRow item in dgvDataSet.Rows)
            {
                if (item.Cells[7].Value.ToString().Equals("0") || item.Cells[7].Value.ToString().Equals("1"))
                {
                    count++;
                }
            }

            tssItem.Text = count + " Live Bookings";

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

        private void btUserAccount_Click(object sender, EventArgs e)
        {
            int selectedID = -1;
            if (dgvDataSet.SelectedRows.Count > 0)
            {
                selectedID = (int)dgvDataSet.SelectedRows[0].Cells[1].Value;
            }
            frmUserAcc account = new frmUserAcc(selectedID);
            account.ShowDialog();


        }

        private void btParkingSlot_Click(object sender, EventArgs e)
        {
            frmSlots parking = new frmSlots();
            parking.ShowDialog();

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            if (dgvDataSet.SelectedRows.Count > 0)
            {
                if (dgvDataSet.SelectedRows[0].Cells[7].Value.ToString() == "0")
                {
                    SqlQuery("UPDATE `bookings` SET `status` = '3' WHERE `bookings`.`booking_id` = " + dgvDataSet.SelectedRows[0].Cells[0].Value);
                    SqlQuery("UPDATE `slots` SET `availability` = '0' WHERE `slots`.`slot_id` =" + dgvDataSet.SelectedRows[0].Cells[2].Value);
                }

                else if (dgvDataSet.SelectedRows[0].Cells[7].Value.ToString() == "1")
                {
                    SqlQuery("UPDATE `bookings` SET `status` = '2' WHERE `bookings`.`booking_id` = " + dgvDataSet.SelectedRows[0].Cells[0].Value);
                    SqlQuery("UPDATE `slots` SET `availability` = '0' WHERE `slots`.`slot_id` =" + dgvDataSet.SelectedRows[0].Cells[2].Value);
                }
            }
            LoadData();
        }

        private void dgvDataSet_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDataSet.SelectedRows.Count > 0)
            {
                btCancel.Enabled = (Int32.Parse(dgvDataSet.SelectedRows[0].Cells[7].Value.ToString()) < 2);
                Console.WriteLine(Int32.Parse(dgvDataSet.SelectedRows[0].Cells[7].Value.ToString()));

                if (dgvDataSet.SelectedRows[0].Cells[7].Value.ToString() == "0")
                {
                    btCancel.Text = "Cancel";
                    lblCancel.BackColor = Color.DeepSkyBlue;
                    lblCancel.Text = "Booked";
                }
                else if (dgvDataSet.SelectedRows[0].Cells[7].Value.ToString() == "1")
                {
                    btCancel.Text = "Complete";
                    lblCancel.BackColor = Color.YellowGreen;
                    lblCancel.Text = "Occupied";
                }

                else if (dgvDataSet.SelectedRows[0].Cells[7].Value.ToString() == "2")
                {

                    lblCancel.BackColor = Color.Green;
                    lblCancel.Text = "Completed";
                }

                else if (dgvDataSet.SelectedRows[0].Cells[7].Value.ToString() == "3")
                {

                    lblCancel.BackColor = Color.Red;
                    lblCancel.Text = "Cancelled";
                }

            }
            else
            {
                lblCancel.BackColor = Color.Gray;
                lblCancel.Text = "-";
            }
      
        }

        private void ttimer_Tick(object sender, EventArgs e)
        {
            tssDate.Text = DateTime.Now.ToString();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            AboutPage about = new AboutPage();
            about.ShowDialog();
        }

        public void drawBanner()
        {
            // Creating the canvas
            Bitmap BitmapImage = new Bitmap(pbLogo.Size.Width, pbLogo.Size.Height,
                                System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            Graphics GraphicsFromImage = Graphics.FromImage(BitmapImage);

            // Loading banner

            Image banner = Parking_admin.Properties.Resources.metroparking;

            int height = BitmapImage.Size.Height;
            int width = (BitmapImage.Size.Height * banner.Size.Width) / banner.Size.Height;

            GraphicsFromImage.DrawImage(banner, 0, 0, width, height);

            // Loading info icon

            GraphicsFromImage.DrawImage(Parking_admin.Properties.Resources.about, BitmapImage.Size.Width - 40, 10, 30, 30);

            // Applying to the banner

            pbLogo.Image = BitmapImage;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (devices.Count > 0)
            {
                if (myPort == null)
                {
                    myPort = new System.IO.Ports.SerialPort(
                                                        devices[0][3],
                                                        9600);
                }

                lblAdminName.Text = "ADMIN\nController (Connected)";
                lblAdminName.ForeColor = Color.Green;

                DataSet reader = SqlQuery("SELECT * FROM `bookings` WHERE `status`=4 OR `status`=5");
                foreach (DataRow item in reader.Tables[0].Rows)
                {
                    if (item[7].ToString() == "4")
                    {
                        unoccupyingBookingID = int.Parse(item[0].ToString());
                        sendData(myPort, "occupy:false");
                    }
                    if (item[7].ToString() == "5")
                    {
                        occupyingBookingID = int.Parse(item[0].ToString());
                        sendData(myPort, "occupy:true");
                    }
                }
            }
            else
            {
                lblAdminName.Text = "ADMIN\nController (Disconnected)";
                lblAdminName.ForeColor = Color.Red;
            }

        }

        private void loadDevices()
        {
            string[] ports = SerialPort.GetPortNames(); // Loads all the available ports

            // For each port available, we send 'deviceInfo:' command to check if the
            // device is ours.
            foreach (string portName in ports)
            {
                try
                {
                    SerialPort port = new System.IO.Ports.SerialPort(portName, 9600);

                    if (!port.IsOpen)
                    {
                        port.Open();
                        port.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
                        sendData(port, "deviceInfo:");
                    }
                }
                catch { }
            }
        }

        /// <summary>
        /// Function to handle sending of data to the device.
        /// </summary>
        /// <param name="port">Port to send data to</param>
        /// <param name="data">String that include the data to be sent</param>
        /// <returns>Progress 0-Success -1-Failed</returns>

        private int sendData(SerialPort port, string data)
        {
            try
            {
                // If the device is not open, we open it
                if (!port.IsOpen)
                {
                    port.Open();
                    port.DataReceived += new SerialDataReceivedEventHandler(DataRecieved);
                }

                // Writes the data to the port
                port.WriteTimeout = 100;
                port.ReadTimeout = 1000;
                port.Write(data);

                return 0;
            }
            catch (Exception)
            {
                
                return -1;
            }
        }

        /// <summary>
        /// Function to handle the recieved data when the PC recieve data from the device.
        /// NOTE: This function is async and runs on a different thread. So we cannot
        /// access classes/variables in parent thread.
        /// </summary>
        /// <param name="sender">Sending entity</param>
        /// <param name="e">Event arguements</param>

        private void DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            // Identify the sending port and read the data
            SerialPort prt = (SerialPort)sender;
            string data = prt.ReadLine();
            Console.WriteLine(data);

            try
            {
                // Separating the command from parameter
                string command = data.Substring(0, data.IndexOf(':'));
                string parameter = data.Substring(data.IndexOf(':') + 1);

                // If we recieve the 'deviceInfo:' back, we know that this device is ours, so
                // we parse the JSON and add that to the device list. We also note that the device
                // list is updated by setting the flag
                if (command == "deviceInfo")
                {
                    var valuesDict = JsonSerializer.Deserialize<Dictionary<string, string>>(parameter);

                    if (valuesDict["name"] == "Metroparking Manager")
                    {
                        String[] parameters = { valuesDict["id"], "", valuesDict["version"], prt.PortName };
                        devices.Add(parameters);
                        deviceListUpdate = true;
                    }

                    System.Threading.Thread.Sleep(2000);
                    //frmMessage messageForm = new frmMessage(this.Text, "Device identified on " + prt.PortName, loadedImages[9], this.Icon);
                    //messageForm.ShowDialog();
                    // Closing the port
                    prt.Close();
                    prt.Dispose();
                }
                // If we recieve the 'update:' back, we know that the device is online, so we
                // update the flag to note that device is online
                else if (command == "update")
                {
                    updateRecieved(parameter);
                    System.Threading.Thread.Sleep(2000);
                    //frmMessage messageForm = new frmMessage(this.Text, prt.PortName + " is ready.", loadedImages[9], this.Icon);
                    //messageForm.ShowDialog();

                    deviceStatus = true;
                }
            }
            catch (Exception) { }
        }

        private void updateRecieved(string update)
        {
            
            if (update.Contains("true"))
            {
                Console.WriteLine(update);
                if (unoccupyingBookingID != 0)
                {
                    SqlQuery("UPDATE `bookings` SET `status` = '2' WHERE `bookings`.`booking_id` =" + unoccupyingBookingID);
                    
                    unoccupyingBookingID = -1;
                }
                if (occupyingBookingID != 0)
                {
                    SqlQuery("UPDATE `bookings` SET `status` = '1' WHERE `bookings`.`booking_id` =" + occupyingBookingID);

                    occupyingBookingID = -1;
                }
            }
        }
    }
}
