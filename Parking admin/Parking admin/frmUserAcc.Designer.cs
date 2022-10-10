
namespace Parking_admin
{
    partial class frmUserAcc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserAcc));
            this.tlpUserAcc = new System.Windows.Forms.TableLayoutPanel();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tlpDataSet = new System.Windows.Forms.TableLayoutPanel();
            this.gbUserAcc = new System.Windows.Forms.GroupBox();
            this.dgvDataSet = new System.Windows.Forms.DataGridView();
            this.gbUserDetails = new System.Windows.Forms.GroupBox();
            this.tlpUserDetails = new System.Windows.Forms.TableLayoutPanel();
            this.gbVehicleID = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.tbGender = new System.Windows.Forms.TextBox();
            this.gbUserName = new System.Windows.Forms.GroupBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.pbUserDetails = new System.Windows.Forms.PictureBox();
            this.gbUserID = new System.Windows.Forms.GroupBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.tlpUserAcc.SuspendLayout();
            this.gpSearch.SuspendLayout();
            this.tlpDataSet.SuspendLayout();
            this.gbUserAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).BeginInit();
            this.gbUserDetails.SuspendLayout();
            this.tlpUserDetails.SuspendLayout();
            this.gbVehicleID.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbUserName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserDetails)).BeginInit();
            this.gbUserID.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpUserAcc
            // 
            this.tlpUserAcc.ColumnCount = 1;
            this.tlpUserAcc.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUserAcc.Controls.Add(this.gpSearch, 0, 0);
            this.tlpUserAcc.Controls.Add(this.tlpDataSet, 0, 1);
            this.tlpUserAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUserAcc.Location = new System.Drawing.Point(0, 0);
            this.tlpUserAcc.Name = "tlpUserAcc";
            this.tlpUserAcc.RowCount = 2;
            this.tlpUserAcc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpUserAcc.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUserAcc.Size = new System.Drawing.Size(818, 637);
            this.tlpUserAcc.TabIndex = 0;
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.tbSearch);
            this.gpSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpSearch.Location = new System.Drawing.Point(20, 20);
            this.gpSearch.Margin = new System.Windows.Forms.Padding(20, 20, 100, 10);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Padding = new System.Windows.Forms.Padding(7);
            this.gpSearch.Size = new System.Drawing.Size(315, 60);
            this.gpSearch.TabIndex = 0;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "Search User";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(7, 20);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(301, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // tlpDataSet
            // 
            this.tlpDataSet.ColumnCount = 2;
            this.tlpDataSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.01028F));
            this.tlpDataSet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.98972F));
            this.tlpDataSet.Controls.Add(this.gbUserAcc, 0, 0);
            this.tlpDataSet.Controls.Add(this.gbUserDetails, 1, 0);
            this.tlpDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDataSet.Location = new System.Drawing.Point(20, 110);
            this.tlpDataSet.Margin = new System.Windows.Forms.Padding(20);
            this.tlpDataSet.Name = "tlpDataSet";
            this.tlpDataSet.RowCount = 1;
            this.tlpDataSet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDataSet.Size = new System.Drawing.Size(778, 507);
            this.tlpDataSet.TabIndex = 1;
            // 
            // gbUserAcc
            // 
            this.gbUserAcc.Controls.Add(this.dgvDataSet);
            this.gbUserAcc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserAcc.Location = new System.Drawing.Point(7, 7);
            this.gbUserAcc.Margin = new System.Windows.Forms.Padding(7);
            this.gbUserAcc.Name = "gbUserAcc";
            this.gbUserAcc.Padding = new System.Windows.Forms.Padding(10);
            this.gbUserAcc.Size = new System.Drawing.Size(483, 493);
            this.gbUserAcc.TabIndex = 0;
            this.gbUserAcc.TabStop = false;
            this.gbUserAcc.Text = "User Accounts ";
            // 
            // dgvDataSet
            // 
            this.dgvDataSet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataSet.Location = new System.Drawing.Point(10, 23);
            this.dgvDataSet.Margin = new System.Windows.Forms.Padding(10);
            this.dgvDataSet.Name = "dgvDataSet";
            this.dgvDataSet.Size = new System.Drawing.Size(463, 460);
            this.dgvDataSet.TabIndex = 1;
            this.dgvDataSet.SelectionChanged += new System.EventHandler(this.dgvDataSet_SelectionChanged);
            // 
            // gbUserDetails
            // 
            this.gbUserDetails.Controls.Add(this.tlpUserDetails);
            this.gbUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserDetails.Location = new System.Drawing.Point(504, 7);
            this.gbUserDetails.Margin = new System.Windows.Forms.Padding(7);
            this.gbUserDetails.Name = "gbUserDetails";
            this.gbUserDetails.Size = new System.Drawing.Size(267, 493);
            this.gbUserDetails.TabIndex = 1;
            this.gbUserDetails.TabStop = false;
            this.gbUserDetails.Text = "User Details ";
            // 
            // tlpUserDetails
            // 
            this.tlpUserDetails.ColumnCount = 1;
            this.tlpUserDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUserDetails.Controls.Add(this.gbVehicleID, 0, 4);
            this.tlpUserDetails.Controls.Add(this.gbGender, 0, 3);
            this.tlpUserDetails.Controls.Add(this.gbUserName, 0, 2);
            this.tlpUserDetails.Controls.Add(this.pbUserDetails, 0, 0);
            this.tlpUserDetails.Controls.Add(this.gbUserID, 0, 1);
            this.tlpUserDetails.Controls.Add(this.btDelete, 0, 5);
            this.tlpUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUserDetails.Location = new System.Drawing.Point(3, 16);
            this.tlpUserDetails.Name = "tlpUserDetails";
            this.tlpUserDetails.RowCount = 6;
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpUserDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpUserDetails.Size = new System.Drawing.Size(261, 474);
            this.tlpUserDetails.TabIndex = 0;
            // 
            // gbVehicleID
            // 
            this.gbVehicleID.Controls.Add(this.textBox3);
            this.gbVehicleID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVehicleID.Location = new System.Drawing.Point(3, 387);
            this.gbVehicleID.Name = "gbVehicleID";
            this.gbVehicleID.Size = new System.Drawing.Size(255, 39);
            this.gbVehicleID.TabIndex = 4;
            this.gbVehicleID.TabStop = false;
            this.gbVehicleID.Text = "Vehicle";
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(3, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(249, 20);
            this.textBox3.TabIndex = 0;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.tbGender);
            this.gbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGender.Location = new System.Drawing.Point(3, 342);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(255, 39);
            this.gbGender.TabIndex = 3;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // tbGender
            // 
            this.tbGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGender.Location = new System.Drawing.Point(3, 16);
            this.tbGender.Name = "tbGender";
            this.tbGender.ReadOnly = true;
            this.tbGender.Size = new System.Drawing.Size(249, 20);
            this.tbGender.TabIndex = 0;
            // 
            // gbUserName
            // 
            this.gbUserName.Controls.Add(this.tbUserName);
            this.gbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserName.Location = new System.Drawing.Point(3, 297);
            this.gbUserName.Name = "gbUserName";
            this.gbUserName.Size = new System.Drawing.Size(255, 39);
            this.gbUserName.TabIndex = 2;
            this.gbUserName.TabStop = false;
            this.gbUserName.Text = "Username";
            // 
            // tbUserName
            // 
            this.tbUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserName.Location = new System.Drawing.Point(3, 16);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.ReadOnly = true;
            this.tbUserName.Size = new System.Drawing.Size(249, 20);
            this.tbUserName.TabIndex = 0;
            // 
            // pbUserDetails
            // 
            this.pbUserDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUserDetails.Image = global::Parking_admin.Properties.Resources.profile_group_icon;
            this.pbUserDetails.Location = new System.Drawing.Point(25, 25);
            this.pbUserDetails.Margin = new System.Windows.Forms.Padding(25);
            this.pbUserDetails.Name = "pbUserDetails";
            this.pbUserDetails.Size = new System.Drawing.Size(211, 199);
            this.pbUserDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserDetails.TabIndex = 0;
            this.pbUserDetails.TabStop = false;
            // 
            // gbUserID
            // 
            this.gbUserID.Controls.Add(this.tbUserID);
            this.gbUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserID.Location = new System.Drawing.Point(3, 252);
            this.gbUserID.Name = "gbUserID";
            this.gbUserID.Size = new System.Drawing.Size(255, 39);
            this.gbUserID.TabIndex = 1;
            this.gbUserID.TabStop = false;
            this.gbUserID.Text = "User ID";
            // 
            // tbUserID
            // 
            this.tbUserID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbUserID.Location = new System.Drawing.Point(3, 16);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.ReadOnly = true;
            this.tbUserID.Size = new System.Drawing.Size(249, 20);
            this.tbUserID.TabIndex = 0;
            // 
            // btDelete
            // 
            this.btDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btDelete.Enabled = false;
            this.btDelete.Location = new System.Drawing.Point(152, 436);
            this.btDelete.Margin = new System.Windows.Forms.Padding(7);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(102, 31);
            this.btDelete.TabIndex = 5;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // frmUserAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 637);
            this.Controls.Add(this.tlpUserAcc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUserAcc";
            this.Text = "User Account";
            this.Load += new System.EventHandler(this.frmUserAcc_Load);
            this.tlpUserAcc.ResumeLayout(false);
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.tlpDataSet.ResumeLayout(false);
            this.gbUserAcc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataSet)).EndInit();
            this.gbUserDetails.ResumeLayout(false);
            this.tlpUserDetails.ResumeLayout(false);
            this.gbVehicleID.ResumeLayout(false);
            this.gbVehicleID.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbUserName.ResumeLayout(false);
            this.gbUserName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserDetails)).EndInit();
            this.gbUserID.ResumeLayout(false);
            this.gbUserID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpUserAcc;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.TableLayoutPanel tlpDataSet;
        private System.Windows.Forms.GroupBox gbUserAcc;
        private System.Windows.Forms.DataGridView dgvDataSet;
        private System.Windows.Forms.GroupBox gbUserDetails;
        private System.Windows.Forms.TableLayoutPanel tlpUserDetails;
        private System.Windows.Forms.GroupBox gbVehicleID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.TextBox tbGender;
        private System.Windows.Forms.GroupBox gbUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.PictureBox pbUserDetails;
        private System.Windows.Forms.GroupBox gbUserID;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbSearch;
    }
}