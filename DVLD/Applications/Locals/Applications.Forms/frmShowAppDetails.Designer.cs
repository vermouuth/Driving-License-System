namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalForms
{
    partial class frmShowAppDetails
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
            this.ctlApplicationBasicInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalControls.ctlApplicationBasicInfo();
            this.ctlAppInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalControls.ctlAppInfo();
            this.SuspendLayout();
            // 
            // ctlApplicationBasicInfo1
            // 
            this.ctlApplicationBasicInfo1.Location = new System.Drawing.Point(11, 150);
            this.ctlApplicationBasicInfo1.Name = "ctlApplicationBasicInfo1";
            this.ctlApplicationBasicInfo1.Size = new System.Drawing.Size(776, 240);
            this.ctlApplicationBasicInfo1.TabIndex = 1;
            this.ctlApplicationBasicInfo1.OnViewClicked += new System.Action<int>(this.ctlApplicationBasicInfo1_OnViewClicked);
            // 
            // ctlAppInfo1
            // 
            this.ctlAppInfo1.Location = new System.Drawing.Point(11, 14);
            this.ctlAppInfo1.Name = "ctlAppInfo1";
            this.ctlAppInfo1.Size = new System.Drawing.Size(790, 136);
            this.ctlAppInfo1.TabIndex = 0;
            // 
            // frmShowAppDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.ctlApplicationBasicInfo1);
            this.Controls.Add(this.ctlAppInfo1);
            this.Name = "frmShowAppDetails";
            this.Text = "frmShowAppDetails";
            this.Load += new System.EventHandler(this.frmShowAppDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LocalControls.ctlAppInfo ctlAppInfo1;
        private LocalControls.ctlApplicationBasicInfo ctlApplicationBasicInfo1;
    }
}