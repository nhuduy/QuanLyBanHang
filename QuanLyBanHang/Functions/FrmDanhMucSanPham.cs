using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Functions
{
    public partial class FrmDanhMucSanPham : Form
    {
        public FrmDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHangDataSet);

        }

        private void FrmDanhMucSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.quanLyBanHangDataSet.products);

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void standard_costLabel_Click(object sender, EventArgs e)
        {

        }

        private void standard_costTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
