namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.New.Local.License
{
    partial class frmAddLocalApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddLocalApp));
            this.tab_Control = new System.Windows.Forms.TabControl();
            this.tb_PersonInfo = new System.Windows.Forms.TabPage();
            this.ctlSearchinPerson1 = new MyLicensesSystem.ctlSearchinPerson();
            this.btn_Next = new System.Windows.Forms.Button();
            this.tb_Applicationinfo = new System.Windows.Forms.TabPage();
            this.cb_Classes = new System.Windows.Forms.ComboBox();
            this.Lb_CreatedBY = new System.Windows.Forms.Label();
            this.lb_AppFees = new System.Windows.Forms.Label();
            this.lb_AppDate = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_AppID = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Modeling = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tab_Control.SuspendLayout();
            this.tb_PersonInfo.SuspendLayout();
            this.tb_Applicationinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_Control
            // 
            this.tab_Control.Controls.Add(this.tb_PersonInfo);
            this.tab_Control.Controls.Add(this.tb_Applicationinfo);
            this.tab_Control.Location = new System.Drawing.Point(5, 56);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(765, 412);
            this.tab_Control.TabIndex = 8;
            // 
            // tb_PersonInfo
            // 
            this.tb_PersonInfo.Controls.Add(this.ctlSearchinPerson1);
            this.tb_PersonInfo.Controls.Add(this.btn_Next);
            this.tb_PersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tb_PersonInfo.Name = "tb_PersonInfo";
            this.tb_PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tb_PersonInfo.Size = new System.Drawing.Size(757, 386);
            this.tb_PersonInfo.TabIndex = 0;
            this.tb_PersonInfo.Text = "Person info";
            this.tb_PersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctlSearchinPerson1
            // 
            this.ctlSearchinPerson1.Location = new System.Drawing.Point(0, 6);
            this.ctlSearchinPerson1.Name = "ctlSearchinPerson1";
            this.ctlSearchinPerson1.Size = new System.Drawing.Size(758, 337);
            this.ctlSearchinPerson1.TabIndex = 6;
            this.ctlSearchinPerson1.OnEditClicked += new System.Action<int>(this.ctlSearchinPerson1_OnEditClicked);
            this.ctlSearchinPerson1.OnAddClicked += new System.Action<int>(this.ctlSearchinPerson1_OnAddClicked_1);
            // 
            // btn_Next
            // 
            this.btn_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Next.Location = new System.Drawing.Point(590, 344);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(149, 35);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // tb_Applicationinfo
            // 
            this.tb_Applicationinfo.Controls.Add(this.cb_Classes);
            this.tb_Applicationinfo.Controls.Add(this.Lb_CreatedBY);
            this.tb_Applicationinfo.Controls.Add(this.lb_AppFees);
            this.tb_Applicationinfo.Controls.Add(this.lb_AppDate);
            this.tb_Applicationinfo.Controls.Add(this.pictureBox5);
            this.tb_Applicationinfo.Controls.Add(this.label1);
            this.tb_Applicationinfo.Controls.Add(this.lb_AppID);
            this.tb_Applicationinfo.Controls.Add(this.pictureBox4);
            this.tb_Applicationinfo.Controls.Add(this.pictureBox3);
            this.tb_Applicationinfo.Controls.Add(this.pictureBox2);
            this.tb_Applicationinfo.Controls.Add(this.pictureBox1);
            this.tb_Applicationinfo.Controls.Add(this.label5);
            this.tb_Applicationinfo.Controls.Add(this.label4);
            this.tb_Applicationinfo.Controls.Add(this.label3);
            this.tb_Applicationinfo.Controls.Add(this.label2);
            this.tb_Applicationinfo.Location = new System.Drawing.Point(4, 22);
            this.tb_Applicationinfo.Name = "tb_Applicationinfo";
            this.tb_Applicationinfo.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Applicationinfo.Size = new System.Drawing.Size(757, 386);
            this.tb_Applicationinfo.TabIndex = 1;
            this.tb_Applicationinfo.Text = "Application info";
            this.tb_Applicationinfo.UseVisualStyleBackColor = true;
            // 
            // cb_Classes
            // 
            this.cb_Classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Classes.FormattingEnabled = true;
            this.cb_Classes.Location = new System.Drawing.Point(240, 111);
            this.cb_Classes.Name = "cb_Classes";
            this.cb_Classes.Size = new System.Drawing.Size(209, 21);
            this.cb_Classes.TabIndex = 46;
            // 
            // Lb_CreatedBY
            // 
            this.Lb_CreatedBY.AutoSize = true;
            this.Lb_CreatedBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_CreatedBY.Location = new System.Drawing.Point(237, 181);
            this.Lb_CreatedBY.Name = "Lb_CreatedBY";
            this.Lb_CreatedBY.Size = new System.Drawing.Size(45, 18);
            this.Lb_CreatedBY.TabIndex = 45;
            this.Lb_CreatedBY.Text = "[???]";
            // 
            // lb_AppFees
            // 
            this.lb_AppFees.AutoSize = true;
            this.lb_AppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppFees.Location = new System.Drawing.Point(237, 144);
            this.lb_AppFees.Name = "lb_AppFees";
            this.lb_AppFees.Size = new System.Drawing.Size(45, 18);
            this.lb_AppFees.TabIndex = 44;
            this.lb_AppFees.Text = "[???]";
            // 
            // lb_AppDate
            // 
            this.lb_AppDate.AutoSize = true;
            this.lb_AppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppDate.Location = new System.Drawing.Point(237, 75);
            this.lb_AppDate.Name = "lb_AppDate";
            this.lb_AppDate.Size = new System.Drawing.Size(45, 18);
            this.lb_AppDate.TabIndex = 43;
            this.lb_AppDate.Text = "[???]";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(195, 182);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "Created By:";
            // 
            // lb_AppID
            // 
            this.lb_AppID.AutoSize = true;
            this.lb_AppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AppID.Location = new System.Drawing.Point(237, 39);
            this.lb_AppID.Name = "lb_AppID";
            this.lb_AppID.Size = new System.Drawing.Size(45, 18);
            this.lb_AppID.TabIndex = 40;
            this.lb_AppID.Text = "[???]";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(195, 145);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(195, 110);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(195, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Application Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "Applicaiton Fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "License Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "D.L Application ID:";
            // 
            // lb_Modeling
            // 
            this.lb_Modeling.AutoSize = true;
            this.lb_Modeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Modeling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Modeling.Location = new System.Drawing.Point(192, 22);
            this.lb_Modeling.Name = "lb_Modeling";
            this.lb_Modeling.Size = new System.Drawing.Size(445, 31);
            this.lb_Modeling.TabIndex = 7;
            this.lb_Modeling.Text = "Local Driving License Application";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(514, 474);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 37);
            this.button4.TabIndex = 10;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(643, 474);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(123, 37);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // frmAddLocalApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tab_Control);
            this.Controls.Add(this.lb_Modeling);
            this.Name = "frmAddLocalApp";
            this.Text = "frmNewLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmNewLocalDrivingLicenseApplication_Load);
            this.tab_Control.ResumeLayout(false);
            this.tb_PersonInfo.ResumeLayout(false);
            this.tb_Applicationinfo.ResumeLayout(false);
            this.tb_Applicationinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TabControl tab_Control;
        private System.Windows.Forms.TabPage tb_PersonInfo;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TabPage tb_Applicationinfo;
        private System.Windows.Forms.Label lb_Modeling;
        private ctlSearchinPerson ctlSearchinPerson1;
        private System.Windows.Forms.ComboBox cb_Classes;
        private System.Windows.Forms.Label Lb_CreatedBY;
        private System.Windows.Forms.Label lb_AppFees;
        private System.Windows.Forms.Label lb_AppDate;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_AppID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}