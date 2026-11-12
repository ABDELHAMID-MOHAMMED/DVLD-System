namespace DVLD
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.replacementForLostOrDamagedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.releaseDetainedDrivinfLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.sssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cccToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuurentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationsToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1810, 74);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saToolStripMenuItem,
            this.toolStripSeparator1,
            this.sasToolStripMenuItem,
            this.toolStripSeparator4,
            this.sssToolStripMenuItem,
            this.ssToolStripMenuItem,
            this.cccToolStripMenuItem});
            this.applicationsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationsToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications_64;
            this.applicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(210, 68);
            this.applicationsToolStripMenuItem.Text = "Applications";
            this.applicationsToolStripMenuItem.Click += new System.EventHandler(this.applicationsToolStripMenuItem_Click);
            // 
            // saToolStripMenuItem
            // 
            this.saToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewToolStripMenuItem,
            this.toolStripSeparator2,
            this.replacementForLostOrDamagedToolStripMenuItem,
            this.toolStripSeparator3,
            this.releaseDetainedDrivinfLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.saToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saToolStripMenuItem.Image")));
            this.saToolStripMenuItem.Name = "saToolStripMenuItem";
            this.saToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.saToolStripMenuItem.Text = "Driving License Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newDrivingLicenseToolStripMenuItem.Image")));
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(433, 34);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localLicenseToolStripMenuItem.Image")));
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internationalLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseToolStripMenuItem.Image")));
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.internationalLicenseToolStripMenuItem.Text = "International License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewToolStripMenuItem
            // 
            this.renewToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renewToolStripMenuItem.Image")));
            this.renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            this.renewToolStripMenuItem.Size = new System.Drawing.Size(433, 34);
            this.renewToolStripMenuItem.Text = "Renew Driving License";
            this.renewToolStripMenuItem.Click += new System.EventHandler(this.renewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(430, 6);
            // 
            // replacementForLostOrDamagedToolStripMenuItem
            // 
            this.replacementForLostOrDamagedToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replacementForLostOrDamagedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("replacementForLostOrDamagedToolStripMenuItem.Image")));
            this.replacementForLostOrDamagedToolStripMenuItem.Name = "replacementForLostOrDamagedToolStripMenuItem";
            this.replacementForLostOrDamagedToolStripMenuItem.Size = new System.Drawing.Size(433, 34);
            this.replacementForLostOrDamagedToolStripMenuItem.Text = "Replacement For Lost or Damaged License";
            this.replacementForLostOrDamagedToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostOrDamagedToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(430, 6);
            // 
            // releaseDetainedDrivinfLicenseToolStripMenuItem
            // 
            this.releaseDetainedDrivinfLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDetainedDrivinfLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainedDrivinfLicenseToolStripMenuItem.Image")));
            this.releaseDetainedDrivinfLicenseToolStripMenuItem.Name = "releaseDetainedDrivinfLicenseToolStripMenuItem";
            this.releaseDetainedDrivinfLicenseToolStripMenuItem.Size = new System.Drawing.Size(433, 34);
            this.releaseDetainedDrivinfLicenseToolStripMenuItem.Text = "Release Detained Drivinf License";
            this.releaseDetainedDrivinfLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedDrivinfLicenseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retakeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retakeTestToolStripMenuItem.Image")));
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(433, 34);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(337, 6);
            // 
            // sasToolStripMenuItem
            // 
            this.sasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internationalLicenseApplicationsToolStripMenuItem});
            this.sasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sasToolStripMenuItem.Image")));
            this.sasToolStripMenuItem.Name = "sasToolStripMenuItem";
            this.sasToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.sasToolStripMenuItem.Text = "Manage Application";
            this.sasToolStripMenuItem.Click += new System.EventHandler(this.sasToolStripMenuItem_Click);
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("localDrivingLicenseApplicationsToolStripMenuItem.Image")));
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(403, 34);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internationalLicenseApplicationsToolStripMenuItem
            // 
            this.internationalLicenseApplicationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("internationalLicenseApplicationsToolStripMenuItem.Image")));
            this.internationalLicenseApplicationsToolStripMenuItem.Name = "internationalLicenseApplicationsToolStripMenuItem";
            this.internationalLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(403, 34);
            this.internationalLicenseApplicationsToolStripMenuItem.Text = "International License Applications";
            this.internationalLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseApplicationsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(337, 6);
            // 
            // sssToolStripMenuItem
            // 
            this.sssToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicenseToolStripMenuItem,
            this.detainedLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.sssToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sssToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sssToolStripMenuItem.Image")));
            this.sssToolStripMenuItem.Name = "sssToolStripMenuItem";
            this.sssToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.sssToolStripMenuItem.Text = "Detaind Licenes";
            // 
            // manageDetainedLicenseToolStripMenuItem
            // 
            this.manageDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("manageDetainedLicenseToolStripMenuItem.Image")));
            this.manageDetainedLicenseToolStripMenuItem.Name = "manageDetainedLicenseToolStripMenuItem";
            this.manageDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.manageDetainedLicenseToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicenseToolStripMenuItem_Click);
            // 
            // detainedLicenseToolStripMenuItem
            // 
            this.detainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("detainedLicenseToolStripMenuItem.Image")));
            this.detainedLicenseToolStripMenuItem.Name = "detainedLicenseToolStripMenuItem";
            this.detainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.detainedLicenseToolStripMenuItem.Text = "Detained License";
            this.detainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainedLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseDetainedLicenseToolStripMenuItem.Image")));
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // ssToolStripMenuItem
            // 
            this.ssToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ssToolStripMenuItem.Image")));
            this.ssToolStripMenuItem.Name = "ssToolStripMenuItem";
            this.ssToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.ssToolStripMenuItem.Text = "Manage Application Types";
            this.ssToolStripMenuItem.Click += new System.EventHandler(this.ssToolStripMenuItem_Click);
            // 
            // cccToolStripMenuItem
            // 
            this.cccToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cccToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cccToolStripMenuItem.Image")));
            this.cccToolStripMenuItem.Name = "cccToolStripMenuItem";
            this.cccToolStripMenuItem.Size = new System.Drawing.Size(340, 34);
            this.cccToolStripMenuItem.Text = "Manage Test Types";
            this.cccToolStripMenuItem.Click += new System.EventHandler(this.cccToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peopleToolStripMenuItem.Image = global::DVLD.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(155, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driversToolStripMenuItem.Image = global::DVLD.Properties.Resources.Drivers_64;
            this.driversToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(160, 68);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersToolStripMenuItem.Image = global::DVLD.Properties.Resources.Users_2_64;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(143, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSetToolStripMenuItem
            // 
            this.accountSetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuurentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.accountSetToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSetToolStripMenuItem.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.accountSetToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSetToolStripMenuItem.Name = "accountSetToolStripMenuItem";
            this.accountSetToolStripMenuItem.Size = new System.Drawing.Size(253, 68);
            this.accountSetToolStripMenuItem.Text = "Account Settings";
            this.accountSetToolStripMenuItem.Click += new System.EventHandler(this.accountSetToolStripMenuItem_Click);
            // 
            // cuurentUserInfoToolStripMenuItem
            // 
            this.cuurentUserInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuurentUserInfoToolStripMenuItem.Image")));
            this.cuurentUserInfoToolStripMenuItem.Name = "cuurentUserInfoToolStripMenuItem";
            this.cuurentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(281, 36);
            this.cuurentUserInfoToolStripMenuItem.Text = "Cuurent User Info";
            this.cuurentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.cuurentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(281, 36);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("signOutToolStripMenuItem.Image")));
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(281, 36);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1810, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cccToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSetToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostOrDamagedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedDrivinfLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuurentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

