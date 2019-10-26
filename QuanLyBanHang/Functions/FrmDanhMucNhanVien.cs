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
    public partial class FrmDanhMucNhanVien : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = QuanLyBanHang.Properties.Settings.Default.QuanLyBanHangConnectionString;

        public FrmDanhMucNhanVien()
        {
            InitializeComponent();
        }

        private void FrmDanhMucNhanVien_Load(object sender, EventArgs e)
        {
            // Load danh sách Nhân Viên
            LoadDanhMucNhanVien();
        }

        /// <summary>
        /// Hàm dùng để load danh sách Nhân Viên
        /// </summary>
        public void LoadDanhMucNhanVien()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM employees";

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
                        adapter.Fill(quanLyBanHangDataSet.employees);


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
            string queryString = "SELECT * FROM employees";

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
                        quanLyBanHangDataSet.employees.Clear();
                        quanLyBanHangDataSet.employees.AcceptChanges();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDataSet.employees);

                        // Hiển thị dữ liệu
                        employeesBindingSource.DataMember = null;
                        employeesBindingSource.DataSource = null;

                        employeesBindingSource.DataSource = quanLyBanHangDataSet.employees;

                        //employeesBindingSource.Refresh();

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

        // Chức năng button
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(last_nameTextBox.Text) || String.IsNullOrEmpty(first_nameTextBox.Text)
              || String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text)
              || String.IsNullOrEmpty(avatarTextBox.Text) || String.IsNullOrEmpty(job_titleTextBox.Text)
              || String.IsNullOrEmpty(departmentTextBox.Text) || String.IsNullOrEmpty(manager_idNumericUpDown.Text)
              || String.IsNullOrEmpty(phoneTextBox.Text) || String.IsNullOrEmpty(address1TextBox.Text) 
              || String.IsNullOrEmpty(address2TextBox.Text) || String.IsNullOrEmpty(cityTextBox.Text) 
              || String.IsNullOrEmpty(stateTextBox.Text) || String.IsNullOrEmpty(countryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại, dữ liệu nhập chưa đầy đủ!");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO employees([last_name], [first_name], [email], [password], [avatar], [job_title], [department], [manager_id], [phone], [address1], [address2], [city], [state], [postal_code], [country] ) VALUES(@last_name, @first_name, @email, @company, @phone, @address1, @address2, @city, @state, @postal_code, @country)";

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
                        command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        command.Parameters.AddWithValue("@avatar", avatarTextBox.Text);
                        command.Parameters.AddWithValue("@job_title", job_titleTextBox.Text);
                        command.Parameters.AddWithValue("@department", phoneTextBox.Text);
                        command.Parameters.AddWithValue("@manager_id", manager_idNumericUpDown.Text);
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
                        LoadDanhMucNhanVien();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang chọn dòng dữ liệu (RowIndex > 0)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.employeesDataGridView.Rows[e.RowIndex];

                // Binding vào các textbox tương ứng
                last_nameTextBox.Text = row.Cells["last_nameDataGridViewTextBoxColumn"].Value.ToString();
                first_nameTextBox.Text = row.Cells["first_nameDataGridViewTextBoxColumn"].Value.ToString();
                emailTextBox.Text = row.Cells["emailDataGridViewTextBoxColumn"].Value.ToString();
                passwordTextBox.Text = row.Cells["passwordDataGridViewTextBoxColumn"].Value.ToString();
                avatarTextBox.Text = row.Cells["avatarDataGridViewTextBoxColumn"].Value.ToString();
                job_titleTextBox.Text = row.Cells["job_titleDataGridViewTextBoxColumn"].Value.ToString();
                departmentTextBox.Text = row.Cells["departmentDataGridViewTextBoxColumn"].Value.ToString();
                manager_idNumericUpDown.Text = row.Cells["manager_idDataGridViewNumericUpDownColumn"].Value.ToString();
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
            if (String.IsNullOrEmpty(last_nameTextBox.Text) || String.IsNullOrEmpty(first_nameTextBox.Text)
              || String.IsNullOrEmpty(emailTextBox.Text) || String.IsNullOrEmpty(passwordTextBox.Text)
              || String.IsNullOrEmpty(avatarTextBox.Text) || String.IsNullOrEmpty(job_titleTextBox.Text)
              || String.IsNullOrEmpty(departmentTextBox.Text) || String.IsNullOrEmpty(manager_idNumericUpDown.Text)
              || String.IsNullOrEmpty(phoneTextBox.Text) || String.IsNullOrEmpty(address1TextBox.Text)
              || String.IsNullOrEmpty(address2TextBox.Text) || String.IsNullOrEmpty(cityTextBox.Text)
              || String.IsNullOrEmpty(stateTextBox.Text) || String.IsNullOrEmpty(countryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"UPDATE employees 
                                   SET [last_name] = @last_name, [first_name] = @first_name, [email] = @email,
                                        [company] = @company, [password] = @password, [avatar] = @avatar,
                                        [job_title] = @job_title, [department] = @department, 
                                        [manager_id] = @manager_id, [phone] = @phone, [address1] = @address1,
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
                        command.Parameters.AddWithValue("@email", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        command.Parameters.AddWithValue("@avatar", avatarTextBox.Text);
                        command.Parameters.AddWithValue("@job_title", job_titleTextBox.Text);
                        command.Parameters.AddWithValue("@department", phoneTextBox.Text);
                        command.Parameters.AddWithValue("@manager_id", manager_idNumericUpDown.Text);
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
                        LoadDanhMucNhanVien();
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
            string queryString = @"DELETE FROM employees WHERE id = @id";

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
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@last_name", last_nameTextBox.Text);
                        command.Parameters.AddWithValue("@first_name", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@email", first_nameTextBox.Text);
                        command.Parameters.AddWithValue("@password", passwordTextBox.Text);
                        command.Parameters.AddWithValue("@avatar", avatarTextBox.Text);
                        command.Parameters.AddWithValue("@job_title", job_titleTextBox.Text);
                        command.Parameters.AddWithValue("@department", phoneTextBox.Text);
                        command.Parameters.AddWithValue("@manager_id", manager_idNumericUpDown.Text);
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
