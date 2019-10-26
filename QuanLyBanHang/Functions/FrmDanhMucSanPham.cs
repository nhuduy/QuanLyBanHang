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
    public partial class FrmDanhMucSanPham : Form
    {
        /// <summary>
        /// Chuỗi kết nối
        /// Lấy từ cấu hình (settings) của Project
        /// </summary>
        string connectionString = QuanLyBanHang.Properties.Settings.Default.QuanLyBanHangConnectionString;

        public FrmDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void FrmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            LoadDanhMucSanPham();
        }

        /// <summary>
        /// Hàm dùng để load danh sách Nhân Viên
        /// </summary>
        public void LoadDanhMucSanPham()
        {
            // Tạo câu lệnh để thực thi đến database
            string queryString = "SELECT * FROM products";

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
                        adapter.Fill(quanLyBanHangDataSet.products);


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
            string queryString = "SELECT * FROM products";

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
                        quanLyBanHangDataSet.products.Clear();
                        quanLyBanHangDataSet.products.AcceptChanges();

                        // Tạo object từ class SqlDataAdapter (dùng để lấy dữ liệu)
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.SelectCommand = command;

                        // Đổ dữ liệu vào dataset
                        adapter.Fill(quanLyBanHangDataSet.products);

                        // Hiển thị dữ liệu
                        productsBindingSource.DataMember = null;
                        productsBindingSource.DataSource = null;

                        productsBindingSource.DataSource = quanLyBanHangDataSet.products;

                        //productsBindingSource.Refresh();

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
            if (String.IsNullOrEmpty(product_codeTextBox.Text) || String.IsNullOrEmpty(product_nameTextBox.Text)
              || String.IsNullOrEmpty(descriptionTextBox.Text) || String.IsNullOrEmpty(standard_costTextBox.Text)
              || String.IsNullOrEmpty(list_priceTextBox.Text)
              || String.IsNullOrEmpty(target_levelNumericUpDown.Text) || String.IsNullOrEmpty(reorder_levelNumericUpDown.Text)
              || String.IsNullOrEmpty(minimum_reorder_quantityNumericUpDown.Text) || String.IsNullOrEmpty(quantity_per_unitTextBox.Text)
              || String.IsNullOrEmpty(discontinuedTextBox.Text) || String.IsNullOrEmpty(categoryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại, dữ liệu nhập chưa đầy đủ!");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"INSERT INTO products([product_code], [descriptionTextBox], [list_price], 
                                                        [standard_cost], [target_level], [reorder_level], 
                                                        [minimum_reorder], [minimum_reorder], [quantity_per_unit],
                                                        [discontinued], [category]) 
                                VALUES(@product_code, @descriptionTextBox, @list_price, @standard_cost, @target_level,
                                        @reorder_level, @minimum_reorder, @minimum_reorder, @quantity_per_unit, 
                                        @discontinued, @category)";

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
                        command.Parameters.AddWithValue("@product_code", product_codeTextBox.Text);
                        command.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                        command.Parameters.AddWithValue("@list_price", list_priceTextBox.Text);
                        command.Parameters.AddWithValue("@standard_cost", standard_costTextBox.Text);
                        command.Parameters.AddWithValue("@target_level", target_levelNumericUpDown.Text);
                        command.Parameters.AddWithValue("@reorder_level", reorder_levelNumericUpDown.Text);
                        command.Parameters.AddWithValue("@minimum_reorder", minimum_reorder_quantityNumericUpDown.Text);
                        command.Parameters.AddWithValue("@quantity_per_unit", quantity_per_unitTextBox.Text);
                        command.Parameters.AddWithValue("@discontinued", discontinuedTextBox.Text);
                        command.Parameters.AddWithValue("@category", categoryTextBox.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucSanPham();
                    }
                    catch (Exception ex)
                    {
                        // Hiển thị thông báo nếu có lỗi
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void productsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu đang chọn dòng dữ liệu (RowIndex > 0)
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu của dòng dữ liệu đang chọn
                DataGridViewRow row = this.dgvSanPham.Rows[e.RowIndex];

                // Binding vào các textbox tương ứng
                descriptionTextBox.Text = row.Cells["descriptionDataGridViewTextBoxColumn"].Value.ToString();
                list_priceTextBox.Text = row.Cells["list_priceDataGridViewTextBoxColumn"].Value.ToString();
                standard_costTextBox.Text = row.Cells["standard_costDataGridViewTextBoxColumn"].Value.ToString();
                target_levelNumericUpDown.Text = row.Cells["target_levelDataGridViewNumericUpDownColumn"].Value.ToString();
                reorder_levelNumericUpDown.Text = row.Cells["reorder_levelDataGridViewNumericUpDownColumn"].Value.ToString();
                minimum_reorder_quantityNumericUpDown.Text = row.Cells["minimum_reorder_quantityDataGridViewNumericUpDownTextBoxColumn"].Value.ToString();
                quantity_per_unitTextBox.Text = row.Cells["quantity_per_unitDataGridViewTextBoxColumn"].Value.ToString();
                discontinuedTextBox.Text = row.Cells["discontinuedDataGridViewTextBoxColumn"].Value.ToString();
                categoryTextBox.Text = row.Cells["categoryDataGridViewTextBoxColumn"].Value.ToString();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (String.IsNullOrEmpty(product_codeTextBox.Text) || String.IsNullOrEmpty(product_nameTextBox.Text)
              || String.IsNullOrEmpty(descriptionTextBox.Text) || String.IsNullOrEmpty(standard_costTextBox.Text)
              || String.IsNullOrEmpty(list_priceTextBox.Text)
              || String.IsNullOrEmpty(target_levelNumericUpDown.Text) || String.IsNullOrEmpty(reorder_levelNumericUpDown.Text)
              || String.IsNullOrEmpty(minimum_reorder_quantityNumericUpDown.Text) || String.IsNullOrEmpty(quantity_per_unitTextBox.Text)
              || String.IsNullOrEmpty(discontinuedTextBox.Text) || String.IsNullOrEmpty(categoryTextBox.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại dữ liệu nhập");
                return;
            }

            // Tạo câu lệnh để thực thi đến database
            string queryString = @"UPDATE products 
                                   SET [product_code] = @product_code, [descriptionTextBox] = @descriptionTextBox, 
                                        [list_price] = @list_price, [standard_cost] = @standard_cost,
                                        [target_level] = @target_level, [reorder_level] = @reorder_level, 
                                        [minimum_reorder] = @minimum_reorder, [quantity_per_unit] = @quantity_per_unit, 
                                        [discontinued] = @discontinued, [category] = @category
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
                        command.Parameters.AddWithValue("@product_code", product_codeTextBox.Text);
                        command.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                        command.Parameters.AddWithValue("@list_price", list_priceTextBox.Text);
                        command.Parameters.AddWithValue("@standard_cost", standard_costTextBox.Text);
                        command.Parameters.AddWithValue("@target_level", target_levelNumericUpDown.Text);
                        command.Parameters.AddWithValue("@reorder_level", reorder_levelNumericUpDown.Text);
                        command.Parameters.AddWithValue("@minimum_reorder", minimum_reorder_quantityNumericUpDown.Text);
                        command.Parameters.AddWithValue("@quantity_per_unit", quantity_per_unitTextBox.Text);
                        command.Parameters.AddWithValue("@discontinued", discontinuedTextBox.Text);
                        command.Parameters.AddWithValue("@category", categoryTextBox.Text);

                        // Thực thi câu lệnh
                        int effect = command.ExecuteNonQuery();

                        // Ngắt kết nối đến Database Server
                        connection.Close();

                        // Load lại danh sách cấu hình
                        LoadDanhMucSanPham();
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
            string queryString = @"DELETE FROM products WHERE id = @id";

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
                        command.Parameters.AddWithValue("@product_code", product_codeTextBox.Text);
                        command.Parameters.AddWithValue("@description", descriptionTextBox.Text);
                        command.Parameters.AddWithValue("@list_price", list_priceTextBox.Text);
                        command.Parameters.AddWithValue("@standard_cost", standard_costTextBox.Text);
                        command.Parameters.AddWithValue("@target_level", target_levelNumericUpDown.Text);
                        command.Parameters.AddWithValue("@reorder_level", reorder_levelNumericUpDown.Text);
                        command.Parameters.AddWithValue("@minimum_reorder", minimum_reorder_quantityNumericUpDown.Text);
                        command.Parameters.AddWithValue("@quantity_per_unit", quantity_per_unitTextBox.Text);
                        command.Parameters.AddWithValue("@discontinued", discontinuedTextBox.Text);
                        command.Parameters.AddWithValue("@category", categoryTextBox.Text);

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
