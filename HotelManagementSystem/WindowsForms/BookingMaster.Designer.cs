using System.Threading;

namespace HotelManagementSystem
{
    partial class BookingMaster
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtbox_firstName = new System.Windows.Forms.TextBox();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_bm_refresh = new System.Windows.Forms.Button();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.btn_serch = new System.Windows.Forms.Button();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            this.comboBox_roomNumber = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.textBox_document = new System.Windows.Forms.TextBox();
            this.btn_saveClk = new System.Windows.Forms.Button();
            this.btn_bm_save = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbox_lastName = new System.Windows.Forms.TextBox();
            this.mobileNo = new System.Windows.Forms.Label();
            this.textbox_amobileNo = new System.Windows.Forms.TextBox();
            this.govDocument = new System.Windows.Forms.Label();
            this.roomType = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.roomNumber = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.roomMasterDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomMasterDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewBookings = new System.Windows.Forms.DataGridView();
            this.bookingMasterBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelManagementDataSet1 = new HotelManagementSystem.DataBaseXSD.HotelManagementDataSet1();
            this.bookingMasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.roomMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingMasterTableAdapter = new HotelManagementSystem.DataBaseXSD.HotelManagementDataSet1TableAdapters.BookingMasterTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.logutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingMasterBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.bookingMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GuestFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuestMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomMasterDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomMasterDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomMasterBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_firstName
            // 
            this.txtbox_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbox_firstName.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtbox_firstName.Location = new System.Drawing.Point(165, 42);
            this.txtbox_firstName.Multiline = true;
            this.txtbox_firstName.Name = "txtbox_firstName";
            this.txtbox_firstName.Size = new System.Drawing.Size(196, 35);
            this.txtbox_firstName.TabIndex = 0;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_roomType.Font = new System.Drawing.Font("Verdana", 12F);
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Location = new System.Drawing.Point(531, 167);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(196, 33);
            this.comboBox_roomType.TabIndex = 8;
            this.comboBox_roomType.SelectedIndexChanged += new System.EventHandler(this.comboBox_roomType_SelectedIndexChanged);
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_gender.Font = new System.Drawing.Font("Verdana", 12F);
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(947, 46);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(196, 33);
            this.comboBox_gender.TabIndex = 2;
            this.comboBox_gender.SelectedIndexChanged += new System.EventHandler(this.comboBox_gender_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_bm_refresh);
            this.panel1.Controls.Add(this.txtCapacity);
            this.panel1.Controls.Add(this.btn_serch);
            this.panel1.Controls.Add(this.txtbox_search);
            this.panel1.Controls.Add(this.comboBox_roomNumber);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.textBox_document);
            this.panel1.Controls.Add(this.btn_saveClk);
            this.panel1.Controls.Add(this.btn_bm_save);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtbox_lastName);
            this.panel1.Controls.Add(this.mobileNo);
            this.panel1.Controls.Add(this.textbox_amobileNo);
            this.panel1.Controls.Add(this.govDocument);
            this.panel1.Controls.Add(this.txtbox_firstName);
            this.panel1.Controls.Add(this.roomType);
            this.panel1.Controls.Add(this.lastName);
            this.panel1.Controls.Add(this.comboBox_roomType);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.comboBox_gender);
            this.panel1.Controls.Add(this.roomNumber);
            this.panel1.Controls.Add(this.gender);
            this.panel1.Controls.Add(this.txtbox_email);
            this.panel1.Location = new System.Drawing.Point(10, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 355);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Thistle;
            this.label3.Location = new System.Drawing.Point(373, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 36);
            this.label3.TabIndex = 40;
            this.label3.Text = "Welcome To Booking Master";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Guest Count";
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Clear.FlatAppearance.BorderSize = 0;
            this.btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Clear.ForeColor = System.Drawing.Color.Black;
            this.btn_Clear.Location = new System.Drawing.Point(776, 226);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(136, 43);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_bm_refresh
            // 
            this.btn_bm_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_bm_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bm_refresh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_bm_refresh.FlatAppearance.BorderSize = 0;
            this.btn_bm_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_bm_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bm_refresh.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bm_refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_bm_refresh.Location = new System.Drawing.Point(1013, 226);
            this.btn_bm_refresh.Name = "btn_bm_refresh";
            this.btn_bm_refresh.Size = new System.Drawing.Size(135, 43);
            this.btn_bm_refresh.TabIndex = 15;
            this.btn_bm_refresh.Text = "Refresh";
            this.btn_bm_refresh.UseVisualStyleBackColor = false;
            this.btn_bm_refresh.Click += new System.EventHandler(this.btn_bm_refresh_Click);
            // 
            // txtCapacity
            // 
            this.txtCapacity.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtCapacity.Location = new System.Drawing.Point(165, 158);
            this.txtCapacity.Multiline = true;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(196, 35);
            this.txtCapacity.TabIndex = 37;
            // 
            // btn_serch
            // 
            this.btn_serch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_serch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_serch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_serch.FlatAppearance.BorderSize = 0;
            this.btn_serch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_serch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_serch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btn_serch.ForeColor = System.Drawing.Color.Black;
            this.btn_serch.Location = new System.Drawing.Point(327, 289);
            this.btn_serch.Name = "btn_serch";
            this.btn_serch.Size = new System.Drawing.Size(134, 43);
            this.btn_serch.TabIndex = 13;
            this.btn_serch.Text = "Search";
            this.btn_serch.UseVisualStyleBackColor = false;
            this.btn_serch.Click += new System.EventHandler(this.btn_serch_Click);
            // 
            // txtbox_search
            // 
            this.txtbox_search.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtbox_search.Location = new System.Drawing.Point(13, 293);
            this.txtbox_search.Multiline = true;
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(275, 37);
            this.txtbox_search.TabIndex = 12;
            // 
            // comboBox_roomNumber
            // 
            this.comboBox_roomNumber.Font = new System.Drawing.Font("Verdana", 12F);
            this.comboBox_roomNumber.FormattingEnabled = true;
            this.comboBox_roomNumber.Location = new System.Drawing.Point(951, 170);
            this.comboBox_roomNumber.Name = "comboBox_roomNumber";
            this.comboBox_roomNumber.Size = new System.Drawing.Size(196, 33);
            this.comboBox_roomNumber.TabIndex = 36;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Location = new System.Drawing.Point(225, 226);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(135, 43);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // textBox_document
            // 
            this.textBox_document.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_document.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox_document.Location = new System.Drawing.Point(951, 99);
            this.textBox_document.Multiline = true;
            this.textBox_document.Name = "textBox_document";
            this.textBox_document.Size = new System.Drawing.Size(196, 35);
            this.textBox_document.TabIndex = 5;
            // 
            // btn_saveClk
            // 
            this.btn_saveClk.BackColor = System.Drawing.Color.Red;
            this.btn_saveClk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveClk.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_saveClk.FlatAppearance.BorderSize = 0;
            this.btn_saveClk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_saveClk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saveClk.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btn_saveClk.ForeColor = System.Drawing.Color.Black;
            this.btn_saveClk.Location = new System.Drawing.Point(1158, 93);
            this.btn_saveClk.Name = "btn_saveClk";
            this.btn_saveClk.Size = new System.Drawing.Size(106, 37);
            this.btn_saveClk.TabIndex = 6;
            this.btn_saveClk.Text = "Select ";
            this.btn_saveClk.UseVisualStyleBackColor = false;
            this.btn_saveClk.Click += new System.EventHandler(this.btn_saveClk_Click);
            // 
            // btn_bm_save
            // 
            this.btn_bm_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_bm_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_bm_save.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_bm_save.FlatAppearance.BorderSize = 0;
            this.btn_bm_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_bm_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_bm_save.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bm_save.ForeColor = System.Drawing.Color.Black;
            this.btn_bm_save.Location = new System.Drawing.Point(13, 226);
            this.btn_bm_save.Name = "btn_bm_save";
            this.btn_bm_save.Size = new System.Drawing.Size(135, 43);
            this.btn_bm_save.TabIndex = 10;
            this.btn_bm_save.Text = "Check In";
            this.btn_bm_save.UseVisualStyleBackColor = false;
            this.btn_bm_save.Click += new System.EventHandler(this.btn_bm_save_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(2, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 35;
            this.label10.Text = "First Name";
            // 
            // txtbox_lastName
            // 
            this.txtbox_lastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbox_lastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_lastName.Location = new System.Drawing.Point(531, 42);
            this.txtbox_lastName.Multiline = true;
            this.txtbox_lastName.Name = "txtbox_lastName";
            this.txtbox_lastName.Size = new System.Drawing.Size(196, 35);
            this.txtbox_lastName.TabIndex = 1;
            // 
            // mobileNo
            // 
            this.mobileNo.AutoSize = true;
            this.mobileNo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.mobileNo.ForeColor = System.Drawing.Color.Gold;
            this.mobileNo.Location = new System.Drawing.Point(7, 107);
            this.mobileNo.Name = "mobileNo";
            this.mobileNo.Size = new System.Drawing.Size(124, 25);
            this.mobileNo.TabIndex = 28;
            this.mobileNo.Text = "Mobile No";
            // 
            // textbox_amobileNo
            // 
            this.textbox_amobileNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textbox_amobileNo.Font = new System.Drawing.Font("Verdana", 12F);
            this.textbox_amobileNo.Location = new System.Drawing.Point(165, 102);
            this.textbox_amobileNo.Multiline = true;
            this.textbox_amobileNo.Name = "textbox_amobileNo";
            this.textbox_amobileNo.Size = new System.Drawing.Size(196, 35);
            this.textbox_amobileNo.TabIndex = 3;
            this.textbox_amobileNo.TextChanged += new System.EventHandler(this.textbox_mobileNo_TextChanged);
            // 
            // govDocument
            // 
            this.govDocument.AutoSize = true;
            this.govDocument.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.govDocument.ForeColor = System.Drawing.Color.Gold;
            this.govDocument.Location = new System.Drawing.Point(758, 109);
            this.govDocument.Name = "govDocument";
            this.govDocument.Size = new System.Drawing.Size(176, 25);
            this.govDocument.TabIndex = 31;
            this.govDocument.Text = "Gov.Document";
            // 
            // roomType
            // 
            this.roomType.AutoSize = true;
            this.roomType.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.roomType.ForeColor = System.Drawing.Color.Gold;
            this.roomType.Location = new System.Drawing.Point(374, 170);
            this.roomType.Name = "roomType";
            this.roomType.Size = new System.Drawing.Size(138, 25);
            this.roomType.TabIndex = 33;
            this.roomType.Text = "Room Type";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lastName.ForeColor = System.Drawing.Color.Gold;
            this.lastName.Location = new System.Drawing.Point(389, 54);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(130, 25);
            this.lastName.TabIndex = 27;
            this.lastName.Text = "Last Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.Gold;
            this.email.Location = new System.Drawing.Point(418, 107);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(74, 25);
            this.email.TabIndex = 30;
            this.email.Text = "Email";
            // 
            // roomNumber
            // 
            this.roomNumber.AutoSize = true;
            this.roomNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.roomNumber.ForeColor = System.Drawing.Color.Gold;
            this.roomNumber.Location = new System.Drawing.Point(771, 170);
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.Size = new System.Drawing.Size(115, 25);
            this.roomNumber.TabIndex = 34;
            this.roomNumber.Text = "Room No";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.gender.ForeColor = System.Drawing.Color.Gold;
            this.gender.Location = new System.Drawing.Point(794, 52);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(92, 25);
            this.gender.TabIndex = 29;
            this.gender.Text = "Gender";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbox_email.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtbox_email.Location = new System.Drawing.Point(531, 98);
            this.txtbox_email.Multiline = true;
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(196, 35);
            this.txtbox_email.TabIndex = 4;
            // 
            // dataGridViewBookings
            // 
            this.dataGridViewBookings.AllowUserToAddRows = false;
            this.dataGridViewBookings.AutoGenerateColumns = false;
            this.dataGridViewBookings.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestFirstName,
            this.GuestLastName,
            this.GuestMobileNo,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn3,
            this.statusDataGridViewTextBoxColumn,
            this.bookingDateDataGridViewTextBoxColumn,
            this.checkoutDateDataGridViewTextBoxColumn});
            this.dataGridViewBookings.DataSource = this.bookingMasterBindingSource2;
            this.dataGridViewBookings.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridViewBookings.Location = new System.Drawing.Point(8, 34);
            this.dataGridViewBookings.Name = "dataGridViewBookings";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBookings.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewBookings.RowHeadersVisible = false;
            this.dataGridViewBookings.RowHeadersWidth = 51;
            this.dataGridViewBookings.RowTemplate.Height = 24;
            this.dataGridViewBookings.Size = new System.Drawing.Size(1279, 232);
            this.dataGridViewBookings.TabIndex = 27;
            this.dataGridViewBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBookings_CellContentClick);
            // 
            // bookingMasterBindingSource2
            // 
            this.bookingMasterBindingSource2.DataMember = "BookingMaster";
            this.bookingMasterBindingSource2.DataSource = this.hotelManagementDataSet1;
            // 
            // hotelManagementDataSet1
            // 
            this.hotelManagementDataSet1.DataSetName = "HotelManagementDataSet1";
            this.hotelManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingMasterBindingSource1
            // 
            this.bookingMasterBindingSource1.DataMember = "BookingMaster";
            // 
            // roomMasterBindingSource
            // 
            this.roomMasterBindingSource.DataMember = "RoomMaster";
            // 
            // bookingMasterTableAdapter
            // 
            this.bookingMasterTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(198)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.roomTypeToolStripMenuItem,
            this.roomMasterToolStripMenuItem,
            this.reportMasterToolStripMenuItem,
            this.logutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1322, 37);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(163, 33);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click_1);
            // 
            // roomTypeToolStripMenuItem
            // 
            this.roomTypeToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.roomTypeToolStripMenuItem.Name = "roomTypeToolStripMenuItem";
            this.roomTypeToolStripMenuItem.Size = new System.Drawing.Size(174, 33);
            this.roomTypeToolStripMenuItem.Text = "Room Type";
            this.roomTypeToolStripMenuItem.Click += new System.EventHandler(this.roomTypeToolStripMenuItem_Click_1);
            // 
            // roomMasterToolStripMenuItem
            // 
            this.roomMasterToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.roomMasterToolStripMenuItem.Name = "roomMasterToolStripMenuItem";
            this.roomMasterToolStripMenuItem.Size = new System.Drawing.Size(197, 33);
            this.roomMasterToolStripMenuItem.Text = "Room Master";
            this.roomMasterToolStripMenuItem.Click += new System.EventHandler(this.roomMasterToolStripMenuItem_Click_1);
            // 
            // reportMasterToolStripMenuItem
            // 
            this.reportMasterToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.reportMasterToolStripMenuItem.Name = "reportMasterToolStripMenuItem";
            this.reportMasterToolStripMenuItem.Size = new System.Drawing.Size(210, 33);
            this.reportMasterToolStripMenuItem.Text = "Report Master";
            this.reportMasterToolStripMenuItem.Click += new System.EventHandler(this.reportMasterToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridViewBookings);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.panel2.Location = new System.Drawing.Point(10, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 269);
            this.panel2.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(627, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "All The Guest Booking Details Are Displayed Over Here";
            // 
            // logutToolStripMenuItem
            // 
            this.logutToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Bold);
            this.logutToolStripMenuItem.Name = "logutToolStripMenuItem";
            this.logutToolStripMenuItem.Size = new System.Drawing.Size(116, 33);
            this.logutToolStripMenuItem.Text = "Logout";
            this.logutToolStripMenuItem.Click += new System.EventHandler(this.logutToolStripMenuItem_Click);
            // 
            // bookingMasterBindingSource6
            // 
            this.bookingMasterBindingSource6.DataSource = typeof(HotelManagementSystem.BookingMaster);
            // 
            // bookingMasterBindingSource
            // 
            this.bookingMasterBindingSource.DataSource = typeof(HotelManagementSystem.BookingMaster);
            // 
            // GuestFirstName
            // 
            this.GuestFirstName.DataPropertyName = "GuestFirstName";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.GuestFirstName.DefaultCellStyle = dataGridViewCellStyle2;
            this.GuestFirstName.HeaderText = "First Name";
            this.GuestFirstName.MinimumWidth = 6;
            this.GuestFirstName.Name = "GuestFirstName";
            this.GuestFirstName.ReadOnly = true;
            this.GuestFirstName.Width = 125;
            // 
            // GuestLastName
            // 
            this.GuestLastName.DataPropertyName = "GuestLastName";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestLastName.DefaultCellStyle = dataGridViewCellStyle3;
            this.GuestLastName.HeaderText = "Last Name";
            this.GuestLastName.MinimumWidth = 6;
            this.GuestLastName.Name = "GuestLastName";
            this.GuestLastName.ReadOnly = true;
            this.GuestLastName.Width = 125;
            // 
            // GuestMobileNo
            // 
            this.GuestMobileNo.DataPropertyName = "GuestMobileNo";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.GuestMobileNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.GuestMobileNo.HeaderText = "Mobile No";
            this.GuestMobileNo.MinimumWidth = 6;
            this.GuestMobileNo.Name = "GuestMobileNo";
            this.GuestMobileNo.ReadOnly = true;
            this.GuestMobileNo.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Gender";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn2.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RoomNumber";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn5.HeaderText = "Allocated Room No";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoomType";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.HeaderText = "RoomType";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.statusDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingDateDataGridViewTextBoxColumn
            // 
            this.bookingDateDataGridViewTextBoxColumn.DataPropertyName = "BookingDate";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.bookingDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.bookingDateDataGridViewTextBoxColumn.HeaderText = "BookingDate";
            this.bookingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookingDateDataGridViewTextBoxColumn.Name = "bookingDateDataGridViewTextBoxColumn";
            this.bookingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkoutDateDataGridViewTextBoxColumn
            // 
            this.checkoutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckoutDate";
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.checkoutDateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.checkoutDateDataGridViewTextBoxColumn.HeaderText = "CheckoutDate";
            this.checkoutDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkoutDateDataGridViewTextBoxColumn.Name = "checkoutDateDataGridViewTextBoxColumn";
            this.checkoutDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // BookingMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(1322, 699);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookingMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BokingMaster";
            this.Load += new System.EventHandler(this.BookingMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomMasterDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomMasterDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomMasterBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_firstName;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label roomNumber;
        private System.Windows.Forms.Label roomType;
        private System.Windows.Forms.Label govDocument;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label mobileNo;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_lastName;
        private System.Windows.Forms.TextBox textbox_amobileNo;
        private System.Windows.Forms.Button btn_bm_save;
        private System.Windows.Forms.Button btn_saveClk;
        private System.Windows.Forms.TextBox textBox_document;
        private System.Windows.Forms.Button btn_bm_refresh;
        private System.Windows.Forms.BindingSource roomMasterDataTableBindingSource;
        private System.Windows.Forms.BindingSource roomMasterDataTableBindingSource1;
        private System.Windows.Forms.BindingSource bookingMasterBindingSource6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bookingMasterBindingSource;
        
        private System.Windows.Forms.BindingSource roomMasterBindingSource;
        //private HotelManagementDataSetTableAdapters.RoomMasterTableAdapter roomMasterTableAdapter;
        //private HotelManagementDataSet1 hotelManagementDataSet1;
        private System.Windows.Forms.BindingSource bookingMasterBindingSource1;
        //private HotelManagementDataSet1TableAdapters.BookingMasterTableAdapter bookingMasterTableAdapter;
        private System.Windows.Forms.Button btn_serch;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txtbox_search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.DataGridView dataGridViewBookings;
        private System.Windows.Forms.ComboBox comboBox_roomNumber;
        private DataBaseXSD.HotelManagementDataSet1 hotelManagementDataSet1;
        private System.Windows.Forms.BindingSource bookingMasterBindingSource2;
        private DataBaseXSD.HotelManagementDataSet1TableAdapters.BookingMasterTableAdapter bookingMasterTableAdapter;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMasterToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem logutToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateDataGridViewTextBoxColumn;
    }
}