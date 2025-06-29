namespace MyLicensesSystem.ManagePeople
{
    partial class frmPersonDetails
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
            this.SuspendLayout();
            // 
            // ctlPersonCard1
            // 
            this.ctlPersonCard1.Location = new System.Drawing.Point(1, -4);
            this.ctlPersonCard1.Name = "ctlPersonCard1";
            this.ctlPersonCard1.Size = new System.Drawing.Size(766, 250);
            this.ctlPersonCard1.TabIndex = 0;
            this.ctlPersonCard1.OnEditClicked += new System.Action<int>(this.ctlPersonCard1_OnEditClicked);
            // 
            // frmPersonDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 248);
            this.Controls.Add(this.ctlPersonCard1);
            this.Name = "frmPersonDetails";
            this.Text = "frmPersonDetails";
            this.Load += new System.EventHandler(this.frmPersonDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MyControls.ctlPersonCard ctlPersonCard1;
    }
}