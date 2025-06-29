namespace MyLicensesSystem.Manage.Applications.Manage.TestTyeps.TestForms
{
    partial class frmAddTestAppointment
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
            this.ctlTestAppiontment1 = new MyLicensesSystem.Manage.Tests.TestControls.ctlTestAppiontment();
            this.SuspendLayout();
            // 
            // ctlTestAppiontment1
            // 
            this.ctlTestAppiontment1.Location = new System.Drawing.Point(5, 1);
            this.ctlTestAppiontment1.Name = "ctlTestAppiontment1";
            this.ctlTestAppiontment1.Size = new System.Drawing.Size(449, 665);
            this.ctlTestAppiontment1.TabIndex = 0;
            // 
            // frmAddTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 665);
            this.Controls.Add(this.ctlTestAppiontment1);
            this.Name = "frmAddTestAppointment";
            this.Text = "frmAddTestAppointment";
            this.Load += new System.EventHandler(this.frmAddTestAppointment_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Tests.TestControls.ctlTestAppiontment ctlTestAppiontment1;
    }
}