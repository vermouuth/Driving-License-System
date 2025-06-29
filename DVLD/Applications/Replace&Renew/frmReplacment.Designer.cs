namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms
{
    partial class frmReplacment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplacment));
            this.ll_ShowInfo = new System.Windows.Forms.LinkLabel();
            this.ll_ShowHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lb_CreatedBy = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_Fees = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_ApplicationDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_OldLicense = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_RenewdLicense = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_NewLicenseAppID = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_LicneseSerch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Searching = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rd_Lost = new System.Windows.Forms.RadioButton();
            this.rd_Damage = new System.Windows.Forms.RadioButton();
            this.ctlDriverInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalControls.ctlDriverInfo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ll_ShowInfo
            // 
            this.ll_ShowInfo.AutoSize = true;
            this.ll_ShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_ShowInfo.LinkColor = System.Drawing.Color.DimGray;
            this.ll_ShowInfo.Location = new System.Drawing.Point(203, 601);
            this.ll_ShowInfo.Name = "ll_ShowInfo";
            this.ll_ShowInfo.Size = new System.Drawing.Size(196, 20);
            this.ll_ShowInfo.TabIndex = 123;
            this.ll_ShowInfo.TabStop = true;
            this.ll_ShowInfo.Text = "Show New License Info";
            this.ll_ShowInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ShowInfo_LinkClicked);
            // 
            // ll_ShowHistory
            // 
            this.ll_ShowHistory.AutoSize = true;
            this.ll_ShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_ShowHistory.LinkColor = System.Drawing.Color.DimGray;
            this.ll_ShowHistory.Location = new System.Drawing.Point(17, 601);
            this.ll_ShowHistory.Name = "ll_ShowHistory";
            this.ll_ShowHistory.Size = new System.Drawing.Size(181, 20);
            this.ll_ShowHistory.TabIndex = 122;
            this.ll_ShowHistory.TabStop = true;
            this.ll_ShowHistory.Text = "Show License History";
            this.ll_ShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ShowHistory_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.lb_CreatedBy);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lb_Fees);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lb_ApplicationDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lb_OldLicense);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lb_RenewdLicense);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.lb_NewLicenseAppID);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(21, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 160);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application Info for License Replacement";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(162, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 111;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(162, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 110;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(162, 100);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 109;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(521, 101);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 18);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 108;
            this.pictureBox6.TabStop = false;
            // 
            // lb_CreatedBy
            // 
            this.lb_CreatedBy.AutoSize = true;
            this.lb_CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreatedBy.Location = new System.Drawing.Point(545, 101);
            this.lb_CreatedBy.Name = "lb_CreatedBy";
            this.lb_CreatedBy.Size = new System.Drawing.Size(54, 18);
            this.lb_CreatedBy.TabIndex = 85;
            this.lb_CreatedBy.Text = "[????]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(342, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 18);
            this.label13.TabIndex = 83;
            this.label13.Text = "Created By:";
            // 
            // lb_Fees
            // 
            this.lb_Fees.AutoSize = true;
            this.lb_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fees.Location = new System.Drawing.Point(195, 99);
            this.lb_Fees.Name = "lb_Fees";
            this.lb_Fees.Size = new System.Drawing.Size(54, 18);
            this.lb_Fees.TabIndex = 76;
            this.lb_Fees.Text = "[????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 74;
            this.label7.Text = "Application Fees:";
            // 
            // lb_ApplicationDate
            // 
            this.lb_ApplicationDate.AutoSize = true;
            this.lb_ApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ApplicationDate.Location = new System.Drawing.Point(195, 66);
            this.lb_ApplicationDate.Name = "lb_ApplicationDate";
            this.lb_ApplicationDate.Size = new System.Drawing.Size(54, 18);
            this.lb_ApplicationDate.TabIndex = 73;
            this.lb_ApplicationDate.Text = "[????]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Application Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Replaced License ID:";
            // 
            // lb_OldLicense
            // 
            this.lb_OldLicense.AutoSize = true;
            this.lb_OldLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OldLicense.Location = new System.Drawing.Point(545, 68);
            this.lb_OldLicense.Name = "lb_OldLicense";
            this.lb_OldLicense.Size = new System.Drawing.Size(54, 18);
            this.lb_OldLicense.TabIndex = 71;
            this.lb_OldLicense.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 64;
            this.label5.Text = "Old License ID:";
            // 
            // lb_RenewdLicense
            // 
            this.lb_RenewdLicense.AutoSize = true;
            this.lb_RenewdLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RenewdLicense.Location = new System.Drawing.Point(545, 32);
            this.lb_RenewdLicense.Name = "lb_RenewdLicense";
            this.lb_RenewdLicense.Size = new System.Drawing.Size(54, 18);
            this.lb_RenewdLicense.TabIndex = 70;
            this.lb_RenewdLicense.Text = "[????]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(521, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // lb_NewLicenseAppID
            // 
            this.lb_NewLicenseAppID.AutoSize = true;
            this.lb_NewLicenseAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewLicenseAppID.Location = new System.Drawing.Point(195, 32);
            this.lb_NewLicenseAppID.Name = "lb_NewLicenseAppID";
            this.lb_NewLicenseAppID.Size = new System.Drawing.Size(54, 18);
            this.lb_NewLicenseAppID.TabIndex = 69;
            this.lb_NewLicenseAppID.Text = "[????]";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(521, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 66;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "L.R.Application ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LicneseSerch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Searching);
            this.groupBox2.Location = new System.Drawing.Point(21, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 60);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // btn_LicneseSerch
            // 
            this.btn_LicneseSerch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_LicneseSerch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LicneseSerch.BackgroundImage")));
            this.btn_LicneseSerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LicneseSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LicneseSerch.Location = new System.Drawing.Point(398, 9);
            this.btn_LicneseSerch.Name = "btn_LicneseSerch";
            this.btn_LicneseSerch.Size = new System.Drawing.Size(62, 45);
            this.btn_LicneseSerch.TabIndex = 5;
            this.btn_LicneseSerch.UseVisualStyleBackColor = false;
            this.btn_LicneseSerch.Click += new System.EventHandler(this.btn_LicneseSerch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Find By:";
            // 
            // txt_Searching
            // 
            this.txt_Searching.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Searching.Location = new System.Drawing.Point(97, 18);
            this.txt_Searching.Multiline = true;
            this.txt_Searching.Name = "txt_Searching";
            this.txt_Searching.Size = new System.Drawing.Size(295, 24);
            this.txt_Searching.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(529, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 125;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Save.Location = new System.Drawing.Point(665, 592);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 33);
            this.btn_Save.TabIndex = 124;
            this.btn_Save.Text = "Issue";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(186, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 31);
            this.label1.TabIndex = 126;
            this.label1.Text = "Replacement for lost License";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rd_Lost);
            this.groupBox3.Controls.Add(this.rd_Damage);
            this.groupBox3.Location = new System.Drawing.Point(597, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 81);
            this.groupBox3.TabIndex = 127;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Replacemnt For";
            // 
            // rd_Lost
            // 
            this.rd_Lost.AutoSize = true;
            this.rd_Lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Lost.Location = new System.Drawing.Point(6, 49);
            this.rd_Lost.Name = "rd_Lost";
            this.rd_Lost.Size = new System.Drawing.Size(112, 20);
            this.rd_Lost.TabIndex = 1;
            this.rd_Lost.TabStop = true;
            this.rd_Lost.Text = "Lost License";
            this.rd_Lost.UseVisualStyleBackColor = true;
            this.rd_Lost.CheckedChanged += new System.EventHandler(this.rd_Lost_CheckedChanged);
            // 
            // rd_Damage
            // 
            this.rd_Damage.AutoSize = true;
            this.rd_Damage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Damage.Location = new System.Drawing.Point(6, 21);
            this.rd_Damage.Name = "rd_Damage";
            this.rd_Damage.Size = new System.Drawing.Size(142, 20);
            this.rd_Damage.TabIndex = 0;
            this.rd_Damage.TabStop = true;
            this.rd_Damage.Text = "Damage License";
            this.rd_Damage.UseVisualStyleBackColor = true;
            this.rd_Damage.CheckedChanged += new System.EventHandler(this.rd_Damage_CheckedChanged);
            // 
            // ctlDriverInfo1
            // 
            this.ctlDriverInfo1.Location = new System.Drawing.Point(9, 109);
            this.ctlDriverInfo1.Name = "ctlDriverInfo1";
            this.ctlDriverInfo1.Size = new System.Drawing.Size(792, 308);
            this.ctlDriverInfo1.TabIndex = 119;
            // 
            // frmReplacment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 630);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.ll_ShowInfo);
            this.Controls.Add(this.ll_ShowHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctlDriverInfo1);
            this.Name = "frmReplacment";
            this.Text = "frmReplacment";
            this.Load += new System.EventHandler(this.frmReplacment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.LinkLabel ll_ShowInfo;
        private System.Windows.Forms.LinkLabel ll_ShowHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lb_CreatedBy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_Fees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_ApplicationDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_OldLicense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_RenewdLicense;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_NewLicenseAppID;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_LicneseSerch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Searching;
        private LocalControls.ctlDriverInfo ctlDriverInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rd_Damage;
        private System.Windows.Forms.RadioButton rd_Lost;
    }
}