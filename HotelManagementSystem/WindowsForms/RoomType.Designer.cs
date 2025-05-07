namespace HotelManagementSystem
{
    partial class RoomType
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.Button btn_rt_save;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomType));
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btn_rt_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_serch = new System.Windows.Forms.TextBox();
            this.btn_Serch = new System.Windows.Forms.Button();
            this.btn_rt_clear = new System.Windows.Forms.Button();
            this.btn_rt_search = new System.Windows.Forms.Button();
            this.txtbox_rt_search = new System.Windows.Forms.TextBox();
            this.roomType_dataGrideView = new System.Windows.Forms.DataGridView();
            this.roomTypeBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_rt_logout = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_rt_refresh = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_rt_reportmaster = new System.Windows.Forms.Button();
            this.btn_rt_bookingmaster = new System.Windows.Forms.Button();
            this.btn_rt_roommaster = new System.Windows.Forms.Button();
            this.btn_rt_dashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.roomTypeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomTypeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomType_dataGrideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtRoomType.Location = new System.Drawing.Point(144, 23);
            this.txtRoomType.Multiline = true;
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(285, 40);
            this.txtRoomType.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(555, 23);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(285, 40);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtCapacity.Location = new System.Drawing.Point(144, 113);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(285, 40);
            this.txtCapacity.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(555, 117);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(285, 40);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // btn_rt_save
            // 
            this.btn_rt_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btn_rt_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rt_save.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_rt_save.FlatAppearance.BorderSize = 0;
            this.btn_rt_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rt_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_save.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.btn_rt_save.ForeColor = System.Drawing.Color.White;
            this.btn_rt_save.Location = new System.Drawing.Point(144, 174);
            this.btn_rt_save.Name = "btn_rt_save";
            this.btn_rt_save.Size = new System.Drawing.Size(137, 48);
            this.btn_rt_save.TabIndex = 4;
            this.btn_rt_save.Text = "Save";
            this.btn_rt_save.UseVisualStyleBackColor = false;
            this.btn_rt_save.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(453, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(26, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(469, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.txtbox_serch);
            this.panel1.Controls.Add(this.btn_Serch);
            this.panel1.Controls.Add(this.btn_rt_clear);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.btn_rt_search);
            this.panel1.Controls.Add(this.txtRoomType);
            this.panel1.Controls.Add(this.txtbox_rt_search);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCapacity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_rt_save);
            this.panel1.Location = new System.Drawing.Point(312, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 312);
            this.panel1.TabIndex = 0;
            // 
            // txtbox_serch
            // 
            this.txtbox_serch.Location = new System.Drawing.Point(144, 256);
            this.txtbox_serch.Multiline = true;
            this.txtbox_serch.Name = "txtbox_serch";
            this.txtbox_serch.Size = new System.Drawing.Size(258, 44);
            this.txtbox_serch.TabIndex = 8;
            // 
            // btn_Serch
            // 
            this.btn_Serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btn_Serch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Serch.ForeColor = System.Drawing.Color.White;
            this.btn_Serch.Location = new System.Drawing.Point(418, 256);
            this.btn_Serch.Name = "btn_Serch";
            this.btn_Serch.Size = new System.Drawing.Size(110, 44);
            this.btn_Serch.TabIndex = 7;
            this.btn_Serch.Text = "Search";
            this.btn_Serch.UseVisualStyleBackColor = false;
            this.btn_Serch.Click += new System.EventHandler(this.btn_Serch_Click);
            // 
            // btn_rt_clear
            // 
            this.btn_rt_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btn_rt_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rt_clear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_rt_clear.FlatAppearance.BorderSize = 0;
            this.btn_rt_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_clear.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.btn_rt_clear.ForeColor = System.Drawing.Color.White;
            this.btn_rt_clear.Location = new System.Drawing.Point(703, 183);
            this.btn_rt_clear.Name = "btn_rt_clear";
            this.btn_rt_clear.Size = new System.Drawing.Size(137, 48);
            this.btn_rt_clear.TabIndex = 6;
            this.btn_rt_clear.Text = "Clear";
            this.btn_rt_clear.UseVisualStyleBackColor = false;
            this.btn_rt_clear.Click += new System.EventHandler(this.btn_rt_clear_Click);
            // 
            // btn_rt_search
            // 
            this.btn_rt_search.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rt_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rt_search.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_rt_search.FlatAppearance.BorderSize = 0;
            this.btn_rt_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rt_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_search.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btn_rt_search.ForeColor = System.Drawing.Color.White;
            this.btn_rt_search.Location = new System.Drawing.Point(18, 594);
            this.btn_rt_search.Name = "btn_rt_search";
            this.btn_rt_search.Size = new System.Drawing.Size(124, 48);
            this.btn_rt_search.TabIndex = 6;
            this.btn_rt_search.Text = "Search";
            this.btn_rt_search.UseVisualStyleBackColor = false;
            this.btn_rt_search.Click += new System.EventHandler(this.btn_rt_search_Click);
            // 
            // txtbox_rt_search
            // 
            this.txtbox_rt_search.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.txtbox_rt_search.Location = new System.Drawing.Point(18, 543);
            this.txtbox_rt_search.Multiline = true;
            this.txtbox_rt_search.Name = "txtbox_rt_search";
            this.txtbox_rt_search.Size = new System.Drawing.Size(227, 34);
            this.txtbox_rt_search.TabIndex = 6;
            // 
            // roomType_dataGrideView
            // 
            this.roomType_dataGrideView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roomType_dataGrideView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomType_dataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomType_dataGrideView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.roomType_dataGrideView.Location = new System.Drawing.Point(312, 397);
            this.roomType_dataGrideView.Name = "roomType_dataGrideView";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomType_dataGrideView.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.roomType_dataGrideView.RowHeadersVisible = false;
            this.roomType_dataGrideView.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomType_dataGrideView.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.roomType_dataGrideView.RowTemplate.Height = 24;
            this.roomType_dataGrideView.Size = new System.Drawing.Size(819, 247);
            this.roomType_dataGrideView.TabIndex = 5;
            this.roomType_dataGrideView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomType_dataGrideView_CellClick);
            // 
            // roomTypeBindingSource6
            // 
            this.roomTypeBindingSource6.DataMember = "RoomType";
            // 
            // roomTypeBindingSource5
            // 
            this.roomTypeBindingSource5.DataMember = "RoomType";
            // 
            // roomTypeBindingSource4
            // 
            this.roomTypeBindingSource4.DataMember = "RoomType";
            // 
            // roomTypeBindingSource1
            // 
            this.roomTypeBindingSource1.DataMember = "RoomType";
            // 
            // roomTypeBindingSource
            // 
            this.roomTypeBindingSource.DataMember = "RoomType";
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
            this.btn_rt_logout.Location = new System.Drawing.Point(0, 650);
            this.btn_rt_logout.Name = "btn_rt_logout";
            this.btn_rt_logout.Size = new System.Drawing.Size(248, 49);
            this.btn_rt_logout.TabIndex = 9;
            this.btn_rt_logout.Text = "Logout";
            this.btn_rt_logout.UseVisualStyleBackColor = false;
            this.btn_rt_logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_rt_refresh
            // 
            this.btn_rt_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.btn_rt_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rt_refresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_rt_refresh.FlatAppearance.BorderSize = 0;
            this.btn_rt_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_rt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rt_refresh.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.btn_rt_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_rt_refresh.Location = new System.Drawing.Point(1137, 397);
            this.btn_rt_refresh.Name = "btn_rt_refresh";
            this.btn_rt_refresh.Size = new System.Drawing.Size(147, 48);
            this.btn_rt_refresh.TabIndex = 10;
            this.btn_rt_refresh.Text = "Refresh";
            this.btn_rt_refresh.UseVisualStyleBackColor = false;
            this.btn_rt_refresh.Click += new System.EventHandler(this.btn_rt_refresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_rt_reportmaster);
            this.panel2.Controls.Add(this.btn_rt_bookingmaster);
            this.panel2.Controls.Add(this.btn_rt_roommaster);
            this.panel2.Controls.Add(this.btn_rt_dashboard);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.btn_rt_logout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 699);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(233, 155);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(548, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(419, 36);
            this.label6.TabIndex = 35;
            this.label6.Text = "Welcome To Room Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(307, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(543, 25);
            this.label7.TabIndex = 36;
            this.label7.Text = "All The RoomTypes Are Dislyed In Detail Here..";
            // 
            // btn_rt_reportmaster
            // 
            this.btn_rt_reportmaster.BackColor = System.Drawing.Color.Transparent;
            this.btn_rt_reportmaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_reportmaster.ForeColor = System.Drawing.Color.White;
            this.btn_rt_reportmaster.Location = new System.Drawing.Point(14, 440);
            this.btn_rt_reportmaster.Name = "btn_rt_reportmaster";
            this.btn_rt_reportmaster.Size = new System.Drawing.Size(235, 43);
            this.btn_rt_reportmaster.TabIndex = 37;
            this.btn_rt_reportmaster.Text = "Report Master";
            this.btn_rt_reportmaster.UseVisualStyleBackColor = false;
            this.btn_rt_reportmaster.Click += new System.EventHandler(this.btn_rt_reportmaster_Click_2);
            // 
            // btn_rt_bookingmaster
            // 
            this.btn_rt_bookingmaster.BackColor = System.Drawing.Color.Transparent;
            this.btn_rt_bookingmaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_bookingmaster.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold);
            this.btn_rt_bookingmaster.ForeColor = System.Drawing.Color.White;
            this.btn_rt_bookingmaster.Location = new System.Drawing.Point(14, 363);
            this.btn_rt_bookingmaster.Name = "btn_rt_bookingmaster";
            this.btn_rt_bookingmaster.Size = new System.Drawing.Size(235, 43);
            this.btn_rt_bookingmaster.TabIndex = 36;
            this.btn_rt_bookingmaster.Text = "Booking Master";
            this.btn_rt_bookingmaster.UseVisualStyleBackColor = false;
            this.btn_rt_bookingmaster.Click += new System.EventHandler(this.btn_rt_bookingmaster_Click);
            // 
            // btn_rt_roommaster
            // 
            this.btn_rt_roommaster.BackColor = System.Drawing.Color.Transparent;
            this.btn_rt_roommaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_roommaster.ForeColor = System.Drawing.Color.White;
            this.btn_rt_roommaster.Location = new System.Drawing.Point(14, 295);
            this.btn_rt_roommaster.Name = "btn_rt_roommaster";
            this.btn_rt_roommaster.Size = new System.Drawing.Size(233, 43);
            this.btn_rt_roommaster.TabIndex = 35;
            this.btn_rt_roommaster.Text = "Room Master";
            this.btn_rt_roommaster.UseVisualStyleBackColor = false;
            this.btn_rt_roommaster.Click += new System.EventHandler(this.btn_rt_roommaster_Click);
            // 
            // btn_rt_dashboard
            // 
            this.btn_rt_dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_rt_dashboard.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_rt_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rt_dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_rt_dashboard.Location = new System.Drawing.Point(14, 215);
            this.btn_rt_dashboard.Name = "btn_rt_dashboard";
            this.btn_rt_dashboard.Size = new System.Drawing.Size(233, 43);
            this.btn_rt_dashboard.TabIndex = 34;
            this.btn_rt_dashboard.Text = "Dashboard";
            this.btn_rt_dashboard.UseVisualStyleBackColor = false;
            this.btn_rt_dashboard.Click += new System.EventHandler(this.btn_rt_dashboard_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(248, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1074, 49);
            this.panel3.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 511);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 43);
            this.button1.TabIndex = 38;
            this.button1.Text = "Admin Pannel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // roomTypeBindingSource2
            // 
            this.roomTypeBindingSource2.DataSource = typeof(HotelManagementSystem.RoomType);
            // 
            // roomTypeBindingSource3
            // 
            this.roomTypeBindingSource3.DataSource = typeof(HotelManagementSystem.RoomType);
            // 
            // RoomType
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(218)))), ((int)(((byte)(239)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1322, 699);
            this.Controls.Add(this.roomType_dataGrideView);
            this.Controls.Add(this.btn_rt_refresh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RoomType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomType";
            this.Load += new System.EventHandler(this.HotelManagementSystem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomType_dataGrideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomTypeBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView roomType_dataGrideView;
        private System.Windows.Forms.Button btn_rt_logout;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
       // private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource roomTypeBindingSource;
       // private DataSet2TableAdapters.RoomTypeTableAdapter roomTypeTableAdapter;
        private System.Windows.Forms.Button btn_rt_refresh;
        private System.Windows.Forms.TextBox txtbox_rt_search;
        private System.Windows.Forms.Button btn_rt_search;
        private System.Windows.Forms.Button btn_rt_clear;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.BindingSource roomTypeBindingSource1;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomTypeBindingSource4;
        private System.Windows.Forms.BindingSource roomTypeBindingSource2;
        private System.Windows.Forms.BindingSource roomTypeBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource roomTypeBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Serch;
        private System.Windows.Forms.TextBox txtbox_serch;
        private System.Windows.Forms.BindingSource roomTypeBindingSource6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.Button btn_rt_reportmaster;
        private System.Windows.Forms.Button btn_rt_bookingmaster;
        private System.Windows.Forms.Button btn_rt_roommaster;
        private System.Windows.Forms.Button btn_rt_dashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}
