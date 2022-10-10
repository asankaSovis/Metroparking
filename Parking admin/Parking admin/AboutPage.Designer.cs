
namespace Parking_admin
{
    partial class AboutPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPage));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBanner = new System.Windows.Forms.TableLayoutPanel();
            this.pcbMain = new System.Windows.Forms.PictureBox();
            this.grpAbout = new System.Windows.Forms.GroupBox();
            this.tlpText = new System.Windows.Forms.TableLayoutPanel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).BeginInit();
            this.grpAbout.SuspendLayout();
            this.tlpText.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpBanner, 0, 0);
            this.tlpMain.Controls.Add(this.pnlButtons, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpMain.Size = new System.Drawing.Size(561, 298);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpBanner
            // 
            this.tlpBanner.ColumnCount = 2;
            this.tlpBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tlpBanner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBanner.Controls.Add(this.pcbMain, 0, 0);
            this.tlpBanner.Controls.Add(this.grpAbout, 1, 0);
            this.tlpBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBanner.Location = new System.Drawing.Point(3, 3);
            this.tlpBanner.Name = "tlpBanner";
            this.tlpBanner.RowCount = 1;
            this.tlpBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBanner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 237F));
            this.tlpBanner.Size = new System.Drawing.Size(555, 231);
            this.tlpBanner.TabIndex = 0;
            // 
            // pcbMain
            // 
            this.pcbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbMain.Image = global::Parking_admin.Properties.Resources.banner;
            this.pcbMain.Location = new System.Drawing.Point(3, 3);
            this.pcbMain.Name = "pcbMain";
            this.pcbMain.Size = new System.Drawing.Size(122, 225);
            this.pcbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMain.TabIndex = 0;
            this.pcbMain.TabStop = false;
            // 
            // grpAbout
            // 
            this.grpAbout.Controls.Add(this.tlpText);
            this.grpAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAbout.Location = new System.Drawing.Point(131, 3);
            this.grpAbout.Name = "grpAbout";
            this.grpAbout.Size = new System.Drawing.Size(421, 225);
            this.grpAbout.TabIndex = 1;
            this.grpAbout.TabStop = false;
            this.grpAbout.Text = "About";
            // 
            // tlpText
            // 
            this.tlpText.ColumnCount = 1;
            this.tlpText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpText.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpText.Controls.Add(this.lblCopyright, 0, 2);
            this.tlpText.Controls.Add(this.lblAbout, 0, 1);
            this.tlpText.Controls.Add(this.lblTitle, 0, 0);
            this.tlpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpText.Location = new System.Drawing.Point(3, 16);
            this.tlpText.Name = "tlpText";
            this.tlpText.RowCount = 3;
            this.tlpText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpText.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpText.Size = new System.Drawing.Size(415, 206);
            this.tlpText.TabIndex = 0;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlButtons.Controls.Add(this.btnOk);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(3, 240);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(555, 55);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(399, 10);
            this.btnOk.Margin = new System.Windows.Forms.Padding(10);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(140, 35);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(409, 55);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "metroparking";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAbout
            // 
            this.lblAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(3, 55);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(409, 123);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "Metroparking is a smart parking system designed to make reservations to park any " +
    "vehicle easily in a secure location. The application is built to be as simple as" +
    " possible to make it user friendly.";
            this.lblAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(3, 178);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(409, 28);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Copyright (C) 2022 Intelligent Tech";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 298);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Metroparking";
            this.tlpMain.ResumeLayout(false);
            this.tlpBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMain)).EndInit();
            this.grpAbout.ResumeLayout(false);
            this.tlpText.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpBanner;
        private System.Windows.Forms.PictureBox pcbMain;
        private System.Windows.Forms.GroupBox grpAbout;
        private System.Windows.Forms.TableLayoutPanel tlpText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAbout;
    }
}