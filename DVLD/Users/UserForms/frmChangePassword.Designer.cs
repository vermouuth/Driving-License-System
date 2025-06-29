namespace MyLicensesSystem.Manage.Users
{
    partial class frmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePassword));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_Current = new System.Windows.Forms.TextBox();
            this.txt_Confirm = new System.Windows.Forms.TextBox();
            this.txt_New = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctlUserInfo1 = new MyLicensesSystem.MyControls.UserControls.ctlUserInfo();
            this.ctlPersonCard1 = new MyLicensesSystem.MyControls.ctlPersonCard();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(176, 351);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(20, 19);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 425);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(176, 388);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // txt_Current
            // 
            this.txt_Current.Location = new System.Drawing.Point(206, 351);
            this.txt_Current.Multiline = true;
            this.txt_Current.Name = "txt_Current";
            this.txt_Current.PasswordChar = '*';
            this.txt_Current.Size = new System.Drawing.Size(133, 19);
            this.txt_Current.TabIndex = 19;
            this.txt_Current.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Current_Validating);
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.Location = new System.Drawing.Point(206, 424);
            this.txt_Confirm.Multiline = true;
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.PasswordChar = '*';
            this.txt_Confirm.Size = new System.Drawing.Size(133, 19);
            this.txt_Confirm.TabIndex = 20;
            this.txt_Confirm.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Confirm_Validating);
            // 
            // txt_New
            // 
            this.txt_New.Location = new System.Drawing.Point(206, 387);
            this.txt_New.Multiline = true;
            this.txt_New.Name = "txt_New";
            this.txt_New.PasswordChar = '*';
            this.txt_New.Size = new System.Drawing.Size(133, 19);
            this.txt_New.TabIndex = 21;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(501, 466);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(123, 37);
            this.btn_close.TabIndex = 23;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(630, 466);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(123, 37);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctlUserInfo1
            // 
            this.ctlUserInfo1.Location = new System.Drawing.Point(7, 266);
            this.ctlUserInfo1.Name = "ctlUserInfo1";
            this.ctlUserInfo1.Size = new System.Drawing.Size(747, 61);
            this.ctlUserInfo1.TabIndex = 1;
            // 
            // ctlPersonCard1
            // 
            this.ctlPersonCard1.Location = new System.Drawing.Point(-2, 12);
            this.ctlPersonCard1.Name = "ctlPersonCard1";
            this.ctlPersonCard1.Size = new System.Drawing.Size(755, 257);
            this.ctlPersonCard1.TabIndex = 0;
            this.ctlPersonCard1.OnEditClicked += new System.Action<int>(this.ctlPersonCard1_OnEditClicked);
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 514);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_New);
            this.Controls.Add(this.txt_Confirm);
            this.Controls.Add(this.txt_Current);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlUserInfo1);
            this.Controls.Add(this.ctlPersonCard1);
            this.Name = "frmChangePassword";
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyControls.ctlPersonCard ctlPersonCard1;
        private MyControls.UserControls.ctlUserInfo ctlUserInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txt_Current;
        private System.Windows.Forms.TextBox txt_New;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_Confirm;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}