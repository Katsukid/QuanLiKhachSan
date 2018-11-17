namespace QuanLiKhachSan.UserControl
{
    partial class frmQuyDinh
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuyDinh));
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.txtGiaTri = new System.Windows.Forms.TextBox();
               this.cmbThamSo = new System.Windows.Forms.ComboBox();
               this.btnCapNhatQuyDinh = new DevExpress.XtraEditors.SimpleButton();
               this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(57, 70);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(87, 24);
               this.label1.TabIndex = 0;
               this.label1.Text = "Tham số";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(80, 149);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(64, 24);
               this.label2.TabIndex = 1;
               this.label2.Text = "Giá trị";
               // 
               // txtGiaTri
               // 
               this.txtGiaTri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.txtGiaTri.Location = new System.Drawing.Point(161, 149);
               this.txtGiaTri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.txtGiaTri.Name = "txtGiaTri";
               this.txtGiaTri.Size = new System.Drawing.Size(347, 32);
               this.txtGiaTri.TabIndex = 2;
               this.txtGiaTri.TextChanged += new System.EventHandler(this.txtGiaTri_TextChanged);
               // 
               // cmbThamSo
               // 
               this.cmbThamSo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cmbThamSo.FormattingEnabled = true;
               this.cmbThamSo.Items.AddRange(new object[] {
            "Số lượng khách tối đa",
            "Hệ số",
            "Phụ thu",
            "Loại phòng A",
            "Loại phòng B",
            "Loại phòng C"});
               this.cmbThamSo.Location = new System.Drawing.Point(161, 70);
               this.cmbThamSo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.cmbThamSo.Name = "cmbThamSo";
               this.cmbThamSo.Size = new System.Drawing.Size(347, 32);
               this.cmbThamSo.TabIndex = 3;
               this.cmbThamSo.SelectedIndexChanged += new System.EventHandler(this.cmbThamSo_SelectedIndexChanged);
               // 
               // btnCapNhatQuyDinh
               // 
               this.btnCapNhatQuyDinh.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnCapNhatQuyDinh.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnCapNhatQuyDinh.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnCapNhatQuyDinh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnCapNhatQuyDinh.Appearance.Options.UseBackColor = true;
               this.btnCapNhatQuyDinh.Appearance.Options.UseBorderColor = true;
               this.btnCapNhatQuyDinh.Appearance.Options.UseFont = true;
               this.btnCapNhatQuyDinh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnCapNhatQuyDinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatQuyDinh.ImageOptions.Image")));
               this.btnCapNhatQuyDinh.Location = new System.Drawing.Point(553, 57);
               this.btnCapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.btnCapNhatQuyDinh.Name = "btnCapNhatQuyDinh";
               this.btnCapNhatQuyDinh.Size = new System.Drawing.Size(193, 74);
               this.btnCapNhatQuyDinh.TabIndex = 4;
               this.btnCapNhatQuyDinh.Text = "Cập nhật";
               this.btnCapNhatQuyDinh.Click += new System.EventHandler(this.btnCapNhatQuyDinh_Click);
               // 
               // btnThoat
               // 
               this.btnThoat.Appearance.BackColor = System.Drawing.Color.SandyBrown;
               this.btnThoat.Appearance.BackColor2 = System.Drawing.Color.Tomato;
               this.btnThoat.Appearance.BorderColor = System.Drawing.Color.DarkRed;
               this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThoat.Appearance.Options.UseBackColor = true;
               this.btnThoat.Appearance.Options.UseBorderColor = true;
               this.btnThoat.Appearance.Options.UseFont = true;
               this.btnThoat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
               this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
               this.btnThoat.Location = new System.Drawing.Point(553, 149);
               this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.btnThoat.Name = "btnThoat";
               this.btnThoat.Size = new System.Drawing.Size(193, 74);
               this.btnThoat.TabIndex = 5;
               this.btnThoat.Text = "Thoát";
               this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
               // 
               // frmQuyDinh
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(788, 254);
               this.Controls.Add(this.btnThoat);
               this.Controls.Add(this.btnCapNhatQuyDinh);
               this.Controls.Add(this.cmbThamSo);
               this.Controls.Add(this.txtGiaTri);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.MaximizeBox = false;
               this.Name = "frmQuyDinh";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Thay đổi quy định";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.ComboBox cmbThamSo;
        private DevExpress.XtraEditors.SimpleButton btnCapNhatQuyDinh;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}