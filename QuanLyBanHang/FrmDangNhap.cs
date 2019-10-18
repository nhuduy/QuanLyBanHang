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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtTendangnhap.Text == "admin" && txtMatkhau.Text == "123456")
            {
                MessageBox.Show("Đăng nhập thành công");

                FrmMain toMain = new FrmMain();
                this.Hide();

                toMain.ShowDialog();
                this.Show();
            }

            else
            {
                MessageBox.Show("Đăng nhập không thành công! Vui lòng kiểm tra lại tài khoản và mật khẩu.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
