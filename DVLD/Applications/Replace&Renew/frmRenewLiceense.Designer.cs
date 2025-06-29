namespace MyLicensesSystem
{
    partial class frmRenewLiceense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRenewLiceense));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctlDriverInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalControls.ctlDriverInfo();
            this.txt_Searching = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_LicneseSerch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lb_NewLicenseAppID = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_RenewdLicense = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_OldLicense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ApplicationDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_IssueDate = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_AppFees = new System.Windows.Forms.Label();
            this.picGendor = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_LicenseFees = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_ExDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lb_CreatedBy = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lb_TotalFees = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ll_ShowHistory = new System.Windows.Forms.LinkLabel();
            this.ll_ShowInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(238, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Renew License Applications";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Save.Location = new System.Drawing.Point(663, 729);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 33);
            this.btn_Save.TabIndex = 117;
            this.btn_Save.Text = "Issue";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(527, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 118;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctlDriverInfo1
            // 
            this.ctlDriverInfo1.Location = new System.Drawing.Point(5, 130);
            this.ctlDriverInfo1.Name = "ctlDriverInfo1";
            this.ctlDriverInfo1.Size = new System.Drawing.Size(792, 308);
            this.ctlDriverInfo1.TabIndex = 0;
            // 
            // txt_Searching
            // 
            this.txt_Searching.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Searching.Location = new System.Drawing.Point(97, 18);
            this.txt_Searching.Multiline = true;
            this.txt_Searching.Name = "txt_Searching";
            this.txt_Searching.Size = new System.Drawing.Size(235, 24);
            this.txt_Searching.TabIndex = 3;
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
            // btn_LicneseSerch
            // 
            this.btn_LicneseSerch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_LicneseSerch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_LicneseSerch.BackgroundImage")));
            this.btn_LicneseSerch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_LicneseSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LicneseSerch.Location = new System.Drawing.Point(338, 15);
            this.btn_LicneseSerch.Name = "btn_LicneseSerch";
            this.btn_LicneseSerch.Size = new System.Drawing.Size(32, 29);
            this.btn_LicneseSerch.TabIndex = 5;
            this.btn_LicneseSerch.UseVisualStyleBackColor = false;
            this.btn_LicneseSerch.Click += new System.EventHandler(this.btn_LicneseSerch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LicneseSerch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Searching);
            this.groupBox2.Location = new System.Drawing.Point(17, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 60);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 18);
            this.label12.TabIndex = 62;
            this.label12.Text = "R.L.Application ID:";
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
            // lb_NewLicenseAppID
            // 
            this.lb_NewLicenseAppID.AutoSize = true;
            this.lb_NewLicenseAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewLicenseAppID.Location = new System.Drawing.Point(190, 32);
            this.lb_NewLicenseAppID.Name = "lb_NewLicenseAppID";
            this.lb_NewLicenseAppID.Size = new System.Drawing.Size(54, 18);
            this.lb_NewLicenseAppID.TabIndex = 69;
            this.lb_NewLicenseAppID.Text = "[????]";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 18);
            this.label3.TabIndex = 63;
            this.label3.Text = "Renewed License ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 72;
            this.label2.Text = "Application Date:";
            // 
            // lb_ApplicationDate
            // 
            this.lb_ApplicationDate.AutoSize = true;
            this.lb_ApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ApplicationDate.Location = new System.Drawing.Point(190, 66);
            this.lb_ApplicationDate.Name = "lb_ApplicationDate";
            this.lb_ApplicationDate.Size = new System.Drawing.Size(54, 18);
            this.lb_ApplicationDate.TabIndex = 73;
            this.lb_ApplicationDate.Text = "[????]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 18);
            this.label7.TabIndex = 74;
            this.label7.Text = "Issue Date:";
            // 
            // lb_IssueDate
            // 
            this.lb_IssueDate.AutoSize = true;
            this.lb_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_IssueDate.Location = new System.Drawing.Point(190, 99);
            this.lb_IssueDate.Name = "lb_IssueDate";
            this.lb_IssueDate.Size = new System.Drawing.Size(54, 18);
            this.lb_IssueDate.TabIndex = 76;
            this.lb_IssueDate.Text = "[????]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 18);
            this.label9.TabIndex = 77;
            this.label9.Text = "Applicaiton Fees:";
            // 
            // lb_AppFees
            // 
            this.lb_AppFees.AutoSize = true;
            this.lb_AppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppFees.Location = new System.Drawing.Point(190, 134);
            this.lb_AppFees.Name = "lb_AppFees";
            this.lb_AppFees.Size = new System.Drawing.Size(54, 18);
            this.lb_AppFees.TabIndex = 79;
            this.lb_AppFees.Text = "[????]";
            // 
            // picGendor
            // 
            this.picGendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGendor.Image = ((System.Drawing.Image)(resources.GetObject("picGendor.Image")));
            this.picGendor.Location = new System.Drawing.Point(157, 169);
            this.picGendor.Name = "picGendor";
            this.picGendor.Size = new System.Drawing.Size(20, 18);
            this.picGendor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGendor.TabIndex = 81;
            this.picGendor.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 18);
            this.label11.TabIndex = 80;
            this.label11.Text = "License Fees:";
            // 
            // lb_LicenseFees
            // 
            this.lb_LicenseFees.AutoSize = true;
            this.lb_LicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LicenseFees.Location = new System.Drawing.Point(190, 168);
            this.lb_LicenseFees.Name = "lb_LicenseFees";
            this.lb_LicenseFees.Size = new System.Drawing.Size(54, 18);
            this.lb_LicenseFees.TabIndex = 82;
            this.lb_LicenseFees.Text = "[????]";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(342, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 18);
            this.label13.TabIndex = 83;
            this.label13.Text = "Expiration Date:";
            // 
            // lb_ExDate
            // 
            this.lb_ExDate.AutoSize = true;
            this.lb_ExDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ExDate.Location = new System.Drawing.Point(545, 101);
            this.lb_ExDate.Name = "lb_ExDate";
            this.lb_ExDate.Size = new System.Drawing.Size(54, 18);
            this.lb_ExDate.TabIndex = 85;
            this.lb_ExDate.Text = "[????]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 18);
            this.label10.TabIndex = 89;
            this.label10.Text = "Notes:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(342, 134);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 18);
            this.label17.TabIndex = 96;
            this.label17.Text = "Created By:";
            // 
            // lb_CreatedBy
            // 
            this.lb_CreatedBy.AutoSize = true;
            this.lb_CreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreatedBy.Location = new System.Drawing.Point(545, 133);
            this.lb_CreatedBy.Name = "lb_CreatedBy";
            this.lb_CreatedBy.Size = new System.Drawing.Size(54, 18);
            this.lb_CreatedBy.TabIndex = 98;
            this.lb_CreatedBy.Text = "[????]";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(342, 168);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(93, 18);
            this.label19.TabIndex = 99;
            this.label19.Text = "Total Fees:";
            // 
            // lb_TotalFees
            // 
            this.lb_TotalFees.AutoSize = true;
            this.lb_TotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalFees.Location = new System.Drawing.Point(545, 168);
            this.lb_TotalFees.Name = "lb_TotalFees";
            this.lb_TotalFees.Size = new System.Drawing.Size(54, 18);
            this.lb_TotalFees.TabIndex = 101;
            this.lb_TotalFees.Text = "[????]";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(157, 202);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(20, 18);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 103;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(157, 135);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(20, 18);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 104;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(521, 136);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(20, 18);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 106;
            this.pictureBox11.TabStop = false;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(193, 203);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(404, 60);
            this.txtNotes.TabIndex = 107;
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
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(157, 100);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 18);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 109;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(157, 66);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 110;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.InitialImage")));
            this.pictureBox5.Location = new System.Drawing.Point(157, 32);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 111;
            this.pictureBox5.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox7);
            this.groupBox1.Controls.Add(this.pictureBox6);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.pictureBox11);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox15);
            this.groupBox1.Controls.Add(this.pictureBox10);
            this.groupBox1.Controls.Add(this.lb_TotalFees);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lb_CreatedBy);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lb_ExDate);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lb_LicenseFees);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.picGendor);
            this.groupBox1.Controls.Add(this.lb_AppFees);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_IssueDate);
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
            this.groupBox1.Location = new System.Drawing.Point(17, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 267);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Application New License Info";
            // 
            // ll_ShowHistory
            // 
            this.ll_ShowHistory.AutoSize = true;
            this.ll_ShowHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_ShowHistory.LinkColor = System.Drawing.Color.DimGray;
            this.ll_ShowHistory.Location = new System.Drawing.Point(15, 742);
            this.ll_ShowHistory.Name = "ll_ShowHistory";
            this.ll_ShowHistory.Size = new System.Drawing.Size(181, 20);
            this.ll_ShowHistory.TabIndex = 115;
            this.ll_ShowHistory.TabStop = true;
            this.ll_ShowHistory.Text = "Show License History";
            this.ll_ShowHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ShowHistory_LinkClicked);
            // 
            // ll_ShowInfo
            // 
            this.ll_ShowInfo.AutoSize = true;
            this.ll_ShowInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_ShowInfo.LinkColor = System.Drawing.Color.DimGray;
            this.ll_ShowInfo.Location = new System.Drawing.Point(201, 742);
            this.ll_ShowInfo.Name = "ll_ShowInfo";
            this.ll_ShowInfo.Size = new System.Drawing.Size(157, 20);
            this.ll_ShowInfo.TabIndex = 116;
            this.ll_ShowInfo.TabStop = true;
            this.ll_ShowInfo.Text = "Show License Info";
            this.ll_ShowInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_ShowInfo_LinkClicked);
            // 
            // frmRenewLiceense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 769);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.ll_ShowInfo);
            this.Controls.Add(this.ll_ShowHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ctlDriverInfo1);
            this.Name = "frmRenewLiceense";
            this.Text = "TestingForam";
            this.Load += new System.EventHandler(this.TestingForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button1;
        private Manage.Applications.Driving.Licenses.Services.LocalControls.ctlDriverInfo ctlDriverInfo1;
        private System.Windows.Forms.TextBox txt_Searching;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_LicneseSerch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lb_NewLicenseAppID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_RenewdLicense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_OldLicense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ApplicationDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_IssueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_AppFees;
        private System.Windows.Forms.PictureBox picGendor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_LicenseFees;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_ExDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lb_CreatedBy;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_TotalFees;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel ll_ShowHistory;
        private System.Windows.Forms.LinkLabel ll_ShowInfo;
    }
}