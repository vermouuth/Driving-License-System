namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.InternationalForms
{
    partial class frmManageInternational
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageInternational));
            this.lb_CurrentPeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Searching = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_InterList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_AddPerson = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InterList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_CurrentPeople
            // 
            this.lb_CurrentPeople.AutoSize = true;
            this.lb_CurrentPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentPeople.Location = new System.Drawing.Point(81, 590);
            this.lb_CurrentPeople.Name = "lb_CurrentPeople";
            this.lb_CurrentPeople.Size = new System.Drawing.Size(36, 13);
            this.lb_CurrentPeople.TabIndex = 19;
            this.lb_CurrentPeople.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 590);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "# Records";
            // 
            // txt_Searching
            // 
            this.txt_Searching.Location = new System.Drawing.Point(244, 183);
            this.txt_Searching.Multiline = true;
            this.txt_Searching.Name = "txt_Searching";
            this.txt_Searching.Size = new System.Drawing.Size(145, 21);
            this.txt_Searching.TabIndex = 17;
            this.txt_Searching.TextChanged += new System.EventHandler(this.txt_Searching_TextChanged);
            this.txt_Searching.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Searching_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 182);
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
            "Int.License ID",
            "Application ID",
            "Driver ID",
            "L.License ID"});
            this.cb_Filter.Location = new System.Drawing.Point(89, 183);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(149, 21);
            this.cb_Filter.TabIndex = 15;
            this.cb_Filter.UseWaitCursor = true;
            this.cb_Filter.SelectedIndexChanged += new System.EventHandler(this.cb_Filter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(176, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "International License Applications";
            // 
            // dgv_InterList
            // 
            this.dgv_InterList.AllowUserToAddRows = false;
            this.dgv_InterList.AllowUserToDeleteRows = false;
            this.dgv_InterList.AllowUserToOrderColumns = true;
            this.dgv_InterList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_InterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InterList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_InterList.Location = new System.Drawing.Point(13, 211);
            this.dgv_InterList.Name = "dgv_InterList";
            this.dgv_InterList.ReadOnly = true;
            this.dgv_InterList.Size = new System.Drawing.Size(743, 372);
            this.dgv_InterList.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_AddPerson
            // 
            this.btn_AddPerson.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddPerson.BackgroundImage")));
            this.btn_AddPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddPerson.Location = new System.Drawing.Point(696, 149);
            this.btn_AddPerson.Name = "btn_AddPerson";
            this.btn_AddPerson.Size = new System.Drawing.Size(60, 55);
            this.btn_AddPerson.TabIndex = 12;
            this.btn_AddPerson.UseVisualStyleBackColor = true;
            this.btn_AddPerson.Click += new System.EventHandler(this.btn_AddPerson_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MyLicensesSystem.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(649, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 140);
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
            // frmManageInternational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 632);
            this.Controls.Add(this.lb_CurrentPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Searching);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AddPerson);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_InterList);
            this.Name = "frmManageInternational";
            this.Text = "frmManageInternational";
            this.Load += new System.EventHandler(this.frmManageInternational_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InterList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btn_AddPerson;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_InterList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}