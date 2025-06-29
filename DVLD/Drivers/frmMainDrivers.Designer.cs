namespace MyLicensesSystem.Manage.Drivers
{
    partial class frmMainDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainDrivers));
            this.lb_CurrentPeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.lb_Records = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Searching = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxFilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_DriversList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DriversList)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_CurrentPeople
            // 
            this.lb_CurrentPeople.AutoSize = true;
            this.lb_CurrentPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentPeople.Location = new System.Drawing.Point(-201, 522);
            this.lb_CurrentPeople.Name = "lb_CurrentPeople";
            this.lb_CurrentPeople.Size = new System.Drawing.Size(36, 13);
            this.lb_CurrentPeople.TabIndex = 17;
            this.lb_CurrentPeople.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-270, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "# Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-271, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "FilterBy:";
            // 
            // cb_Filter
            // 
            this.cb_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "NationalNo",
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "Nationality",
            "Gendor",
            "Phone",
            "Email"});
            this.cb_Filter.Location = new System.Drawing.Point(-195, 77);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(168, 21);
            this.cb_Filter.TabIndex = 13;
            this.cb_Filter.UseWaitCursor = true;
            // 
            // lb_Records
            // 
            this.lb_Records.AutoSize = true;
            this.lb_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Records.Location = new System.Drawing.Point(83, 655);
            this.lb_Records.Name = "lb_Records";
            this.lb_Records.Size = new System.Drawing.Size(36, 13);
            this.lb_Records.TabIndex = 27;
            this.lb_Records.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 655);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "# Records";
            // 
            // txt_Searching
            // 
            this.txt_Searching.Location = new System.Drawing.Point(264, 212);
            this.txt_Searching.Multiline = true;
            this.txt_Searching.Name = "txt_Searching";
            this.txt_Searching.Size = new System.Drawing.Size(168, 21);
            this.txt_Searching.TabIndex = 25;
            this.txt_Searching.TextChanged += new System.EventHandler(this.txt_Searching_TextChanged);
            this.txt_Searching.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Searching_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "FilterBy:";
            // 
            // cbxFilter
            // 
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilter.FormattingEnabled = true;
            this.cbxFilter.Items.AddRange(new object[] {
            "None",
            "DriverID",
            "PersonID",
            "NationalNo",
            "FullName"});
            this.cbxFilter.Location = new System.Drawing.Point(90, 212);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(168, 21);
            this.cbxFilter.TabIndex = 23;
            this.cbxFilter.UseWaitCursor = true;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(304, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "Manage Drivers";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(337, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::MyLicensesSystem.Properties.Resources.close;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(670, 653);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 19;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_DriversList
            // 
            this.dgv_DriversList.AllowUserToAddRows = false;
            this.dgv_DriversList.AllowUserToDeleteRows = false;
            this.dgv_DriversList.AllowUserToOrderColumns = true;
            this.dgv_DriversList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DriversList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DriversList.Location = new System.Drawing.Point(13, 239);
            this.dgv_DriversList.Name = "dgv_DriversList";
            this.dgv_DriversList.ReadOnly = true;
            this.dgv_DriversList.Size = new System.Drawing.Size(764, 408);
            this.dgv_DriversList.TabIndex = 18;
            // 
            // frmMainDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 697);
            this.Controls.Add(this.lb_Records);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Searching);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_DriversList);
            this.Controls.Add(this.lb_CurrentPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Filter);
            this.Name = "frmMainDrivers";
            this.Text = "frmMainDrivers";
            this.Load += new System.EventHandler(this.frmMainDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DriversList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_CurrentPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.Label lb_Records;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Searching;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_DriversList;
    }
}