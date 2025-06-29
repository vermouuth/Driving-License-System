namespace MyLicensesSystem.Manage.Applications.Manage.TestTyeps.TestForms
{
    partial class frmMainTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainTest));
            this.dgv_Appointments = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddAppointment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_CurrentAppointments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_Modling = new System.Windows.Forms.Label();
            this.Pic_TestPic = new System.Windows.Forms.PictureBox();
            this.ctlApplicationBasicInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalControls.ctlApplicationBasicInfo();
            this.ctlAppInfo1 = new MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalControls.ctlAppInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_TestPic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Appointments
            // 
            this.dgv_Appointments.AllowUserToAddRows = false;
            this.dgv_Appointments.AllowUserToDeleteRows = false;
            this.dgv_Appointments.AllowUserToOrderColumns = true;
            this.dgv_Appointments.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Appointments.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Appointments.Location = new System.Drawing.Point(17, 595);
            this.dgv_Appointments.Name = "dgv_Appointments";
            this.dgv_Appointments.ReadOnly = true;
            this.dgv_Appointments.Size = new System.Drawing.Size(765, 165);
            this.dgv_Appointments.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(213, 134);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.takeTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("takeTestToolStripMenuItem.Image")));
            this.takeTestToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(212, 54);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // btn_AddAppointment
            // 
            this.btn_AddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddAppointment.Image")));
            this.btn_AddAppointment.Location = new System.Drawing.Point(741, 552);
            this.btn_AddAppointment.Name = "btn_AddAppointment";
            this.btn_AddAppointment.Size = new System.Drawing.Size(40, 40);
            this.btn_AddAppointment.TabIndex = 3;
            this.btn_AddAppointment.UseVisualStyleBackColor = true;
            this.btn_AddAppointment.Click += new System.EventHandler(this.btn_AddAppointment_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Appointments:";
            // 
            // lb_CurrentAppointments
            // 
            this.lb_CurrentAppointments.AutoSize = true;
            this.lb_CurrentAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CurrentAppointments.Location = new System.Drawing.Point(87, 767);
            this.lb_CurrentAppointments.Name = "lb_CurrentAppointments";
            this.lb_CurrentAppointments.Size = new System.Drawing.Size(36, 13);
            this.lb_CurrentAppointments.TabIndex = 11;
            this.lb_CurrentAppointments.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 767);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "# Records";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::MyLicensesSystem.Properties.Resources.close;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(676, 766);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 12;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_Modling
            // 
            this.lb_Modling.AutoSize = true;
            this.lb_Modling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_Modling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lb_Modling.Location = new System.Drawing.Point(243, 142);
            this.lb_Modling.Name = "lb_Modling";
            this.lb_Modling.Size = new System.Drawing.Size(323, 31);
            this.lb_Modling.TabIndex = 13;
            this.lb_Modling.Text = "Vision Test  Appointmnt";
            this.lb_Modling.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pic_TestPic
            // 
            this.Pic_TestPic.Image = ((System.Drawing.Image)(resources.GetObject("Pic_TestPic.Image")));
            this.Pic_TestPic.Location = new System.Drawing.Point(280, 12);
            this.Pic_TestPic.Name = "Pic_TestPic";
            this.Pic_TestPic.Size = new System.Drawing.Size(254, 127);
            this.Pic_TestPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_TestPic.TabIndex = 14;
            this.Pic_TestPic.TabStop = false;
            // 
            // ctlApplicationBasicInfo1
            // 
            this.ctlApplicationBasicInfo1.Location = new System.Drawing.Point(10, 306);
            this.ctlApplicationBasicInfo1.Name = "ctlApplicationBasicInfo1";
            this.ctlApplicationBasicInfo1.Size = new System.Drawing.Size(772, 240);
            this.ctlApplicationBasicInfo1.TabIndex = 5;
            this.ctlApplicationBasicInfo1.OnViewClicked += new System.Action<int>(this.ctlApplicationBasicInfo1_OnViewClicked);
            // 
            // ctlAppInfo1
            // 
            this.ctlAppInfo1.Location = new System.Drawing.Point(5, 176);
            this.ctlAppInfo1.Name = "ctlAppInfo1";
            this.ctlAppInfo1.Size = new System.Drawing.Size(778, 134);
            this.ctlAppInfo1.TabIndex = 4;
            // 
            // frmMainTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 810);
            this.Controls.Add(this.Pic_TestPic);
            this.Controls.Add(this.lb_Modling);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_CurrentAppointments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlApplicationBasicInfo1);
            this.Controls.Add(this.ctlAppInfo1);
            this.Controls.Add(this.btn_AddAppointment);
            this.Controls.Add(this.dgv_Appointments);
            this.Name = "frmMainTest";
            this.Text = "frmMainTest";
            this.Load += new System.EventHandler(this.frmMainTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Appointments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_TestPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Appointments;
        private System.Windows.Forms.Button btn_AddAppointment;
        private Driving.Licens.Services.LocalControls.ctlAppInfo ctlAppInfo1;
        private Driving.Licens.Services.LocalControls.ctlApplicationBasicInfo ctlApplicationBasicInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_CurrentAppointments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_Modling;
        private System.Windows.Forms.PictureBox Pic_TestPic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}