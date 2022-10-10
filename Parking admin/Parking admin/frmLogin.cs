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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == "123")
            {
                frmAdminPanel Admin = new frmAdminPanel();
                Admin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password", "Admin Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                btLogin.PerformClick();
            }
        }
    }
}
