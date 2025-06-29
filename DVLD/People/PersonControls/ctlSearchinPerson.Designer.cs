namespace MyLicensesSystem
{
    partial class ctlSearchinPerson
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctlSearchinPerson));
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Finding = new System.Windows.Forms.ComboBox();
            this.txt_Searching = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ctlPersonCard1 = new MyLicensesSystem.MyControls.ctlPersonCard();
            this.ll_EditInfo = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find By:";
            // 
            // cb_Finding
            // 
            this.cb_Finding.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Finding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Finding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Finding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Finding.FormattingEnabled = true;
            this.cb_Finding.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_Finding.Items.AddRange(new object[] {
            "PersonID",
            "National No"});
            this.cb_Finding.Location = new System.Drawing.Point(83, 19);
            this.cb_Finding.Name = "cb_Finding";
            this.cb_Finding.Size = new System.Drawing.Size(186, 24);
            this.cb_Finding.TabIndex = 2;
            // 
            // txt_Searching
            // 
            this.txt_Searching.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_Searching.Location = new System.Drawing.Point(274, 18);
            this.txt_Searching.Multiline = true;
            this.txt_Searching.Name = "txt_Searching";
            this.txt_Searching.Size = new System.Drawing.Size(161, 24);
            this.txt_Searching.TabIndex = 3;
            this.txt_Searching.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Searching_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(441, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 29);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cb_Finding);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Searching);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(14, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 51);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(479, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 29);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // ctlPersonCard1
            // 
            this.ctlPersonCard1.Location = new System.Drawing.Point(3, 84);
            this.ctlPersonCard1.Name = "ctlPersonCard1";
            this.ctlPersonCard1.Size = new System.Drawing.Size(758, 251);
            this.ctlPersonCard1.TabIndex = 6;
            // 
            // ll_EditInfo
            // 
            this.ll_EditInfo.AutoSize = true;
            this.ll_EditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_EditInfo.Location = new System.Drawing.Point(597, 131);
            this.ll_EditInfo.Name = "ll_EditInfo";
            this.ll_EditInfo.Size = new System.Drawing.Size(134, 20);
            this.ll_EditInfo.TabIndex = 9;
            this.ll_EditInfo.TabStop = true;
            this.ll_EditInfo.Text = "Edit Person\'s Info";
            this.ll_EditInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_EditInfo_LinkClicked);
            // 
            // ctlSearchinPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ll_EditInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctlPersonCard1);
            this.Name = "ctlSearchinPerson";
            this.Size = new System.Drawing.Size(771, 351);
            this.Load += new System.EventHandler(this.ctlSearchinPerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Finding;
        private System.Windows.Forms.TextBox txt_Searching;
        private System.Windows.Forms.Button button1;
        private MyControls.ctlPersonCard ctlPersonCard1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel ll_EditInfo;
    }
}
