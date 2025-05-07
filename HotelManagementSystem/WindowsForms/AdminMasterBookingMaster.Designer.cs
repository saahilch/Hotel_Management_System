namespace HotelManagementSystem.WindowsForms
{
    partial class AdminMasterBookingMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMasterBookingMaster));
            this.dgvBookingMaster = new System.Windows.Forms.DataGridView();
            this.btnLoadUnderMaintenanceRooms = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_roommaster = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_rm_reportmaster = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rm_bookingmaster = new System.Windows.Forms.Button();
            this.btn_rt_logout = new System.Windows.Forms.Button();
            this.btn_rm_dashboard = new System.Windows.Forms.Button();
            this.btn_rm_roomtype = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingMaster)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookingMaster
            // 
            this.dgvBookingMaster.AllowUserToAddRows = false;
            this.dgvBookingMaster.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookingMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingMaster.Location = new System.Drawing.Point(252, 215);
            this.dgvBookingMaster.Name = "dgvBookingMaster";
            this.dgvBookingMaster.RowHeadersVisible = false;
            this.dgvBookingMaster.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBookingMaster.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookingMaster.RowTemplate.Height = 24;
            this.dgvBookingMaster.Size = new System.Drawing.Size(1098, 476);
            this.dgvBookingMaster.TabIndex = 4;
            this.dgvBookingMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLoadUnderMaintenanceRooms
            // 
            this.btnLoadUnderMaintenanceRooms.BackColor = System.Drawing.Color.DarkGreen;
            this.btnLoadUnderMaintenanceRooms.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLoadUnderMaintenanceRooms.ForeColor = System.Drawing.Color.White;
            this.btnLoadUnderMaintenanceRooms.Location = new System.Drawing.Point(252, 134);
            this.btnLoadUnderMaintenanceRooms.Name = "btnLoadUnderMaintenanceRooms";
            this.btnLoadUnderMaintenanceRooms.Size = new System.Drawing.Size(184, 41);
            this.btnLoadUnderMaintenanceRooms.TabIndex = 5;
            this.btnLoadUnderMaintenanceRooms.Text = "Lode Tabel";
            this.btnLoadUnderMaintenanceRooms.UseVisualStyleBackColor = false;
            this.btnLoadUnderMaintenanceRooms.Click += new System.EventHandler(this.btnLoadUnderMaintenanceRooms_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Controls.Add(this.btn_roommaster);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_rm_reportmaster);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.btn_rm_bookingmaster);
            this.panel3.Controls.Add(this.btn_rt_logout);
            this.panel3.Controls.Add(this.btn_rm_dashboard);
            this.panel3.Controls.Add(this.btn_rm_roomtype);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 703);
            this.panel3.TabIndex = 29;
            // 
            // btn_roommaster
            // 
            this.btn_roommaster.BackColor = System.Drawing.Color.Transparent;
            this.btn_roommaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_roommaster.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_roommaster.ForeColor = System.Drawing.Color.White;
            this.btn_roommaster.Location = new System.Drawing.Point(7, 345);
            this.btn_roommaster.Name = "btn_roommaster";
            this.btn_roommaster.Size = new System.Drawing.Size(231, 43);
            this.btn_roommaster.TabIndex = 15;
            this.btn_roommaster.Text = "Room Master";
            this.btn_roommaster.UseVisualStyleBackColor = false;
            this.btn_roommaster.Click += new System.EventHandler(this.btn_roommaster_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Admin Pannel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_rm_reportmaster
            // 
            this.btn_rm_reportmaster.BackColor = System.Drawing.Color.Transparent;
            this.btn_rm_reportmaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rm_reportmaster.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_rm_reportmaster.ForeColor = System.Drawing.Color.White;
            this.btn_rm_reportmaster.Location = new System.Drawing.Point(7, 483);
            this.btn_rm_reportmaster.Name = "btn_rm_reportmaster";
            this.btn_rm_reportmaster.Size = new System.Drawing.Size(231, 43);
            this.btn_rm_reportmaster.TabIndex = 4;
            this.btn_rm_reportmaster.Text = "Report Master";
            this.btn_rm_reportmaster.UseVisualStyleBackColor = false;
            this.btn_rm_reportmaster.Click += new System.EventHandler(this.btn_rm_reportmaster_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_rm_bookingmaster
            // 
            this.btn_rm_bookingmaster.BackColor = System.Drawing.Color.Transparent;
            this.btn_rm_bookingmaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rm_bookingmaster.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_rm_bookingmaster.ForeColor = System.Drawing.Color.White;
            this.btn_rm_bookingmaster.Location = new System.Drawing.Point(7, 416);
            this.btn_rm_bookingmaster.Name = "btn_rm_bookingmaster";
            this.btn_rm_bookingmaster.Size = new System.Drawing.Size(231, 43);
            this.btn_rm_bookingmaster.TabIndex = 3;
            this.btn_rm_bookingmaster.Text = "Booking Master";
            this.btn_rm_bookingmaster.UseVisualStyleBackColor = false;
            this.btn_rm_bookingmaster.Click += new System.EventHandler(this.btn_rm_bookingmaster_Click);
            // 
            // btn_rt_logout
            // 
            this.btn_rt_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_rt_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_rt_logout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_rt_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_rt_logout.FlatAppearance.BorderSize = 0;
            this.btn_rt_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rt_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_logout.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold);
            this.btn_rt_logout.ForeColor = System.Drawing.Color.White;
            this.btn_rt_logout.Location = new System.Drawing.Point(0, 654);
            this.btn_rt_logout.Name = "btn_rt_logout";
            this.btn_rt_logout.Size = new System.Drawing.Size(246, 49);
            this.btn_rt_logout.TabIndex = 13;
            this.btn_rt_logout.Text = "Logout";
            this.btn_rt_logout.UseVisualStyleBackColor = false;
            this.btn_rt_logout.Click += new System.EventHandler(this.btn_rt_logout_Click);
            // 
            // btn_rm_dashboard
            // 
            this.btn_rm_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_rm_dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_rm_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rm_dashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_rm_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_rm_dashboard.Location = new System.Drawing.Point(7, 216);
            this.btn_rm_dashboard.Name = "btn_rm_dashboard";
            this.btn_rm_dashboard.Size = new System.Drawing.Size(231, 43);
            this.btn_rm_dashboard.TabIndex = 0;
            this.btn_rm_dashboard.Text = "Dashboard";
            this.btn_rm_dashboard.UseVisualStyleBackColor = false;
            this.btn_rm_dashboard.Click += new System.EventHandler(this.btn_rm_dashboard_Click);
            // 
            // btn_rm_roomtype
            // 
            this.btn_rm_roomtype.BackColor = System.Drawing.Color.Transparent;
            this.btn_rm_roomtype.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rm_roomtype.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_rm_roomtype.ForeColor = System.Drawing.Color.White;
            this.btn_rm_roomtype.Location = new System.Drawing.Point(7, 280);
            this.btn_rm_roomtype.Name = "btn_rm_roomtype";
            this.btn_rm_roomtype.Size = new System.Drawing.Size(231, 43);
            this.btn_rm_roomtype.TabIndex = 1;
            this.btn_rm_roomtype.Text = "Room Type";
            this.btn_rm_roomtype.UseVisualStyleBackColor = false;
            this.btn_rm_roomtype.Click += new System.EventHandler(this.btn_rm_roomtype_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(252, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1089, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "All The Booked Rooms Are Displayed Bellow In The Tabel ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(246, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(760, 34);
            this.label2.TabIndex = 30;
            this.label2.Text = "**Click On CheckOut Buttn To Check Out The Guest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(59, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(891, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "Welcome To Admin Pannel Of Booking Master Form ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(246, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 88);
            this.panel1.TabIndex = 32;
            // 
            // AdminMasterBookingMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1362, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLoadUnderMaintenanceRooms);
            this.Controls.Add(this.dgvBookingMaster);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminMasterBookingMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMasterBookingMaster";
            this.Load += new System.EventHandler(this.AdminMasterBookingMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingMaster)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBookingMaster;
        private System.Windows.Forms.Button btnLoadUnderMaintenanceRooms;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_rm_reportmaster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_rm_bookingmaster;
        private System.Windows.Forms.Button btn_rt_logout;
        private System.Windows.Forms.Button btn_rm_dashboard;
        private System.Windows.Forms.Button btn_rm_roomtype;
        private System.Windows.Forms.Button btn_roommaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}