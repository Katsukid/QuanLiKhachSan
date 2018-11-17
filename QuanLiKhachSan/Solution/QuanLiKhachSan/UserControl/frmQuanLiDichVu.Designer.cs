﻿namespace QuanLiKhachSan.UserControl
{
    partial class frmQuanLiDichVu
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
               this.components = new System.ComponentModel.Container();
               DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiDichVu));
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.txtTenDichVu = new System.Windows.Forms.TextBox();
               this.txtDonViTinh = new System.Windows.Forms.TextBox();
               this.txtDonGia = new System.Windows.Forms.TextBox();
               this.gcDanhSachDichVu = new DevExpress.XtraGrid.GridControl();
               this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.grcMaDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
               this.grcTenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
               this.grcDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
               this.grcDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
               this.btnThemDichVu = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoaDichVu = new DevExpress.XtraEditors.SimpleButton();
               this.btnCapNhatDichVu = new DevExpress.XtraEditors.SimpleButton();
               this.btnLuuDichVu = new DevExpress.XtraEditors.SimpleButton();
               this.btnOder = new DevExpress.XtraEditors.SimpleButton();
               this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
               this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
               this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
               ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachDichVu)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
               this.SuspendLayout();
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(480, 54);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(107, 24);
               this.label2.TabIndex = 1;
               this.label2.Text = "Đơn vị tính";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(480, 94);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(79, 24);
               this.label3.TabIndex = 2;
               this.label3.Text = "Đơn giá";
               // 
               // label4
               // 
               this.label4.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(-8, 0);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(480, 83);
               this.label4.TabIndex = 3;
               this.label4.Text = "THÔNG TIN DỊCH VỤ";
               this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(480, 12);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(76, 24);
               this.label1.TabIndex = 4;
               this.label1.Text = "Dịch vụ";
               // 
               // txtTenDichVu
               // 
               this.txtTenDichVu.Location = new System.Drawing.Point(601, 9);
               this.txtTenDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtTenDichVu.Name = "txtTenDichVu";
               this.txtTenDichVu.Size = new System.Drawing.Size(277, 32);
               this.txtTenDichVu.TabIndex = 10;
               this.txtTenDichVu.TextChanged += new System.EventHandler(this.txtTenDichVu_TextChanged);
               // 
               // txtDonViTinh
               // 
               this.txtDonViTinh.Location = new System.Drawing.Point(601, 51);
               this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtDonViTinh.Name = "txtDonViTinh";
               this.txtDonViTinh.Size = new System.Drawing.Size(277, 32);
               this.txtDonViTinh.TabIndex = 11;
               this.txtDonViTinh.TextChanged += new System.EventHandler(this.txtDonViTinh_TextChanged);
               // 
               // txtDonGia
               // 
               this.txtDonGia.Location = new System.Drawing.Point(601, 94);
               this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txtDonGia.Name = "txtDonGia";
               this.txtDonGia.Size = new System.Drawing.Size(277, 32);
               this.txtDonGia.TabIndex = 12;
               this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
               // 
               // gcDanhSachDichVu
               // 
               this.gcDanhSachDichVu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
               this.gcDanhSachDichVu.Location = new System.Drawing.Point(32, 195);
               this.gcDanhSachDichVu.MainView = this.gridView1;
               this.gcDanhSachDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.gcDanhSachDichVu.Name = "gcDanhSachDichVu";
               this.gcDanhSachDichVu.Size = new System.Drawing.Size(1300, 440);
               this.gcDanhSachDichVu.TabIndex = 16;
               this.gcDanhSachDichVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
               this.gcDanhSachDichVu.Click += new System.EventHandler(this.gcDanhSachDichVu_Click);
               // 
               // gridView1
               // 
               this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grcMaDichVu,
            this.grcTenDichVu,
            this.grcDonViTinh,
            this.grcDonGia});
               this.gridView1.GridControl = this.gcDanhSachDichVu;
               this.gridView1.Name = "gridView1";
               this.gridView1.OptionsBehavior.Editable = false;
               // 
               // grcMaDichVu
               // 
               this.grcMaDichVu.Caption = "Mã dịch vụ";
               this.grcMaDichVu.FieldName = "MaDichVu";
               this.grcMaDichVu.Name = "grcMaDichVu";
               this.grcMaDichVu.Visible = true;
               this.grcMaDichVu.VisibleIndex = 0;
               // 
               // grcTenDichVu
               // 
               this.grcTenDichVu.Caption = "Tên dịch vụ";
               this.grcTenDichVu.FieldName = "TenDichVu";
               this.grcTenDichVu.Name = "grcTenDichVu";
               this.grcTenDichVu.Visible = true;
               this.grcTenDichVu.VisibleIndex = 1;
               // 
               // grcDonViTinh
               // 
               this.grcDonViTinh.Caption = "Đơn vị tính";
               this.grcDonViTinh.FieldName = "DonViTinh";
               this.grcDonViTinh.Name = "grcDonViTinh";
               this.grcDonViTinh.Visible = true;
               this.grcDonViTinh.VisibleIndex = 2;
               // 
               // grcDonGia
               // 
               this.grcDonGia.Caption = "Đơn giá";
               repositoryItemTextEdit2.AutoHeight = false;
               repositoryItemTextEdit2.DisplayFormat.FormatString = "0,0 VNĐ";
               repositoryItemTextEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
               repositoryItemTextEdit2.Name = "repositoryItemTextEdit1";
               this.grcDonGia.ColumnEdit = repositoryItemTextEdit2;
               this.grcDonGia.FieldName = "DonGia";
               this.grcDonGia.Name = "grcDonGia";
               this.grcDonGia.Visible = true;
               this.grcDonGia.VisibleIndex = 3;
               // 
               // btnThemDichVu
               // 
               this.btnThemDichVu.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnThemDichVu.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnThemDichVu.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnThemDichVu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThemDichVu.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnThemDichVu.Appearance.Options.UseBackColor = true;
               this.btnThemDichVu.Appearance.Options.UseBorderColor = true;
               this.btnThemDichVu.Appearance.Options.UseFont = true;
               this.btnThemDichVu.Appearance.Options.UseForeColor = true;
               this.btnThemDichVu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnThemDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDichVu.ImageOptions.Image")));
               this.btnThemDichVu.Location = new System.Drawing.Point(901, 9);
               this.btnThemDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThemDichVu.Name = "btnThemDichVu";
               this.btnThemDichVu.Size = new System.Drawing.Size(213, 68);
               this.btnThemDichVu.TabIndex = 17;
               this.btnThemDichVu.Text = "Thêm dịch vụ";
               this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
               // 
               // btnXoaDichVu
               // 
               this.btnXoaDichVu.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnXoaDichVu.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnXoaDichVu.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnXoaDichVu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoaDichVu.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnXoaDichVu.Appearance.Options.UseBackColor = true;
               this.btnXoaDichVu.Appearance.Options.UseBorderColor = true;
               this.btnXoaDichVu.Appearance.Options.UseFont = true;
               this.btnXoaDichVu.Appearance.Options.UseForeColor = true;
               this.btnXoaDichVu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnXoaDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDichVu.ImageOptions.Image")));
               this.btnXoaDichVu.Location = new System.Drawing.Point(1083, 86);
               this.btnXoaDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoaDichVu.Name = "btnXoaDichVu";
               this.btnXoaDichVu.Size = new System.Drawing.Size(189, 68);
               this.btnXoaDichVu.TabIndex = 20;
               this.btnXoaDichVu.Text = "Xóa Dịch vụ";
               this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
               // 
               // btnCapNhatDichVu
               // 
               this.btnCapNhatDichVu.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnCapNhatDichVu.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnCapNhatDichVu.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnCapNhatDichVu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnCapNhatDichVu.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnCapNhatDichVu.Appearance.Options.UseBackColor = true;
               this.btnCapNhatDichVu.Appearance.Options.UseBorderColor = true;
               this.btnCapNhatDichVu.Appearance.Options.UseFont = true;
               this.btnCapNhatDichVu.Appearance.Options.UseForeColor = true;
               this.btnCapNhatDichVu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnCapNhatDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatDichVu.ImageOptions.Image")));
               this.btnCapNhatDichVu.Location = new System.Drawing.Point(901, 85);
               this.btnCapNhatDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnCapNhatDichVu.Name = "btnCapNhatDichVu";
               this.btnCapNhatDichVu.Size = new System.Drawing.Size(152, 68);
               this.btnCapNhatDichVu.TabIndex = 19;
               this.btnCapNhatDichVu.Text = "Cập nhật";
               this.btnCapNhatDichVu.Click += new System.EventHandler(this.btnCapNhatDichVu_Click);
               // 
               // btnLuuDichVu
               // 
               this.btnLuuDichVu.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnLuuDichVu.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnLuuDichVu.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnLuuDichVu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnLuuDichVu.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnLuuDichVu.Appearance.Options.UseBackColor = true;
               this.btnLuuDichVu.Appearance.Options.UseBorderColor = true;
               this.btnLuuDichVu.Appearance.Options.UseFont = true;
               this.btnLuuDichVu.Appearance.Options.UseForeColor = true;
               this.btnLuuDichVu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnLuuDichVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDichVu.ImageOptions.Image")));
               this.btnLuuDichVu.Location = new System.Drawing.Point(1139, 10);
               this.btnLuuDichVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnLuuDichVu.Name = "btnLuuDichVu";
               this.btnLuuDichVu.Size = new System.Drawing.Size(133, 68);
               this.btnLuuDichVu.TabIndex = 18;
               this.btnLuuDichVu.Text = "Lưu";
               this.btnLuuDichVu.Click += new System.EventHandler(this.btnLuuDichVu_Click);
               // 
               // btnOder
               // 
               this.btnOder.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnOder.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnOder.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnOder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnOder.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnOder.Appearance.Options.UseBackColor = true;
               this.btnOder.Appearance.Options.UseBorderColor = true;
               this.btnOder.Appearance.Options.UseFont = true;
               this.btnOder.Appearance.Options.UseForeColor = true;
               this.btnOder.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnOder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOder.ImageOptions.Image")));
               this.btnOder.Location = new System.Drawing.Point(95, 94);
               this.btnOder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnOder.Name = "btnOder";
               this.btnOder.Size = new System.Drawing.Size(277, 68);
               this.btnOder.TabIndex = 21;
               this.btnOder.Text = "Oder Dịch vụ";
               this.btnOder.Click += new System.EventHandler(this.btnOder_Click);
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
               // frmQuanLiDichVu
               // 
               this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Appearance.Options.UseFont = true;
               this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.btnOder);
               this.Controls.Add(this.btnXoaDichVu);
               this.Controls.Add(this.btnCapNhatDichVu);
               this.Controls.Add(this.btnLuuDichVu);
               this.Controls.Add(this.btnThemDichVu);
               this.Controls.Add(this.gcDanhSachDichVu);
               this.Controls.Add(this.txtDonGia);
               this.Controls.Add(this.txtDonViTinh);
               this.Controls.Add(this.txtTenDichVu);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
               this.Name = "frmQuanLiDichVu";
               this.Size = new System.Drawing.Size(2202, 1099);
               this.Load += new System.EventHandler(this.frmQuanLiDichVu_Load);
               ((System.ComponentModel.ISupportInitialize)(this.gcDanhSachDichVu)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(repositoryItemTextEdit2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDichVu;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtDonGia;
        private DevExpress.XtraGrid.GridControl gcDanhSachDichVu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnThemDichVu;
        private DevExpress.XtraEditors.SimpleButton btnXoaDichVu;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatDichVu;
        private DevExpress.XtraEditors.SimpleButton btnLuuDichVu;
        private DevExpress.XtraEditors.SimpleButton btnOder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private DevExpress.XtraGrid.Columns.GridColumn grcMaDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn grcTenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn grcDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn grcDonGia;
    }
}
