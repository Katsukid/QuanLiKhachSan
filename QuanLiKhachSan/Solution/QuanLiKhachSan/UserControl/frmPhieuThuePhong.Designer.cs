namespace QuanLiKhachSan.UserControl
{
    partial class frmPhieuThuePhong
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThuePhong));
               this.dgvDanhSachPhieuThue = new System.Windows.Forms.DataGridView();
               this.colTenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colTenLoaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colLoaiKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
               this.colXoa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
               this.label6 = new System.Windows.Forms.Label();
               this.cmbLoaiKhachHang = new System.Windows.Forms.ComboBox();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.txtDiaChi = new System.Windows.Forms.TextBox();
               this.txtCMND = new System.Windows.Forms.TextBox();
               this.txtTenKhachHang = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.label8 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.txtMaPhong = new System.Windows.Forms.TextBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.txtLoaiPhong = new System.Windows.Forms.TextBox();
               this.dtpNgayTraPhong = new System.Windows.Forms.DateTimePicker();
               this.dtpNgayThuePhong = new System.Windows.Forms.DateTimePicker();
               this.label2 = new System.Windows.Forms.Label();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoaPhieuThue = new DevExpress.XtraEditors.SimpleButton();
               this.btnLuuPhieuThue = new DevExpress.XtraEditors.SimpleButton();
               this.btnThemPhieuThue = new DevExpress.XtraEditors.SimpleButton();
               this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
               this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
               this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
               this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).BeginInit();
               this.groupBox2.SuspendLayout();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
               this.SuspendLayout();
               // 
               // dgvDanhSachPhieuThue
               // 
               this.dgvDanhSachPhieuThue.AllowUserToAddRows = false;
               this.dgvDanhSachPhieuThue.BackgroundColor = System.Drawing.Color.White;
               this.dgvDanhSachPhieuThue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dgvDanhSachPhieuThue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenKhachHang,
            this.colTenLoaiKhach,
            this.colLoaiKhach,
            this.colCMND,
            this.colDiaChi,
            this.colXoa});
               this.dgvDanhSachPhieuThue.GridColor = System.Drawing.SystemColors.ButtonHighlight;
               this.dgvDanhSachPhieuThue.Location = new System.Drawing.Point(253, 400);
               this.dgvDanhSachPhieuThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.dgvDanhSachPhieuThue.Name = "dgvDanhSachPhieuThue";
               this.dgvDanhSachPhieuThue.Size = new System.Drawing.Size(981, 347);
               this.dgvDanhSachPhieuThue.TabIndex = 28;
               // 
               // colTenKhachHang
               // 
               this.colTenKhachHang.HeaderText = "Tên Khách Hàng";
               this.colTenKhachHang.Name = "colTenKhachHang";
               this.colTenKhachHang.Width = 200;
               // 
               // colTenLoaiKhach
               // 
               this.colTenLoaiKhach.HeaderText = "Tên Loại Khách";
               this.colTenLoaiKhach.Name = "colTenLoaiKhach";
               this.colTenLoaiKhach.Width = 125;
               // 
               // colLoaiKhach
               // 
               this.colLoaiKhach.HeaderText = "Loại Khách";
               this.colLoaiKhach.Name = "colLoaiKhach";
               this.colLoaiKhach.Width = 125;
               // 
               // colCMND
               // 
               this.colCMND.HeaderText = "CMND";
               this.colCMND.Name = "colCMND";
               this.colCMND.Width = 125;
               // 
               // colDiaChi
               // 
               this.colDiaChi.HeaderText = "Địa Chỉ";
               this.colDiaChi.Name = "colDiaChi";
               this.colDiaChi.Width = 200;
               // 
               // colXoa
               // 
               this.colXoa.HeaderText = "Xóa";
               this.colXoa.Name = "colXoa";
               this.colXoa.Width = 50;
               // 
               // label6
               // 
               this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(276, 12);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(677, 64);
               this.label6.TabIndex = 27;
               this.label6.Text = "PHIẾU THUÊ PHÒNG";
               this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // cmbLoaiKhachHang
               // 
               this.cmbLoaiKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cmbLoaiKhachHang.FormattingEnabled = true;
               this.cmbLoaiKhachHang.Location = new System.Drawing.Point(209, 95);
               this.cmbLoaiKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.cmbLoaiKhachHang.Name = "cmbLoaiKhachHang";
               this.cmbLoaiKhachHang.Size = new System.Drawing.Size(365, 32);
               this.cmbLoaiKhachHang.TabIndex = 14;
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.cmbLoaiKhachHang);
               this.groupBox2.Controls.Add(this.txtDiaChi);
               this.groupBox2.Controls.Add(this.txtCMND);
               this.groupBox2.Controls.Add(this.txtTenKhachHang);
               this.groupBox2.Controls.Add(this.label5);
               this.groupBox2.Controls.Add(this.label9);
               this.groupBox2.Controls.Add(this.label7);
               this.groupBox2.Controls.Add(this.label8);
               this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox2.Location = new System.Drawing.Point(654, 116);
               this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.groupBox2.Size = new System.Drawing.Size(580, 276);
               this.groupBox2.TabIndex = 26;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Thông tin khách thuê";
               // 
               // txtDiaChi
               // 
               this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtDiaChi.Location = new System.Drawing.Point(209, 190);
               this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.txtDiaChi.Name = "txtDiaChi";
               this.txtDiaChi.Size = new System.Drawing.Size(365, 32);
               this.txtDiaChi.TabIndex = 13;
               this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
               // 
               // txtCMND
               // 
               this.txtCMND.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtCMND.Location = new System.Drawing.Point(209, 140);
               this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.txtCMND.Name = "txtCMND";
               this.txtCMND.Size = new System.Drawing.Size(365, 32);
               this.txtCMND.TabIndex = 12;
               this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
               // 
               // txtTenKhachHang
               // 
               this.txtTenKhachHang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtTenKhachHang.Location = new System.Drawing.Point(209, 44);
               this.txtTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.txtTenKhachHang.Name = "txtTenKhachHang";
               this.txtTenKhachHang.Size = new System.Drawing.Size(365, 32);
               this.txtTenKhachHang.TabIndex = 8;
               this.txtTenKhachHang.TextChanged += new System.EventHandler(this.txtTenKhachHang_TextChanged);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.Location = new System.Drawing.Point(24, 199);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(71, 24);
               this.label5.TabIndex = 11;
               this.label5.Text = "Địa chỉ";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label9.Location = new System.Drawing.Point(24, 48);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(152, 24);
               this.label9.TabIndex = 8;
               this.label9.Text = "Tên khách hàng";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label7.Location = new System.Drawing.Point(24, 144);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(92, 24);
               this.label7.TabIndex = 10;
               this.label7.Text = "Số CMND";
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label8.Location = new System.Drawing.Point(24, 98);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(155, 24);
               this.label8.TabIndex = 9;
               this.label8.Text = "Loại khách hàng";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(30, 54);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(97, 24);
               this.label1.TabIndex = 0;
               this.label1.Text = "Mã phòng";
               // 
               // txtMaPhong
               // 
               this.txtMaPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtMaPhong.Location = new System.Drawing.Point(205, 44);
               this.txtMaPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.txtMaPhong.Name = "txtMaPhong";
               this.txtMaPhong.ReadOnly = true;
               this.txtMaPhong.Size = new System.Drawing.Size(343, 32);
               this.txtMaPhong.TabIndex = 4;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(30, 209);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(147, 24);
               this.label4.TabIndex = 3;
               this.label4.Text = "Ngày trả phòng";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(30, 154);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(162, 24);
               this.label3.TabIndex = 2;
               this.label3.Text = "Ngày thuê phòng";
               // 
               // txtLoaiPhong
               // 
               this.txtLoaiPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtLoaiPhong.Location = new System.Drawing.Point(205, 96);
               this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.txtLoaiPhong.Name = "txtLoaiPhong";
               this.txtLoaiPhong.ReadOnly = true;
               this.txtLoaiPhong.Size = new System.Drawing.Size(343, 32);
               this.txtLoaiPhong.TabIndex = 7;
               // 
               // dtpNgayTraPhong
               // 
               this.dtpNgayTraPhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dtpNgayTraPhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpNgayTraPhong.Location = new System.Drawing.Point(205, 199);
               this.dtpNgayTraPhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.dtpNgayTraPhong.Name = "dtpNgayTraPhong";
               this.dtpNgayTraPhong.Size = new System.Drawing.Size(343, 32);
               this.dtpNgayTraPhong.TabIndex = 6;
               // 
               // dtpNgayThuePhong
               // 
               this.dtpNgayThuePhong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.dtpNgayThuePhong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
               this.dtpNgayThuePhong.Location = new System.Drawing.Point(205, 144);
               this.dtpNgayThuePhong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.dtpNgayThuePhong.Name = "dtpNgayThuePhong";
               this.dtpNgayThuePhong.Size = new System.Drawing.Size(343, 32);
               this.dtpNgayThuePhong.TabIndex = 5;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(30, 106);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(108, 24);
               this.label2.TabIndex = 1;
               this.label2.Text = "Loại phòng";
               // 
               // groupBox1
               // 
               this.groupBox1.Controls.Add(this.txtLoaiPhong);
               this.groupBox1.Controls.Add(this.dtpNgayTraPhong);
               this.groupBox1.Controls.Add(this.dtpNgayThuePhong);
               this.groupBox1.Controls.Add(this.txtMaPhong);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.label3);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(64, 116);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.groupBox1.Size = new System.Drawing.Size(570, 276);
               this.groupBox1.TabIndex = 25;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin phiếu thuê";
               // 
               // btnThoat
               // 
               this.btnThoat.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnThoat.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnThoat.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThoat.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnThoat.Appearance.Options.UseBackColor = true;
               this.btnThoat.Appearance.Options.UseBorderColor = true;
               this.btnThoat.Appearance.Options.UseFont = true;
               this.btnThoat.Appearance.Options.UseForeColor = true;
               this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
               this.btnThoat.Location = new System.Drawing.Point(64, 674);
               this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
               this.btnThoat.Name = "btnThoat";
               this.btnThoat.Size = new System.Drawing.Size(140, 73);
               this.btnThoat.TabIndex = 32;
               this.btnThoat.Text = "Thoát";
               this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
               // 
               // btnXoaPhieuThue
               // 
               this.btnXoaPhieuThue.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnXoaPhieuThue.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnXoaPhieuThue.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnXoaPhieuThue.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoaPhieuThue.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnXoaPhieuThue.Appearance.Options.UseBackColor = true;
               this.btnXoaPhieuThue.Appearance.Options.UseBorderColor = true;
               this.btnXoaPhieuThue.Appearance.Options.UseFont = true;
               this.btnXoaPhieuThue.Appearance.Options.UseForeColor = true;
               this.btnXoaPhieuThue.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnXoaPhieuThue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuThue.ImageOptions.Image")));
               this.btnXoaPhieuThue.Location = new System.Drawing.Point(66, 572);
               this.btnXoaPhieuThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.btnXoaPhieuThue.Name = "btnXoaPhieuThue";
               this.btnXoaPhieuThue.Size = new System.Drawing.Size(140, 66);
               this.btnXoaPhieuThue.TabIndex = 31;
               this.btnXoaPhieuThue.Text = "Xóa";
               this.btnXoaPhieuThue.Click += new System.EventHandler(this.btnXoaPhieuThue_Click);
               // 
               // btnLuuPhieuThue
               // 
               this.btnLuuPhieuThue.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnLuuPhieuThue.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnLuuPhieuThue.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnLuuPhieuThue.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnLuuPhieuThue.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnLuuPhieuThue.Appearance.Options.UseBackColor = true;
               this.btnLuuPhieuThue.Appearance.Options.UseBorderColor = true;
               this.btnLuuPhieuThue.Appearance.Options.UseFont = true;
               this.btnLuuPhieuThue.Appearance.Options.UseForeColor = true;
               this.btnLuuPhieuThue.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnLuuPhieuThue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuPhieuThue.ImageOptions.Image")));
               this.btnLuuPhieuThue.Location = new System.Drawing.Point(64, 484);
               this.btnLuuPhieuThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.btnLuuPhieuThue.Name = "btnLuuPhieuThue";
               this.btnLuuPhieuThue.Size = new System.Drawing.Size(140, 66);
               this.btnLuuPhieuThue.TabIndex = 30;
               this.btnLuuPhieuThue.Text = "Lưu ";
               this.btnLuuPhieuThue.Click += new System.EventHandler(this.btnLuuPhieuThue_Click);
               // 
               // btnThemPhieuThue
               // 
               this.btnThemPhieuThue.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnThemPhieuThue.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnThemPhieuThue.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnThemPhieuThue.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThemPhieuThue.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnThemPhieuThue.Appearance.Options.UseBackColor = true;
               this.btnThemPhieuThue.Appearance.Options.UseBorderColor = true;
               this.btnThemPhieuThue.Appearance.Options.UseFont = true;
               this.btnThemPhieuThue.Appearance.Options.UseForeColor = true;
               this.btnThemPhieuThue.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnThemPhieuThue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuThue.ImageOptions.Image")));
               this.btnThemPhieuThue.Location = new System.Drawing.Point(64, 400);
               this.btnThemPhieuThue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.btnThemPhieuThue.Name = "btnThemPhieuThue";
               this.btnThemPhieuThue.Size = new System.Drawing.Size(140, 66);
               this.btnThemPhieuThue.TabIndex = 29;
               this.btnThemPhieuThue.Text = "Thêm";
               this.btnThemPhieuThue.Click += new System.EventHandler(this.btnThemPhieuThue_Click);
               // 
               // errorProvider1
               // 
               this.errorProvider1.ContainerControl = this;
               // 
               // errorProvider2
               // 
               this.errorProvider2.ContainerControl = this;
               // 
               // errorProvider3
               // 
               this.errorProvider3.ContainerControl = this;
               // 
               // errorProvider4
               // 
               this.errorProvider4.ContainerControl = this;
               // 
               // frmPhieuThuePhong
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1423, 769);
               this.Controls.Add(this.btnThoat);
               this.Controls.Add(this.btnXoaPhieuThue);
               this.Controls.Add(this.btnLuuPhieuThue);
               this.Controls.Add(this.btnThemPhieuThue);
               this.Controls.Add(this.dgvDanhSachPhieuThue);
               this.Controls.Add(this.label6);
               this.Controls.Add(this.groupBox2);
               this.Controls.Add(this.groupBox1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.MaximizeBox = false;
               this.Name = "frmPhieuThuePhong";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Phiếu thuê phòng";
               this.Load += new System.EventHandler(this.frmPhieuThuePhong_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuThue)).EndInit();
               this.groupBox2.ResumeLayout(false);
               this.groupBox2.PerformLayout();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXoaPhieuThue;
        private DevExpress.XtraEditors.SimpleButton btnLuuPhieuThue;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuThue;
        private System.Windows.Forms.DataGridView dgvDanhSachPhieuThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbLoaiKhachHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayTraPhong;
        private System.Windows.Forms.DateTimePicker dtpNgayThuePhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colXoa;
    }
}