namespace MyLicensesSystem.Manage.Users.UserForms
{
    partial class frmUserDetails
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
            this.ctlPersonCard1 = new MyLicensesSystem.MyControls.ctlPersonCard();
            this.ctlUserInfo1 = new MyLicensesSystem.MyControls.UserControls.ctlUserInfo();
            this.SuspendLayout();
            // 
            // ctlPersonCard1
            // 
            this.ctlPersonCard1.Location = new System.Drawing.Point(-1, 7);
            this.ctlPersonCard1.Name = "ctlPersonCard1";
            this.ctlPersonCard1.Size = new System.Drawing.Size(754, 257);
            this.ctlPersonCard1.TabIndex = 0;
            this.ctlPersonCard1.OnEditClicked += new System.Action<int>(this.ctlPersonCard1_OnEditClicked);
            // 
            // ctlUserInfo1
            // 
            this.ctlUserInfo1.Location = new System.Drawing.Point(6, 270);
            this.ctlUserInfo1.Name = "ctlUserInfo1";
            this.ctlUserInfo1.Size = new System.Drawing.Size(748, 63);
            this.ctlUserInfo1.TabIndex = 1;
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 345);
            this.Controls.Add(this.ctlUserInfo1);
            this.Controls.Add(this.ctlPersonCard1);
            this.Name = "frmUserDetails";
            this.Text = "frmUserDetails";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.ctlPersonCard ctlPersonCard1;
        private MyControls.UserControls.ctlUserInfo ctlUserInfo1;
    }
}