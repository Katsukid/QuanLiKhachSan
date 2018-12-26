namespace QuanLiKhachSan.UserControl
{
    partial class frmDanhSachPhongTrong
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDanhSachPhongTrong));
               this.label6 = new System.Windows.Forms.Label();
               this.txtGhiChu = new System.Windows.Forms.TextBox();
               this.txtDonGia = new System.Windows.Forms.TextBox();
               this.txtMaPhong = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.txtLoaiPhong = new System.Windows.Forms.TextBox();
               this.btnLamMoi = new DevExpress.XtraEditors.SimpleButton();
               this.btnDatPhong = new DevExpress.XtraEditors.SimpleButton();
               this.lvPhong = new System.Windows.Forms.ListView();
               this.imgListRoom = new System.Windows.Forms.ImageList(this.components);
               this.label2 = new System.Windows.Forms.Label();
               this.SuspendLayout();
               // 
               // label6
               // 
               this.label6.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label6.Location = new System.Drawing.Point(148, 6);
               this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(554, 66);
               this.label6.TabIndex = 20;
               this.label6.Text = "CHI TIẾT PHÒNG";
               this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // txtGhiChu
               // 
               this.txtGhiChu.Location = new System.Drawing.Point(21, 256);
               this.txtGhiChu.Margin = new System.Windows.Forms.Padding(4);
               this.txtGhiChu.Multiline = true;
               this.txtGhiChu.Name = "txtGhiChu";
               this.txtGhiChu.ReadOnly = true;
               this.txtGhiChu.Size = new System.Drawing.Size(764, 216);
               this.txtGhiChu.TabIndex = 27;
               // 
               // txtDonGia
               // 
               this.txtDonGia.Location = new System.Drawing.Point(525, 153);
               this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
               this.txtDonGia.Name = "txtDonGia";
               this.txtDonGia.ReadOnly = true;
               this.txtDonGia.Size = new System.Drawing.Size(260, 32);
               this.txtDonGia.TabIndex = 26;
               // 
               // txtMaPhong
               // 
               this.txtMaPhong.Location = new System.Drawing.Point(21, 153);
               this.txtMaPhong.Margin = new System.Windows.Forms.Padding(4);
               this.txtMaPhong.Name = "txtMaPhong";
               this.txtMaPhong.ReadOnly = true;
               this.txtMaPhong.Size = new System.Drawing.Size(229, 32);
               this.txtMaPhong.TabIndex = 25;
               this.txtMaPhong.TextChanged += new System.EventHandler(this.txtMaPhong_TextChanged);
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label5.ForeColor = System.Drawing.Color.Black;
               this.label5.Location = new System.Drawing.Point(20, 215);
               this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(76, 24);
               this.label5.TabIndex = 24;
               this.label5.Text = "Ghi chú";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.ForeColor = System.Drawing.Color.Black;
               this.label4.Location = new System.Drawing.Point(521, 110);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(79, 24);
               this.label4.TabIndex = 23;
               this.label4.Text = "Đơn giá";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.ForeColor = System.Drawing.Color.Black;
               this.label3.Location = new System.Drawing.Point(263, 110);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(108, 24);
               this.label3.TabIndex = 22;
               this.label3.Text = "Loại phòng";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.ForeColor = System.Drawing.Color.Black;
               this.label1.Location = new System.Drawing.Point(20, 110);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(97, 24);
               this.label1.TabIndex = 21;
               this.label1.Text = "Mã phòng";
               // 
               // txtLoaiPhong
               // 
               this.txtLoaiPhong.Location = new System.Drawing.Point(258, 153);
               this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
               this.txtLoaiPhong.Name = "txtLoaiPhong";
               this.txtLoaiPhong.ReadOnly = true;
               this.txtLoaiPhong.Size = new System.Drawing.Size(259, 32);
               this.txtLoaiPhong.TabIndex = 28;
               // 
               // btnLamMoi
               // 
               this.btnLamMoi.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnLamMoi.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnLamMoi.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnLamMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnLamMoi.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnLamMoi.Appearance.Options.UseBackColor = true;
               this.btnLamMoi.Appearance.Options.UseBorderColor = true;
               this.btnLamMoi.Appearance.Options.UseFont = true;
               this.btnLamMoi.Appearance.Options.UseForeColor = true;
               this.btnLamMoi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
               this.btnLamMoi.Location = new System.Drawing.Point(555, 502);
               this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
               this.btnLamMoi.Name = "btnLamMoi";
               this.btnLamMoi.Size = new System.Drawing.Size(230, 80);
               this.btnLamMoi.TabIndex = 30;
               this.btnLamMoi.Text = "Làm mới";
               this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
               // 
               // btnDatPhong
               // 
               this.btnDatPhong.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnDatPhong.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnDatPhong.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnDatPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDatPhong.Appearance.ForeColor = System.Drawing.Color.Black;
               this.btnDatPhong.Appearance.Options.UseBackColor = true;
               this.btnDatPhong.Appearance.Options.UseBorderColor = true;
               this.btnDatPhong.Appearance.Options.UseFont = true;
               this.btnDatPhong.Appearance.Options.UseForeColor = true;
               this.btnDatPhong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnDatPhong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatPhong.ImageOptions.Image")));
               this.btnDatPhong.Location = new System.Drawing.Point(24, 502);
               this.btnDatPhong.Margin = new System.Windows.Forms.Padding(4);
               this.btnDatPhong.Name = "btnDatPhong";
               this.btnDatPhong.Size = new System.Drawing.Size(226, 83);
               this.btnDatPhong.TabIndex = 29;
               this.btnDatPhong.Text = "Đặt phòng";
               this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
               // 
               // lvPhong
               // 
               this.lvPhong.LargeImageList = this.imgListRoom;
               this.lvPhong.Location = new System.Drawing.Point(823, 45);
               this.lvPhong.Margin = new System.Windows.Forms.Padding(4);
               this.lvPhong.Name = "lvPhong";
               this.lvPhong.Size = new System.Drawing.Size(780, 518);
               this.lvPhong.TabIndex = 31;
               this.lvPhong.UseCompatibleStateImageBehavior = false;
               this.lvPhong.Click += new System.EventHandler(this.listView1_Click);
               // 
               // imgListRoom
               // 
               this.imgListRoom.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
               this.imgListRoom.ImageSize = new System.Drawing.Size(50, 50);
               this.imgListRoom.TransparentColor = System.Drawing.Color.Transparent;
               // 
               // label2
               // 
               this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(1083, 6);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(297, 35);
               this.label2.TabIndex = 32;
               this.label2.Text = "Danh sách phòng trống";
               this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // frmDanhSachPhongTrong
               // 
               this.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.Appearance.Options.UseFont = true;
               this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.label2);
               this.Controls.Add(this.lvPhong);
               this.Controls.Add(this.btnLamMoi);
               this.Controls.Add(this.btnDatPhong);
               this.Controls.Add(this.txtLoaiPhong);
               this.Controls.Add(this.txtGhiChu);
               this.Controls.Add(this.txtDonGia);
               this.Controls.Add(this.txtMaPhong);
               this.Controls.Add(this.label5);
               this.Controls.Add(this.label4);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.label6);
               this.Margin = new System.Windows.Forms.Padding(5);
               this.Name = "frmDanhSachPhongTrong";
               this.Size = new System.Drawing.Size(1632, 612);
               this.Load += new System.EventHandler(this.frmDanhSachPhongTrong_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private DevExpress.XtraEditors.SimpleButton btnLamMoi;
        private DevExpress.XtraEditors.SimpleButton btnDatPhong;
        private System.Windows.Forms.ListView lvPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imgListRoom;
    }
}
