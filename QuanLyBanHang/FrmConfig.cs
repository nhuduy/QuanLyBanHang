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
    public partial class FrmConfig : Form
    {
        public FrmConfig()
        {
            InitializeComponent();
        }

        private void configsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.configsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quanLyBanHangDataSet);

        }

        private void FrmConfig_Load(object sender, EventArgs e)
        {
        }
    }
}
