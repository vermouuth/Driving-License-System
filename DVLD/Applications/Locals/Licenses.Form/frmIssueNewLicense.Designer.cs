namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalForms
{
    partial class frmIssueNewLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueNewLicense));
            this.ctlAppInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalControls.ctlAppInfo();
            this.ctlApplicationBasicInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalControls.ctlApplicationBasicInfo();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlAppInfo1
            // 
            this.ctlAppInfo1.Location = new System.Drawing.Point(-1, 12);
            this.ctlAppInfo1.Name = "ctlAppInfo1";
            this.ctlAppInfo1.Size = new System.Drawing.Size(789, 137);
            this.ctlAppInfo1.TabIndex = 0;
            // 
            // ctlApplicationBasicInfo1
            // 
            this.ctlApplicationBasicInfo1.Location = new System.Drawing.Point(5, 155);
            this.ctlApplicationBasicInfo1.Name = "ctlApplicationBasicInfo1";
            this.ctlApplicationBasicInfo1.Size = new System.Drawing.Size(783, 240);
            this.ctlApplicationBasicInfo1.TabIndex = 1;
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(90, 413);
            this.txt_Notes.Multiline = true;
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(691, 131);
            this.txt_Notes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(66, 413);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Image = ((System.Drawing.Image)(resources.GetObject("btn_Save.Image")));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_Save.Location = new System.Drawing.Point(658, 558);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 33);
            this.btn_Save.TabIndex = 44;
            this.btn_Save.Text = "Issue";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(522, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 45;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmIssueNewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.ctlApplicationBasicInfo1);
            this.Controls.Add(this.ctlAppInfo1);
            this.Name = "frmIssueNewLicense";
            this.Text = "frmIssueNewLicense";
            this.Load += new System.EventHandler(this.frmIssueNewLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LocalControls.ctlAppInfo ctlAppInfo1;
        private LocalControls.ctlApplicationBasicInfo ctlApplicationBasicInfo1;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button button1;
    }
}