namespace MyLicensesSystem.Main
{
    partial class frmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUser));
            this.lb_Modeling = new System.Windows.Forms.Label();
            this.tab_Control = new System.Windows.Forms.TabControl();
            this.tb_PersonInfo = new System.Windows.Forms.TabPage();
            this.btn_SelectPerson = new System.Windows.Forms.Button();
            this.ctlPersonCard1 = new MyLicensesSystem.MyControls.ctlPersonCard();
            this.tb_Logininfo = new System.Windows.Forms.TabPage();
            this.lb_UserID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chb_isActive = new System.Windows.Forms.CheckBox();
            this.txt_Confirm = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.tab_Control.SuspendLayout();
            this.tb_PersonInfo.SuspendLayout();
            this.tb_Logininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Modeling
            // 
            this.lb_Modeling.AutoSize = true;
            this.lb_Modeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Modeling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Modeling.Location = new System.Drawing.Point(279, 21);
            this.lb_Modeling.Name = "lb_Modeling";
            this.lb_Modeling.Size = new System.Drawing.Size(201, 31);
            this.lb_Modeling.TabIndex = 1;
            this.lb_Modeling.Text = "Add New User";
            // 
            // tab_Control
            // 
            this.tab_Control.Controls.Add(this.tb_PersonInfo);
            this.tab_Control.Controls.Add(this.tb_Logininfo);
            this.tab_Control.Location = new System.Drawing.Point(12, 55);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.SelectedIndex = 0;
            this.tab_Control.Size = new System.Drawing.Size(771, 332);
            this.tab_Control.TabIndex = 4;
            // 
            // tb_PersonInfo
            // 
            this.tb_PersonInfo.Controls.Add(this.btn_Next);
            this.tb_PersonInfo.Controls.Add(this.btn_SelectPerson);
            this.tb_PersonInfo.Controls.Add(this.ctlPersonCard1);
            this.tb_PersonInfo.Location = new System.Drawing.Point(4, 22);
            this.tb_PersonInfo.Name = "tb_PersonInfo";
            this.tb_PersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tb_PersonInfo.Size = new System.Drawing.Size(763, 306);
            this.tb_PersonInfo.TabIndex = 0;
            this.tb_PersonInfo.Text = "Person info";
            this.tb_PersonInfo.UseVisualStyleBackColor = true;
            // 
            // btn_SelectPerson
            // 
            this.btn_SelectPerson.BackColor = System.Drawing.Color.White;
            this.btn_SelectPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectPerson.Location = new System.Drawing.Point(596, 38);
            this.btn_SelectPerson.Name = "btn_SelectPerson";
            this.btn_SelectPerson.Size = new System.Drawing.Size(149, 35);
            this.btn_SelectPerson.TabIndex = 5;
            this.btn_SelectPerson.Text = "Select a Person";
            this.btn_SelectPerson.UseVisualStyleBackColor = false;
            this.btn_SelectPerson.Click += new System.EventHandler(this.btn_SelectPerson_Click);
            // 
            // ctlPersonCard1
            // 
            this.ctlPersonCard1.Location = new System.Drawing.Point(8, 8);
            this.ctlPersonCard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctlPersonCard1.Name = "ctlPersonCard1";
            this.ctlPersonCard1.Size = new System.Drawing.Size(764, 255);
            this.ctlPersonCard1.TabIndex = 4;
            // 
            // tb_Logininfo
            // 
            this.tb_Logininfo.Controls.Add(this.chb_isActive);
            this.tb_Logininfo.Controls.Add(this.txt_Password);
            this.tb_Logininfo.Controls.Add(this.txt_Confirm);
            this.tb_Logininfo.Controls.Add(this.txt_UserName);
            this.tb_Logininfo.Controls.Add(this.lb_UserID);
            this.tb_Logininfo.Controls.Add(this.pictureBox4);
            this.tb_Logininfo.Controls.Add(this.pictureBox3);
            this.tb_Logininfo.Controls.Add(this.pictureBox2);
            this.tb_Logininfo.Controls.Add(this.pictureBox1);
            this.tb_Logininfo.Controls.Add(this.label5);
            this.tb_Logininfo.Controls.Add(this.label4);
            this.tb_Logininfo.Controls.Add(this.label3);
            this.tb_Logininfo.Controls.Add(this.label2);
            this.tb_Logininfo.Location = new System.Drawing.Point(4, 22);
            this.tb_Logininfo.Name = "tb_Logininfo";
            this.tb_Logininfo.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Logininfo.Size = new System.Drawing.Size(763, 306);
            this.tb_Logininfo.TabIndex = 1;
            this.tb_Logininfo.Text = "Login info";
            this.tb_Logininfo.UseVisualStyleBackColor = true;
            // 
            // lb_UserID
            // 
            this.lb_UserID.AutoSize = true;
            this.lb_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_UserID.Location = new System.Drawing.Point(239, 32);
            this.lb_UserID.Name = "lb_UserID";
            this.lb_UserID.Size = new System.Drawing.Size(35, 18);
            this.lb_UserID.TabIndex = 21;
            this.lb_UserID.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "User ID:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(527, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 37);
            this.button4.TabIndex = 6;
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
            this.btn_Save.Location = new System.Drawing.Point(656, 393);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(123, 37);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Next.Image = ((System.Drawing.Image)(resources.GetObject("btn_Next.Image")));
            this.btn_Next.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Next.Location = new System.Drawing.Point(596, 263);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(149, 35);
            this.btn_Next.TabIndex = 5;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(197, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 18);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(197, 102);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(197, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 18);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // chb_isActive
            // 
            this.chb_isActive.AutoSize = true;
            this.chb_isActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_isActive.Location = new System.Drawing.Point(232, 178);
            this.chb_isActive.Name = "chb_isActive";
            this.chb_isActive.Size = new System.Drawing.Size(75, 17);
            this.chb_isActive.TabIndex = 25;
            this.chb_isActive.Text = "is Active";
            this.chb_isActive.UseVisualStyleBackColor = true;
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.Location = new System.Drawing.Point(232, 137);
            this.txt_Confirm.Multiline = true;
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.PasswordChar = '*';
            this.txt_Confirm.Size = new System.Drawing.Size(132, 20);
            this.txt_Confirm.TabIndex = 24;
            this.txt_Confirm.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Confirm_Validating);
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(232, 65);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(132, 20);
            this.txt_UserName.TabIndex = 22;
            this.txt_UserName.Validating += new System.ComponentModel.CancelEventHandler(this.txt_UserName_Validating);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(232, 101);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(132, 20);
            this.txt_Password.TabIndex = 23;
            this.txt_Password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Confirm_Validating);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 436);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tab_Control);
            this.Controls.Add(this.lb_Modeling);
            this.Name = "frmAddNewUser";
            this.Text = "Testing";
            this.Load += new System.EventHandler(this.frmAddNewUser_Load);
            this.tab_Control.ResumeLayout(false);
            this.tb_PersonInfo.ResumeLayout(false);
            this.tb_Logininfo.ResumeLayout(false);
            this.tb_Logininfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tab_Control;
        private System.Windows.Forms.TabPage tb_PersonInfo;
        private System.Windows.Forms.Button btn_SelectPerson;
        private MyControls.ctlPersonCard ctlPersonCard1;
        private System.Windows.Forms.TabPage tb_Logininfo;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lb_UserID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lb_Modeling;
        private System.Windows.Forms.CheckBox chb_isActive;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Confirm;
        private System.Windows.Forms.TextBox txt_UserName;
    }
}