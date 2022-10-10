
namespace Parking_admin
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.tlpLogin = new System.Windows.Forms.TableLayoutPanel();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pbAdminPic = new System.Windows.Forms.PictureBox();
            this.gbUsername = new System.Windows.Forms.GroupBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.tlpLogin.SuspendLayout();
            this.gbPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPic)).BeginInit();
            this.gbUsername.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpLogin
            // 
            this.tlpLogin.ColumnCount = 1;
            this.tlpLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogin.Controls.Add(this.gbPassword, 0, 2);
            this.tlpLogin.Controls.Add(this.pbAdminPic, 0, 0);
            this.tlpLogin.Controls.Add(this.gbUsername, 0, 1);
            this.tlpLogin.Controls.Add(this.btLogin, 0, 3);
            this.tlpLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLogin.Location = new System.Drawing.Point(0, 0);
            this.tlpLogin.Margin = new System.Windows.Forms.Padding(10);
            this.tlpLogin.Name = "tlpLogin";
            this.tlpLogin.RowCount = 4;
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpLogin.Size = new System.Drawing.Size(297, 412);
            this.tlpLogin.TabIndex = 0;
            // 
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.tbPassword);
            this.gbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPassword.Location = new System.Drawing.Point(15, 315);
            this.gbPassword.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.gbPassword.Size = new System.Drawing.Size(267, 54);
            this.gbPassword.TabIndex = 2;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassword.Location = new System.Drawing.Point(3, 21);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(261, 20);
            this.tbPassword.TabIndex = 0;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // pbAdminPic
            // 
            this.pbAdminPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdminPic.Image = global::Parking_admin.Properties.Resources.profile_icon;
            this.pbAdminPic.Location = new System.Drawing.Point(40, 40);
            this.pbAdminPic.Margin = new System.Windows.Forms.Padding(40);
            this.pbAdminPic.Name = "pbAdminPic";
            this.pbAdminPic.Size = new System.Drawing.Size(217, 172);
            this.pbAdminPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdminPic.TabIndex = 0;
            this.pbAdminPic.TabStop = false;
            // 
            // gbUsername
            // 
            this.gbUsername.Controls.Add(this.tbUsername);
            this.gbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUsername.Location = new System.Drawing.Point(15, 255);
            this.gbUsername.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.gbUsername.Name = "gbUsername";
            this.gbUsername.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.gbUsername.Size = new System.Drawing.Size(267, 54);
            this.gbUsername.TabIndex = 1;
            this.gbUsername.TabStop = false;
            this.gbUsername.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUsername.Location = new System.Drawing.Point(3, 21);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(261, 20);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TabStop = false;
            this.tbUsername.Text = "Admin";
            // 
            // btLogin
            // 
            this.btLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btLogin.Location = new System.Drawing.Point(172, 375);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 3, 15, 10);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(110, 27);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 412);
            this.Controls.Add(this.tlpLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(313, 451);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(313, 451);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            this.TopMost = true;
            this.tlpLogin.ResumeLayout(false);
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPic)).EndInit();
            this.gbUsername.ResumeLayout(false);
            this.gbUsername.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLogin;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.PictureBox pbAdminPic;
        private System.Windows.Forms.GroupBox gbUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btLogin;
    }
}