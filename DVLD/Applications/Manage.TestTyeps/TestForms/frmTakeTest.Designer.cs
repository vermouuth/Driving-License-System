namespace MyLicensesSystem.Manage.Applications.Manage.TestTyeps.TestForms
{
    partial class frmTakeTest
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
            this.ctlTakeTest1 = new MyLicensesSystem.Manage.Applications.Manage.TestTyeps.TestsControls.ctlTakeTest();
            this.SuspendLayout();
            // 
            // ctlTakeTest1
            // 
            this.ctlTakeTest1.Location = new System.Drawing.Point(0, 0);
            this.ctlTakeTest1.Name = "ctlTakeTest1";
            this.ctlTakeTest1.Size = new System.Drawing.Size(443, 726);
            this.ctlTakeTest1.TabIndex = 0;
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 729);
            this.Controls.Add(this.ctlTakeTest1);
            this.Name = "frmTakeTest";
            this.Text = "frmTakeTest";
            this.Load += new System.EventHandler(this.frmTakeTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TestsControls.ctlTakeTest ctlTakeTest1;
    }
}