namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms
{
    partial class frmManageDetainLicenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDetainLicenses));
            this.lb_CurrentPeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Searching = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_BlockLicense = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_DetianedLicenses = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_ReleaseLicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetianedLicenses)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_CurrentPeople
            // 
            this.lb_CurrentPeople.AutoSize = true;
            this.lb_CurrentPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentPeople.Location = new System.Drawing.Point(83, 565);
            this.lb_CurrentPeople.Name = "lb_CurrentPeople";
            this.lb_CurrentPeople.Size = new System.Drawing.Size(36, 13);
            this.lb_CurrentPeople.TabIndex = 19;
            this.lb_CurrentPeople.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "# Records";
            // 
            // txt_Searching
            // 
            this.txt_Searching.Location = new System.Drawing.Point(263, 168);
            this.txt_Searching.Multiline = true;
            this.txt_Searching.Name = "txt_Searching";
            this.txt_Searching.Size = new System.Drawing.Size(168, 21);
            this.txt_Searching.TabIndex = 17;
            this.txt_Searching.TextChanged += new System.EventHandler(this.txt_Searching_TextChanged);
            this.txt_Searching.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Searching_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "FilterBy:";
            // 
            // cb_Filter
            // 
            this.cb_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Items.AddRange(new object[] {
            "None",
            "Detained ID",
            "License ID",
            "Is Released",
            "Fine Fees",
            "National No",
            "Full Name",
            "Release App ID"});
            this.cb_Filter.Location = new System.Drawing.Point(89, 168);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(168, 21);
            this.cb_Filter.TabIndex = 15;
            this.cb_Filter.UseWaitCursor = true;
            this.cb_Filter.SelectedIndexChanged += new System.EventHandler(this.cb_Filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(465, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "List Of Detained Licenses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_BlockLicense
            // 
            this.btn_BlockLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_BlockLicense.BackgroundImage")));
            this.btn_BlockLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_BlockLicense.Location = new System.Drawing.Point(1068, 136);
            this.btn_BlockLicense.Name = "btn_BlockLicense";
            this.btn_BlockLicense.Size = new System.Drawing.Size(60, 55);
            this.btn_BlockLicense.TabIndex = 12;
            this.btn_BlockLicense.UseVisualStyleBackColor = true;
            this.btn_BlockLicense.Click += new System.EventHandler(this.btn_BlockLicense_Click);
            // 
            // button1
            // 
            this.button1.Image = global::MyLicensesSystem.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1021, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_DetianedLicenses
            // 
            this.dgv_DetianedLicenses.AllowUserToAddRows = false;
            this.dgv_DetianedLicenses.AllowUserToDeleteRows = false;
            this.dgv_DetianedLicenses.AllowUserToOrderColumns = true;
            this.dgv_DetianedLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DetianedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetianedLicenses.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_DetianedLicenses.Location = new System.Drawing.Point(13, 197);
            this.dgv_DetianedLicenses.Name = "dgv_DetianedLicenses";
            this.dgv_DetianedLicenses.ReadOnly = true;
            this.dgv_DetianedLicenses.Size = new System.Drawing.Size(1115, 360);
            this.dgv_DetianedLicenses.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 118);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsToolStripMenuItem.Image")));
            this.showPersonDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem.Image")));
            this.showLicenseDetailsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // btn_ReleaseLicense
            // 
            this.btn_ReleaseLicense.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ReleaseLicense.BackgroundImage")));
            this.btn_ReleaseLicense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ReleaseLicense.Location = new System.Drawing.Point(1002, 136);
            this.btn_ReleaseLicense.Name = "btn_ReleaseLicense";
            this.btn_ReleaseLicense.Size = new System.Drawing.Size(60, 55);
            this.btn_ReleaseLicense.TabIndex = 20;
            this.btn_ReleaseLicense.UseVisualStyleBackColor = true;
            this.btn_ReleaseLicense.Click += new System.EventHandler(this.btn_ReleaseLicense_Click);
            // 
            // frmManageDetainLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 608);
            this.Controls.Add(this.btn_ReleaseLicense);
            this.Controls.Add(this.lb_CurrentPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Searching);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_BlockLicense);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_DetianedLicenses);
            this.Name = "frmManageDetainLicenses";
            this.Text = "frmManageDetainLicenses";
            this.Load += new System.EventHandler(this.frmManageDetainLicenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetianedLicenses)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CurrentPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Searching;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_BlockLicense;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_DetianedLicenses;
        private System.Windows.Forms.Button btn_ReleaseLicense;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}