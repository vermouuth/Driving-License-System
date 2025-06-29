namespace MyLicensesSystem.Manage.TestTyeps
{
    partial class frmManageTestTyeps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageTestTyeps));
            this.lb_records = new System.Windows.Forms.Label();
            this.lb_rrmodel = new System.Windows.Forms.Label();
            this.dgv_TestTypes = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_Model = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestTypes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_records
            // 
            this.lb_records.AutoSize = true;
            this.lb_records.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_records.Location = new System.Drawing.Point(86, 592);
            this.lb_records.Name = "lb_records";
            this.lb_records.Size = new System.Drawing.Size(23, 16);
            this.lb_records.TabIndex = 12;
            this.lb_records.Text = "??";
            // 
            // lb_rrmodel
            // 
            this.lb_rrmodel.AutoSize = true;
            this.lb_rrmodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_rrmodel.Location = new System.Drawing.Point(9, 592);
            this.lb_rrmodel.Name = "lb_rrmodel";
            this.lb_rrmodel.Size = new System.Drawing.Size(74, 16);
            this.lb_rrmodel.TabIndex = 11;
            this.lb_rrmodel.Text = "#Records";
            // 
            // dgv_TestTypes
            // 
            this.dgv_TestTypes.AllowUserToAddRows = false;
            this.dgv_TestTypes.AllowUserToDeleteRows = false;
            this.dgv_TestTypes.AllowUserToOrderColumns = true;
            this.dgv_TestTypes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TestTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TestTypes.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_TestTypes.Location = new System.Drawing.Point(12, 180);
            this.dgv_TestTypes.Name = "dgv_TestTypes";
            this.dgv_TestTypes.ReadOnly = true;
            this.dgv_TestTypes.Size = new System.Drawing.Size(733, 400);
            this.dgv_TestTypes.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 42);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(110, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // lb_Model
            // 
            this.lb_Model.AutoSize = true;
            this.lb_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Model.Location = new System.Drawing.Point(281, 148);
            this.lb_Model.Name = "lb_Model";
            this.lb_Model.Size = new System.Drawing.Size(227, 29);
            this.lb_Model.TabIndex = 7;
            this.lb_Model.Text = "Manage Test Tyeps";
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.Location = new System.Drawing.Point(626, 592);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(119, 35);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageTestTyeps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 639);
            this.Controls.Add(this.lb_records);
            this.Controls.Add(this.lb_rrmodel);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_TestTypes);
            this.Controls.Add(this.lb_Model);
            this.Name = "frmManageTestTyeps";
            this.Text = "frmManageTestTyeps";
            this.Load += new System.EventHandler(this.frmManageTestTyeps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TestTypes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_records;
        private System.Windows.Forms.Label lb_rrmodel;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv_TestTypes;
        private System.Windows.Forms.Label lb_Model;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}