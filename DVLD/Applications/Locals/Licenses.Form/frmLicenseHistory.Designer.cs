namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms
{
    partial class frmLicenseHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseHistory));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tb_Local = new System.Windows.Forms.TabPage();
            this.dgv_LocalList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicesneInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Liceense = new System.Windows.Forms.Label();
            this.tb_interNational = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_InternationalList = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_CurrentRecords = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.ctlSearchinPerson1 = new MyLicensesSystem.ctlSearchinPerson();
            this.tabControl1.SuspendLayout();
            this.tb_Local.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tb_interNational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tb_Local);
            this.tabControl1.Controls.Add(this.tb_interNational);
            this.tabControl1.Location = new System.Drawing.Point(7, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(810, 216);
            this.tabControl1.TabIndex = 1;
            // 
            // tb_Local
            // 
            this.tb_Local.Controls.Add(this.dgv_LocalList);
            this.tb_Local.Controls.Add(this.lb_Liceense);
            this.tb_Local.Location = new System.Drawing.Point(4, 22);
            this.tb_Local.Name = "tb_Local";
            this.tb_Local.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Local.Size = new System.Drawing.Size(802, 190);
            this.tb_Local.TabIndex = 0;
            this.tb_Local.Text = "Local";
            this.tb_Local.UseVisualStyleBackColor = true;
            // 
            // dgv_LocalList
            // 
            this.dgv_LocalList.AllowUserToAddRows = false;
            this.dgv_LocalList.AllowUserToDeleteRows = false;
            this.dgv_LocalList.AllowUserToOrderColumns = true;
            this.dgv_LocalList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_LocalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LocalList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_LocalList.Location = new System.Drawing.Point(9, 40);
            this.dgv_LocalList.Name = "dgv_LocalList";
            this.dgv_LocalList.ReadOnly = true;
            this.dgv_LocalList.Size = new System.Drawing.Size(782, 144);
            this.dgv_LocalList.TabIndex = 5;
            this.dgv_LocalList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_LocalList_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicesneInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 42);
            // 
            // showLicesneInfoToolStripMenuItem
            // 
            this.showLicesneInfoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicesneInfoToolStripMenuItem.Image")));
            this.showLicesneInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showLicesneInfoToolStripMenuItem.Name = "showLicesneInfoToolStripMenuItem";
            this.showLicesneInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.showLicesneInfoToolStripMenuItem.Text = "Show Licesne Info";
            this.showLicesneInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicesneInfoToolStripMenuItem_Click);
            // 
            // lb_Liceense
            // 
            this.lb_Liceense.AutoSize = true;
            this.lb_Liceense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Liceense.Location = new System.Drawing.Point(6, 13);
            this.lb_Liceense.Name = "lb_Liceense";
            this.lb_Liceense.Size = new System.Drawing.Size(168, 16);
            this.lb_Liceense.TabIndex = 4;
            this.lb_Liceense.Text = "Local Licenses History:";
            // 
            // tb_interNational
            // 
            this.tb_interNational.Controls.Add(this.label2);
            this.tb_interNational.Controls.Add(this.dgv_InternationalList);
            this.tb_interNational.Location = new System.Drawing.Point(4, 22);
            this.tb_interNational.Name = "tb_interNational";
            this.tb_interNational.Padding = new System.Windows.Forms.Padding(3);
            this.tb_interNational.Size = new System.Drawing.Size(802, 190);
            this.tb_interNational.TabIndex = 1;
            this.tb_interNational.Text = "International";
            this.tb_interNational.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "International Licenses History:";
            // 
            // dgv_InternationalList
            // 
            this.dgv_InternationalList.AllowUserToAddRows = false;
            this.dgv_InternationalList.AllowUserToDeleteRows = false;
            this.dgv_InternationalList.AllowUserToOrderColumns = true;
            this.dgv_InternationalList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_InternationalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_InternationalList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_InternationalList.Location = new System.Drawing.Point(9, 40);
            this.dgv_InternationalList.Name = "dgv_InternationalList";
            this.dgv_InternationalList.ReadOnly = true;
            this.dgv_InternationalList.Size = new System.Drawing.Size(782, 144);
            this.dgv_InternationalList.TabIndex = 6;
            this.dgv_InternationalList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_InternationalList_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 334);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(15, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(829, 256);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver License";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "License History";
            // 
            // lb_CurrentRecords
            // 
            this.lb_CurrentRecords.AutoSize = true;
            this.lb_CurrentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentRecords.Location = new System.Drawing.Point(88, 653);
            this.lb_CurrentRecords.Name = "lb_CurrentRecords";
            this.lb_CurrentRecords.Size = new System.Drawing.Size(36, 13);
            this.lb_CurrentRecords.TabIndex = 53;
            this.lb_CurrentRecords.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "# Records";
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::MyLicensesSystem.Properties.Resources.close;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(730, 656);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(114, 36);
            this.btn_Close.TabIndex = 54;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ctlSearchinPerson1
            // 
            this.ctlSearchinPerson1.Location = new System.Drawing.Point(89, 32);
            this.ctlSearchinPerson1.Name = "ctlSearchinPerson1";
            this.ctlSearchinPerson1.Size = new System.Drawing.Size(755, 334);
            this.ctlSearchinPerson1.TabIndex = 0;
            this.ctlSearchinPerson1.OnEditClicked += new System.Action<int>(this.ctlSearchinPerson1_OnEditClicked);
            // 
            // frmLicenseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 700);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lb_CurrentRecords);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctlSearchinPerson1);
            this.Name = "frmLicenseHistory";
            this.Text = "frmLicenseHistory";
            this.Load += new System.EventHandler(this.frmLicenseHistory_Load);
            this.tabControl1.ResumeLayout(false);
            this.tb_Local.ResumeLayout(false);
            this.tb_Local.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LocalList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tb_interNational.ResumeLayout(false);
            this.tb_interNational.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_InternationalList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctlSearchinPerson ctlSearchinPerson1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tb_Local;
        private System.Windows.Forms.TabPage tb_interNational;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_Liceense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_CurrentRecords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.DataGridView dgv_InternationalList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_LocalList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showLicesneInfoToolStripMenuItem;
    }
}