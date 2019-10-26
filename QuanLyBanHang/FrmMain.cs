using QuanLyBanHang.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiCauHinh_Click(object sender, EventArgs e)
        {
            FrmConfig frmConfig = new FrmConfig();
            frmConfig.Show();
        }

        private void tsmiKhachHang_Click(object sender, EventArgs e)
        {
            FrmDanhMucKhachHang frmDanhMucKhachHang = new FrmDanhMucKhachHang();
            frmDanhMucKhachHang.Show();
        }

        private void tsmiNhanVien_Click(object sender, EventArgs e)
        {
            FrmDanhMucNhanVien frmDanhMucNhanVien = new FrmDanhMucNhanVien();
            frmDanhMucNhanVien.Show();
        }

        private void tsmiSanPham_Click(object sender, EventArgs e)
        {
            FrmDanhMucSanPham frmDanhMucSanPham = new FrmDanhMucSanPham();
            frmDanhMucSanPham.Show();
        }

        private void tsmiDatHang_Click(object sender, EventArgs e)
        {
            FrmDatHang frmDatHang = new FrmDatHang();
            frmDatHang.Show();
        }
    }
}
