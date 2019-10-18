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
    public partial class FrmDatHang : Form
    {
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHangDataSet);

        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.order_details' table. You can move, or remove it, as needed.
            this.order_detailsTableAdapter.Fill(this.quanLyBanHangDataSet.order_details);
            // TODO: This line of code loads data into the 'quanLyBanHangDataSet.orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.quanLyBanHangDataSet.orders);

        }

        private void payment_typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void paid_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void order_statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void payment_typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void paid_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
