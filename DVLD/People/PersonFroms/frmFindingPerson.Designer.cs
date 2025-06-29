namespace MyLicensesSystem.Manage.Users
{
    partial class frmFindingPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFindingPerson));
            this.btn_Close = new System.Windows.Forms.Button();
            this.ctlSearchinPerson1 = new MyLicensesSystem.ctlSearchinPerson();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.White;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(630, 352);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(114, 35);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ctlSearchinPerson1
            // 
            this.ctlSearchinPerson1.Location = new System.Drawing.Point(6, 12);
            this.ctlSearchinPerson1.Name = "ctlSearchinPerson1";
            this.ctlSearchinPerson1.Size = new System.Drawing.Size(749, 334);
            this.ctlSearchinPerson1.TabIndex = 0;
            this.ctlSearchinPerson1.OnEditClicked += new System.Action<int>(this.ctlSearchinPerson1_OnEditClicked);
            this.ctlSearchinPerson1.OnAddClicked += new System.Action<int>(this.ctlSearchinPerson1_OnAddClicked_1);
            // 
            // frmFindingPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 393);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.ctlSearchinPerson1);
            this.Name = "frmFindingPerson";
            this.Text = "frmFindingPerson";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Close;
        private ctlSearchinPerson ctlSearchinPerson1;
    }
}