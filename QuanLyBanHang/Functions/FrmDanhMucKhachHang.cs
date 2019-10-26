using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Functions
{
    public partial class FrmDanhMucKhachHang : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = QuanLyBanHang.Properties.Settings.Default.QuanLyBanHangConnectionString;

        public FrmDanhMucKhachHang()
        {
            InitializeComponent();
        }

        private void FrmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            LoadDanhMucKhachHang();
        }

        // Hàm xử lý
        public void LoadDanhMucKhachHang()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM customers";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDataSet.customers);

                        // Hiển thị dữ liệu
                        customersBindingSource.DataSource = null;
                        customersBindingSource.DataSource = quanLyBanHangDataSet.customers;
                        customersDataGridView.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Hàm dùng để load danh sách cấu hình
        /// </summary>
        public void LoadDanhMucCauHinhXoa()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM customers";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();
                        quanLyBanHangDataSet.Clear();
                        quanLyBanHangDataSet.Reset();
                        quanLyBanHangDataSet.customers.Clear();
                        quanLyBanHangDataSet.customers.AcceptChanges();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDataSet.customers);

                        // Hiển thị dữ liệu
                        customersBindingSource.DataMember = null;
                        customersBindingSource.DataSource = null;

                        customersBindingSource.DataSource = quanLyBanHangDataSet.customers;

                        //customersBindingSource.Refresh();

                        // Ngắt kết nối đến Database Server
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        // Button chức năng
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(last_nameTextBox.Text) || String.IsNullOrEmpty(first_nameTextBox.Text)
              || String.IsNullOrEmpty(companyTextBox.Text) || String.IsNullOrEmpty(phoneTextBox.Text)
              || String.IsNullOrEmpty(address1TextBox.Text) || String.IsNullOrEmpty(address2TextBox.Text)
              || String.IsNullOrEmpty(cityTextBox.Text) || String.IsNullOrEmpty(stateTextBox.Text)
              || String.IsNullOrEmpty(countryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại, dữ liệu nhập chưa đầy đủ!");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO customers([last_name], [first_name], [email], [company], [phone], [address1], [address2], [city], [state], [postal_code], [country] ) VALUES(@last_name, @first_name, @email, @company, @phone, @address1, @address2, @city, @state, @postal_code, @country)";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                        command.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@email", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@company", companyTextBox.Text);
                        command.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                        command.Parameters.AddWithValue("@address1", address1TextBox.Text);
                        command.Parameters.AddWithValue("@address2", address2TextBox.Text);
                        command.Parameters.AddWithValue("@city", cityTextBox.Text);
                        command.Parameters.AddWithValue("@state", stateTextBox.Text);
                        command.Parameters.AddWithValue("@postal_code", postal_codeTextBox.Text);
                        command.Parameters.AddWithValue("@country", countryTextBox.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucKhachHang();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void customersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang chọn dòng dữ liệu (RowIndex > 0)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.customersDataGridView.Rows[e.RowIndex];

                // Binding vào các textbox tương ứng
                last_nameTextBox.Text = row.Cells["last_nameDataGridViewTextBoxColumn"].Value.ToString();
                first_nameTextBox.Text = row.Cells["first_nameDataGridViewTextBoxColumn"].Value.ToString();
                emailTextBox.Text = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                companyTextBox.Text = row.Cells["companyDataGridViewTextBoxColumn"].Value.ToString();
                phoneTextBox.Text = row.Cells["phoneDataGridViewTextBoxColumn"].Value.ToString();
                address1TextBox.Text = row.Cells["address1DataGridViewTextBoxColumn"].Value.ToString();
                postal_codeTextBox.Text = row.Cells["postal_codeDataGridViewTextBoxColumn"].Value.ToString();
                address2TextBox.Text = row.Cells["address2DataGridViewTextBoxColumn"].Value.ToString();
                cityTextBox.Text = row.Cells["cityDataGridViewTextBoxColumn"].Value.ToString();
                stateTextBox.Text = row.Cells["stateDataGridViewTextBoxColumn"].Value.ToString();
                countryTextBox.Text = row.Cells["countryDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(last_nameTextBox.Text) || String.IsNullOrEmpty(first_nameTextBox.Text) ||
                    String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(companyTextBox.Text) ||
                    String.IsNullOrEmpty(phoneTextBox.Text) || String.IsNullOrEmpty(address1TextBox.Text) ||
                    String.IsNullOrEmpty(postal_codeTextBox.Text) || String.IsNullOrEmpty(address2TextBox.Text) ||
                    String.IsNullOrEmpty(cityTextBox.Text) || String.IsNullOrEmpty(stateTextBox.Text) ||
                    String.IsNullOrEmpty(countryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"UPDATE customers 
                                   SET [last_name] = @last_name, [first_name] = @first_name, [email] = @email,
                                        [company] = @company, [phone] = @phone, [address1] = @address1,
                                        [postal_code] = @postal_code, [address2] = @address2, [city] = @city, 
                                        [state] = @state, [country] = @country
                                   WHERE id = @id";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                        command.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@email", emailTextBox.Text);
                        command.Parameters.AddWithValue("@company", companyTextBox.Text);
                        command.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                        command.Parameters.AddWithValue("@address1", address1TextBox.Text);
                        command.Parameters.AddWithValue("@postal_code", postal_codeTextBox.Text);
                        command.Parameters.AddWithValue("@address2", address2TextBox.Text);
                        command.Parameters.AddWithValue("@city", cityTextBox.Text);
                        command.Parameters.AddWithValue("@state", stateTextBox.Text);
                        command.Parameters.AddWithValue("@country", countryTextBox.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucKhachHang();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại để xác nhận có chắc chắn muốn xóa hay không?
            DialogResult confirmDelete = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo);
            if (confirmDelete != DialogResult.Yes)
            {
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"DELETE FROM customers WHERE id = @id";

            // Tạo object từ class SqlConnection (dùng để quản lý kết nối đến Database Server)
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Tạo object từ class SqlCommand (dùng để quản lý việc thực thi câu lệnh)
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    try
                    {
                        // Mở kết nối đến Database Server
                        connection.Open();

                        // Truyền dữ liệu vào đúng tham số
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                        command.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@email", emailTextBox.Text);
                        command.Parameters.AddWithValue("@company", companyTextBox.Text);
                        command.Parameters.AddWithValue("@phone", phoneTextBox.Text);
                        command.Parameters.AddWithValue("@address1", address1TextBox.Text);
                        command.Parameters.AddWithValue("@postal_code", postal_codeTextBox.Text);
                        command.Parameters.AddWithValue("@address2", address2TextBox.Text);
                        command.Parameters.AddWithValue("@city", cityTextBox.Text);
                        command.Parameters.AddWithValue("@state", stateTextBox.Text);
                        command.Parameters.AddWithValue("@country", countryTextBox.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucCauHinhXoa();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển");
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
