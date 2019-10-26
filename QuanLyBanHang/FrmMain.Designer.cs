namespace QuanLyBanHang
{
    partial class FrmMain
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
            this.mnusMain = new System.Windows.Forms.MenuStrip();
            this.tsmiHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCauHinh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMuaBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSanPhamBanChayNhat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSanPhamHetHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnusMain
            // 
            this.mnusMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnusMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHeThong,
            this.tsmiDanhMuc,
            this.tsmiMuaBan,
            this.tsmiBaoCao});
            this.mnusMain.Location = new System.Drawing.Point(0, 0);
            this.mnusMain.Name = "mnusMain";
            this.mnusMain.Size = new System.Drawing.Size(1325, 42);
            this.mnusMain.TabIndex = 0;
            this.mnusMain.Text = "menuStrip1";
            // 
            // tsmiHeThong
            // 
            this.tsmiHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCauHinh,
            this.tsmiThoat});
            this.tsmiHeThong.Name = "tsmiHeThong";
            this.tsmiHeThong.Size = new System.Drawing.Size(136, 38);
            this.tsmiHeThong.Text = "Hệ thống";
            // 
            // tsmiCauHinh
            // 
            this.tsmiCauHinh.Name = "tsmiCauHinh";
            this.tsmiCauHinh.Size = new System.Drawing.Size(359, 44);
            this.tsmiCauHinh.Text = "Cấu hình";
            this.tsmiCauHinh.Click += new System.EventHandler(this.tsmiCauHinh_Click);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(359, 44);
            this.tsmiThoat.Text = "Thoát";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // tsmiDanhMuc
            // 
            this.tsmiDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKhachHang,
            this.tsmiNhanVien,
            this.tsmiSanPham});
            this.tsmiDanhMuc.Name = "tsmiDanhMuc";
            this.tsmiDanhMuc.Size = new System.Drawing.Size(145, 38);
            this.tsmiDanhMuc.Text = "Danh mục";
            // 
            // tsmiKhachHang
            // 
            this.tsmiKhachHang.Name = "tsmiKhachHang";
            this.tsmiKhachHang.Size = new System.Drawing.Size(359, 44);
            this.tsmiKhachHang.Text = "Khách hàng";
            this.tsmiKhachHang.Click += new System.EventHandler(this.tsmiKhachHang_Click);
            // 
            // tsmiNhanVien
            // 
            this.tsmiNhanVien.Name = "tsmiNhanVien";
            this.tsmiNhanVien.Size = new System.Drawing.Size(359, 44);
            this.tsmiNhanVien.Text = "Nhân viên";
            this.tsmiNhanVien.Click += new System.EventHandler(this.tsmiNhanVien_Click);
            // 
            // tsmiSanPham
            // 
            this.tsmiSanPham.Name = "tsmiSanPham";
            this.tsmiSanPham.Size = new System.Drawing.Size(359, 44);
            this.tsmiSanPham.Text = "Sản phẩm";
            this.tsmiSanPham.Click += new System.EventHandler(this.tsmiSanPham_Click);
            // 
            // tsmiMuaBan
            // 
            this.tsmiMuaBan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDatHang});
            this.tsmiMuaBan.Name = "tsmiMuaBan";
            this.tsmiMuaBan.Size = new System.Drawing.Size(130, 38);
            this.tsmiMuaBan.Text = "Mua bán";
            // 
            // tsmiDatHang
            // 
            this.tsmiDatHang.Name = "tsmiDatHang";
            this.tsmiDatHang.Size = new System.Drawing.Size(359, 44);
            this.tsmiDatHang.Text = "Đặt hàng";
            this.tsmiDatHang.Click += new System.EventHandler(this.tsmiDatHang_Click);
            // 
            // tsmiBaoCao
            // 
            this.tsmiBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDoanhThu,
            this.tsmiSanPhamBanChayNhat,
            this.tsmiSanPhamHetHang});
            this.tsmiBaoCao.Name = "tsmiBaoCao";
            this.tsmiBaoCao.Size = new System.Drawing.Size(119, 38);
            this.tsmiBaoCao.Text = "Báo cáo";
            // 
            // tsmiDoanhThu
            // 
            this.tsmiDoanhThu.Name = "tsmiDoanhThu";
            this.tsmiDoanhThu.Size = new System.Drawing.Size(414, 44);
            this.tsmiDoanhThu.Text = "Doanh thu";
            // 
            // tsmiSanPhamBanChayNhat
            // 
            this.tsmiSanPhamBanChayNhat.Name = "tsmiSanPhamBanChayNhat";
            this.tsmiSanPhamBanChayNhat.Size = new System.Drawing.Size(414, 44);
            this.tsmiSanPhamBanChayNhat.Text = "Sản phẩm bán chạy nhất";
            // 
            // tsmiSanPhamHetHang
            // 
            this.tsmiSanPhamHetHang.Name = "tsmiSanPhamHetHang";
            this.tsmiSanPhamHetHang.Size = new System.Drawing.Size(414, 44);
            this.tsmiSanPhamHetHang.Text = "Sản phẩm hết hàng";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 661);
            this.Controls.Add(this.mnusMain);
            this.MainMenuStrip = this.mnusMain;
            this.Name = "FrmMain";
            this.Text = "Quản lý Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnusMain.ResumeLayout(false);
            this.mnusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnusMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiHeThong;
        private System.Windows.Forms.ToolStripMenuItem tsmiCauHinh;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem tsmiDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem tsmiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuaBan;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tsmiDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanPhamBanChayNhat;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanPhamHetHang;
    }
}