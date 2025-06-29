namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalForms
{
    partial class frmManageLocalApplications
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageLocalApplications));
            this.txt_Searching = new System.Windows.Forms.TextBox();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_LocalApplicationList = new System.Windows.Forms.DataGridView();
            this.cts_TestDetails = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditApplicationDetials = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sechToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.segoeUI9ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secheduleStreetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_CurrentApps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddLocalApp = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalApplicationList)).BeginInit();
            this.cts_TestDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Searching
            // 
            this.txt_Searching.Location = new System.Drawing.Point(281, 247);
            this.txt_Searching.Multiline = true;
            this.txt_Searching.Name = "txt_Searching";
            this.txt_Searching.Size = new System.Drawing.Size(168, 21);
            this.txt_Searching.TabIndex = 12;
            this.txt_Searching.TextChanged += new System.EventHandler(this.txt_Searching_TextChanged);
            this.txt_Searching.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Searching_KeyPress);
            // 
            // cb_Filter
            // 
            this.cb_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Items.AddRange(new object[] {
            "None",
            "Local.App.ID",
            "Class",
            "National No.",
            "Full Name",
            "Passed Tests",
            "Status"});
            this.cb_Filter.Location = new System.Drawing.Point(88, 248);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(187, 21);
            this.cb_Filter.TabIndex = 11;
            this.cb_Filter.UseWaitCursor = true;
            this.cb_Filter.SelectedIndexChanged += new System.EventHandler(this.cb_Filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(390, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Local Driving License Applications";
            // 
            // dgv_LocalApplicationList
            // 
            this.dgv_LocalApplicationList.AllowUserToAddRows = false;
            this.dgv_LocalApplicationList.AllowUserToDeleteRows = false;
            this.dgv_LocalApplicationList.AllowUserToOrderColumns = true;
            this.dgv_LocalApplicationList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LocalApplicationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LocalApplicationList.ContextMenuStrip = this.cts_TestDetails;
            this.dgv_LocalApplicationList.Location = new System.Drawing.Point(15, 274);
            this.dgv_LocalApplicationList.Name = "dgv_LocalApplicationList";
            this.dgv_LocalApplicationList.ReadOnly = true;
            this.dgv_LocalApplicationList.Size = new System.Drawing.Size(1176, 327);
            this.dgv_LocalApplicationList.TabIndex = 8;
            // 
            // cts_TestDetails
            // 
            this.cts_TestDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationDetails,
            this.toolStripSeparator1,
            this.EditApplicationDetials,
            this.deleteApplicationdToolStripMenuItem,
            this.toolStripSeparator2,
            this.cancelApplicationToolStripMenuItem,
            this.sechToolStripMenuItem,
            this.toolStripSeparator5,
            this.showLicenseToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.showLicenseToolStripMenuItem1,
            this.toolStripSeparator6,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cts_TestDetails.Name = "cts_PersonDetails";
            this.cts_TestDetails.Size = new System.Drawing.Size(263, 366);
            this.cts_TestDetails.Opened += new System.EventHandler(this.cts_TestDetails_Opened);
            // 
            // showApplicationDetails
            // 
            this.showApplicationDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showApplicationDetails.Image = ((System.Drawing.Image)(resources.GetObject("showApplicationDetails.Image")));
            this.showApplicationDetails.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showApplicationDetails.Name = "showApplicationDetails";
            this.showApplicationDetails.Size = new System.Drawing.Size(262, 38);
            this.showApplicationDetails.Text = "Show Application Details";
            this.showApplicationDetails.Click += new System.EventHandler(this.showApplicationDetails_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(259, 6);
            // 
            // EditApplicationDetials
            // 
            this.EditApplicationDetials.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.EditApplicationDetials.Image = ((System.Drawing.Image)(resources.GetObject("EditApplicationDetials.Image")));
            this.EditApplicationDetials.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditApplicationDetials.Name = "EditApplicationDetials";
            this.EditApplicationDetials.Size = new System.Drawing.Size(262, 38);
            this.EditApplicationDetials.Text = "Edit Application";
            this.EditApplicationDetials.Click += new System.EventHandler(this.EditApplicationDetials_Click);
            // 
            // deleteApplicationdToolStripMenuItem
            // 
            this.deleteApplicationdToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteApplicationdToolStripMenuItem.Image")));
            this.deleteApplicationdToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteApplicationdToolStripMenuItem.Name = "deleteApplicationdToolStripMenuItem";
            this.deleteApplicationdToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.deleteApplicationdToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationdToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationdToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(259, 6);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelApplicationToolStripMenuItem.Image")));
            this.cancelApplicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // sechToolStripMenuItem
            // 
            this.sechToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisionTest,
            this.segoeUI9ptToolStripMenuItem,
            this.secheduleStreetTestToolStripMenuItem});
            this.sechToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sechToolStripMenuItem.Image")));
            this.sechToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sechToolStripMenuItem.Name = "sechToolStripMenuItem";
            this.sechToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.sechToolStripMenuItem.Text = "Sechedule Tests";
            // 
            // VisionTest
            // 
            this.VisionTest.Image = ((System.Drawing.Image)(resources.GetObject("VisionTest.Image")));
            this.VisionTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.VisionTest.Name = "VisionTest";
            this.VisionTest.Size = new System.Drawing.Size(210, 38);
            this.VisionTest.Text = "Sechedule Vision Test";
            this.VisionTest.Click += new System.EventHandler(this.VisionTest_Click);
            // 
            // segoeUI9ptToolStripMenuItem
            // 
            this.segoeUI9ptToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("segoeUI9ptToolStripMenuItem.Image")));
            this.segoeUI9ptToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.segoeUI9ptToolStripMenuItem.Name = "segoeUI9ptToolStripMenuItem";
            this.segoeUI9ptToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.segoeUI9ptToolStripMenuItem.Text = "Sechedule Written Test";
            this.segoeUI9ptToolStripMenuItem.Click += new System.EventHandler(this.segoeUI9ptToolStripMenuItem_Click);
            // 
            // secheduleStreetTestToolStripMenuItem
            // 
            this.secheduleStreetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("secheduleStreetTestToolStripMenuItem.Image")));
            this.secheduleStreetTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.secheduleStreetTestToolStripMenuItem.Name = "secheduleStreetTestToolStripMenuItem";
            this.secheduleStreetTestToolStripMenuItem.Size = new System.Drawing.Size(210, 38);
            this.secheduleStreetTestToolStripMenuItem.Text = "Sechedule Street Test";
            this.secheduleStreetTestToolStripMenuItem.Click += new System.EventHandler(this.secheduleStreetTestToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(259, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.showLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(259, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(259, 6);
            // 
            // showLicenseToolStripMenuItem1
            // 
            this.showLicenseToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem1.Image")));
            this.showLicenseToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseToolStripMenuItem1.Name = "showLicenseToolStripMenuItem1";
            this.showLicenseToolStripMenuItem1.Size = new System.Drawing.Size(262, 38);
            this.showLicenseToolStripMenuItem1.Text = "Show License";
            this.showLicenseToolStripMenuItem1.Click += new System.EventHandler(this.showLicenseToolStripMenuItem1_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(259, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(262, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "FilterBy:";
            // 
            // lb_CurrentApps
            // 
            this.lb_CurrentApps.AutoSize = true;
            this.lb_CurrentApps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentApps.Location = new System.Drawing.Point(81, 608);
            this.lb_CurrentApps.Name = "lb_CurrentApps";
            this.lb_CurrentApps.Size = new System.Drawing.Size(36, 13);
            this.lb_CurrentApps.TabIndex = 18;
            this.lb_CurrentApps.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "# Records";
            // 
            // btn_AddLocalApp
            // 
            this.btn_AddLocalApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddLocalApp.BackgroundImage")));
            this.btn_AddLocalApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddLocalApp.Location = new System.Drawing.Point(1131, 214);
            this.btn_AddLocalApp.Name = "btn_AddLocalApp";
            this.btn_AddLocalApp.Size = new System.Drawing.Size(60, 55);
            this.btn_AddLocalApp.TabIndex = 19;
            this.btn_AddLocalApp.UseVisualStyleBackColor = true;
            this.btn_AddLocalApp.Click += new System.EventHandler(this.btn_AddLocalApp_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::MyLicensesSystem.Properties.Resources.close;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(1084, 607);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(107, 36);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(464, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageLocalApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 647);
            this.Controls.Add(this.btn_AddLocalApp);
            this.Controls.Add(this.lb_CurrentApps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Searching);
            this.Controls.Add(this.cb_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_LocalApplicationList);
            this.Name = "frmManageLocalApplications";
            this.Text = "frmManageLocalApplications";
            this.Load += new System.EventHandler(this.frmManageLocalApplications_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalApplicationList)).EndInit();
            this.cts_TestDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Searching;
        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_LocalApplicationList;
        private System.Windows.Forms.ContextMenuStrip cts_TestDetails;
        private System.Windows.Forms.ToolStripMenuItem showApplicationDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem EditApplicationDetials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_CurrentApps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_AddLocalApp;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sechToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VisionTest;
        private System.Windows.Forms.ToolStripMenuItem segoeUI9ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secheduleStreetTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}