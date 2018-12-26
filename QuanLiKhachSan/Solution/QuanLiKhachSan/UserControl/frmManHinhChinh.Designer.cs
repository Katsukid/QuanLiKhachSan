namespace QuanLiKhachSan.UserControl
{
    partial class frmManHinhChinh
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManHinhChinh));
               this.ptbHotel = new System.Windows.Forms.PictureBox();
               ((System.ComponentModel.ISupportInitialize)(this.ptbHotel)).BeginInit();
               this.SuspendLayout();
               // 
               // ptbHotel
               // 
               this.ptbHotel.Dock = System.Windows.Forms.DockStyle.Fill;
               this.ptbHotel.Image = ((System.Drawing.Image)(resources.GetObject("ptbHotel.Image")));
               this.ptbHotel.Location = new System.Drawing.Point(0, 0);
               this.ptbHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.ptbHotel.Name = "ptbHotel";
               this.ptbHotel.Size = new System.Drawing.Size(1522, 860);
               this.ptbHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
               this.ptbHotel.TabIndex = 0;
               this.ptbHotel.TabStop = false;
               // 
               // frmManHinhChinh
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.ptbHotel);
               this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
               this.Name = "frmManHinhChinh";
               this.Size = new System.Drawing.Size(1522, 860);
               ((System.ComponentModel.ISupportInitialize)(this.ptbHotel)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbHotel;
    }
}
