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
            // Lấy giá trị người dùng nhập vào 2 textbox
            string tenTaiKhoan = txtTendangnhap.Text;
            string matKhau = txtMatkhau.Text;

            // Kiểm tra đăng nhập
            if (tenTaiKhoan == "admin" && matKhau == "123456")
            {
                MessageBox.Show("Bạn đã đăng nhập thành công!!!");
                this.Hide();

                // Tạo đối tượng và gọi hàm Show()
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
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
