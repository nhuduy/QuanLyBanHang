namespace QuanLyBanHang.Functions
{
    partial class FrmDatHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label shipping_feeLabel;
            this.grbDanhSachDonHang = new System.Windows.Forms.GroupBox();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.btnLayDanhSachDonHang = new System.Windows.Forms.Button();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpThongTinChiTietDonHang = new System.Windows.Forms.GroupBox();
            this.cbbProduct = new System.Windows.Forms.ComboBox();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudGiamGia = new System.Windows.Forms.NumericUpDown();
            this.nudDonGia = new System.Windows.Forms.NumericUpDown();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.grpThongTinDonHang = new System.Windows.Forms.GroupBox();
            this.nudShipping_fee = new System.Windows.Forms.NumericUpDown();
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.cbbEmployee = new System.Windows.Forms.ComboBox();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.ship_address2TextBox = new System.Windows.Forms.TextBox();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_typeTextBox = new System.Windows.Forms.TextBox();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.ship_postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.ship_stateTextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_address1TextBox = new System.Windows.Forms.TextBox();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.shipped_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            order_statusLabel = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            employee_idLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            shipping_feeLabel = new System.Windows.Forms.Label();
            this.grbDanhSachDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            this.grpThongTinChiTietDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.grpThongTinDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShipping_fee)).BeginInit();
            this.SuspendLayout();
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(989, 107);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(132, 25);
            order_statusLabel.TabIndex = 28;
            order_statusLabel.Text = "order status:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(1014, 72);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(107, 25);
            paid_dateLabel.TabIndex = 26;
            paid_dateLabel.Text = "paid date:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(974, 36);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(147, 25);
            payment_typeLabel.TabIndex = 24;
            payment_typeLabel.Text = "payment type:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(538, 188);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(135, 25);
            ship_countryLabel.TabIndex = 22;
            ship_countryLabel.Text = "ship country:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(498, 151);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(175, 25);
            ship_postal_codeLabel.TabIndex = 20;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(562, 113);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(111, 25);
            ship_stateLabel.TabIndex = 16;
            ship_stateLabel.Text = "ship state:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(576, 76);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(97, 25);
            ship_cityLabel.TabIndex = 14;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(520, 39);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(153, 25);
            ship_address2Label.TabIndex = 12;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(35, 225);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(153, 25);
            ship_address1Label.TabIndex = 10;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(71, 188);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(117, 25);
            ship_nameLabel.TabIndex = 8;
            ship_nameLabel.Text = "ship name:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(46, 152);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(142, 25);
            shipped_dateLabel.TabIndex = 6;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(72, 115);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(116, 25);
            order_dateLabel.TabIndex = 4;
            order_dateLabel.Text = "order date:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(326, 50);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(94, 25);
            quantityLabel.TabIndex = 16;
            quantityLabel.Text = "quantity:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(613, 50);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(106, 25);
            unit_priceLabel.TabIndex = 17;
            unit_priceLabel.Text = "unit price:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(926, 50);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(99, 25);
            discountLabel.TabIndex = 18;
            discountLabel.Text = "discount:";
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(54, 38);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(134, 25);
            employee_idLabel.TabIndex = 32;
            employee_idLabel.Text = "employee id:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(59, 73);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(129, 25);
            customer_idLabel.TabIndex = 33;
            customer_idLabel.Text = "customer id:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(18, 50);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(113, 25);
            product_idLabel.TabIndex = 19;
            product_idLabel.Text = "product id:";
            // 
            // shipping_feeLabel
            // 
            shipping_feeLabel.AutoSize = true;
            shipping_feeLabel.Location = new System.Drawing.Point(538, 225);
            shipping_feeLabel.Name = "shipping_feeLabel";
            shipping_feeLabel.Size = new System.Drawing.Size(135, 25);
            shipping_feeLabel.TabIndex = 34;
            shipping_feeLabel.Text = "shipping fee:";
            // 
            // grbDanhSachDonHang
            // 
            this.grbDanhSachDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDanhSachDonHang.Controls.Add(this.dgvDonHang);
            this.grbDanhSachDonHang.Controls.Add(this.btnLayDanhSachDonHang);
            this.grbDanhSachDonHang.Controls.Add(this.dtpDenNgay);
            this.grbDanhSachDonHang.Controls.Add(this.dtpTuNgay);
            this.grbDanhSachDonHang.Controls.Add(this.label2);
            this.grbDanhSachDonHang.Controls.Add(this.label1);
            this.grbDanhSachDonHang.Location = new System.Drawing.Point(7, 31);
            this.grbDanhSachDonHang.Name = "grbDanhSachDonHang";
            this.grbDanhSachDonHang.Size = new System.Drawing.Size(621, 834);
            this.grbDanhSachDonHang.TabIndex = 0;
            this.grbDanhSachDonHang.TabStop = false;
            this.grbDanhSachDonHang.Text = "Danh sách đơn hàng";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AutoGenerateColumns = false;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvDonHang.DataSource = this.ordersBindingSource;
            this.dgvDonHang.Location = new System.Drawing.Point(6, 188);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 82;
            this.dgvDonHang.RowTemplate.Height = 33;
            this.dgvDonHang.Size = new System.Drawing.Size(609, 220);
            this.dgvDonHang.TabIndex = 5;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "order_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "order_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "shipped_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "shipped_date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // quanLyBanHangDataSet
            // 
            this.quanLyBanHangDataSet.DataSetName = "QuanLyBanHangDataSet";
            this.quanLyBanHangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnLayDanhSachDonHang
            // 
            this.btnLayDanhSachDonHang.Location = new System.Drawing.Point(6, 128);
            this.btnLayDanhSachDonHang.Name = "btnLayDanhSachDonHang";
            this.btnLayDanhSachDonHang.Size = new System.Drawing.Size(609, 50);
            this.btnLayDanhSachDonHang.TabIndex = 2;
            this.btnLayDanhSachDonHang.Text = "Lấy danh sách đơn hàng";
            this.btnLayDanhSachDonHang.UseVisualStyleBackColor = true;
            this.btnLayDanhSachDonHang.Click += new System.EventHandler(this.LoadDanhSachDonHang);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(163, 76);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(333, 31);
            this.dtpDenNgay.TabIndex = 1;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(163, 27);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(333, 31);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "to date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "from date:";
            // 
            // grpThongTinChiTietDonHang
            // 
            this.grpThongTinChiTietDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinChiTietDonHang.Controls.Add(product_idLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(this.cbbProduct);
            this.grpThongTinChiTietDonHang.Controls.Add(this.dgvChiTietDonHang);
            this.grpThongTinChiTietDonHang.Controls.Add(discountLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudGiamGia);
            this.grpThongTinChiTietDonHang.Controls.Add(unit_priceLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudDonGia);
            this.grpThongTinChiTietDonHang.Controls.Add(quantityLabel);
            this.grpThongTinChiTietDonHang.Controls.Add(this.nudSoLuong);
            this.grpThongTinChiTietDonHang.Controls.Add(this.btnThemSP);
            this.grpThongTinChiTietDonHang.Location = new System.Drawing.Point(646, 337);
            this.grpThongTinChiTietDonHang.Name = "grpThongTinChiTietDonHang";
            this.grpThongTinChiTietDonHang.Size = new System.Drawing.Size(1405, 528);
            this.grpThongTinChiTietDonHang.TabIndex = 1;
            this.grpThongTinChiTietDonHang.TabStop = false;
            this.grpThongTinChiTietDonHang.Text = "Thông tin chi tiết đơn hàng";
            // 
            // cbbProduct
            // 
            this.cbbProduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "product_id", true));
            this.cbbProduct.FormattingEnabled = true;
            this.cbbProduct.Location = new System.Drawing.Point(137, 47);
            this.cbbProduct.Name = "cbbProduct";
            this.cbbProduct.Size = new System.Drawing.Size(121, 33);
            this.cbbProduct.TabIndex = 20;
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(12, 107);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.RowHeadersWidth = 82;
            this.dgvChiTietDonHang.RowTemplate.Height = 33;
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(1387, 413);
            this.dgvChiTietDonHang.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn8.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn10.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "unit_price";
            this.dataGridViewTextBoxColumn11.HeaderText = "unit_price";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn12.HeaderText = "discount";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "order_detail_status";
            this.dataGridViewTextBoxColumn13.HeaderText = "order_detail_status";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 200;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "date_allocated";
            this.dataGridViewTextBoxColumn14.HeaderText = "date_allocated";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 200;
            // 
            // nudGiamGia
            // 
            this.nudGiamGia.Location = new System.Drawing.Point(1031, 50);
            this.nudGiamGia.Name = "nudGiamGia";
            this.nudGiamGia.Size = new System.Drawing.Size(120, 31);
            this.nudGiamGia.TabIndex = 19;
            // 
            // nudDonGia
            // 
            this.nudDonGia.Location = new System.Drawing.Point(725, 50);
            this.nudDonGia.Name = "nudDonGia";
            this.nudDonGia.Size = new System.Drawing.Size(120, 31);
            this.nudDonGia.TabIndex = 18;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(426, 50);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(120, 31);
            this.nudSoLuong.TabIndex = 17;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemSP.Location = new System.Drawing.Point(1175, 35);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(206, 58);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Text = "Thêm chi tiết";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // grpThongTinDonHang
            // 
            this.grpThongTinDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinDonHang.Controls.Add(shipping_feeLabel);
            this.grpThongTinDonHang.Controls.Add(this.nudShipping_fee);
            this.grpThongTinDonHang.Controls.Add(customer_idLabel);
            this.grpThongTinDonHang.Controls.Add(this.cbbCustomer);
            this.grpThongTinDonHang.Controls.Add(employee_idLabel);
            this.grpThongTinDonHang.Controls.Add(this.cbbEmployee);
            this.grpThongTinDonHang.Controls.Add(order_statusLabel);
            this.grpThongTinDonHang.Controls.Add(this.order_statusTextBox);
            this.grpThongTinDonHang.Controls.Add(paid_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_address2TextBox);
            this.grpThongTinDonHang.Controls.Add(this.paid_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(payment_typeLabel);
            this.grpThongTinDonHang.Controls.Add(this.payment_typeTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_countryLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_countryTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_postal_codeLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_postal_codeTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_stateLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_stateTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_cityLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_cityTextBox);
            this.grpThongTinDonHang.Controls.Add(ship_address2Label);
            this.grpThongTinDonHang.Controls.Add(ship_address1Label);
            this.grpThongTinDonHang.Controls.Add(this.ship_address1TextBox);
            this.grpThongTinDonHang.Controls.Add(ship_nameLabel);
            this.grpThongTinDonHang.Controls.Add(this.ship_nameTextBox);
            this.grpThongTinDonHang.Controls.Add(shipped_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.shipped_dateDateTimePicker);
            this.grpThongTinDonHang.Controls.Add(order_dateLabel);
            this.grpThongTinDonHang.Controls.Add(this.order_dateDateTimePicker);
            this.grpThongTinDonHang.Location = new System.Drawing.Point(646, 31);
            this.grpThongTinDonHang.Name = "grpThongTinDonHang";
            this.grpThongTinDonHang.Size = new System.Drawing.Size(1405, 301);
            this.grpThongTinDonHang.TabIndex = 2;
            this.grpThongTinDonHang.TabStop = false;
            this.grpThongTinDonHang.Text = "Thông tin đơn hàng";
            // 
            // nudShipping_fee
            // 
            this.nudShipping_fee.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipping_fee", true));
            this.nudShipping_fee.Location = new System.Drawing.Point(679, 225);
            this.nudShipping_fee.Name = "nudShipping_fee";
            this.nudShipping_fee.Size = new System.Drawing.Size(120, 31);
            this.nudShipping_fee.TabIndex = 35;
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customer_id", true));
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(194, 70);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(254, 33);
            this.cbbCustomer.TabIndex = 34;
            // 
            // cbbEmployee
            // 
            this.cbbEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "employee_id", true));
            this.cbbEmployee.FormattingEnabled = true;
            this.cbbEmployee.Location = new System.Drawing.Point(194, 35);
            this.cbbEmployee.Name = "cbbEmployee";
            this.cbbEmployee.Size = new System.Drawing.Size(254, 33);
            this.cbbEmployee.TabIndex = 33;
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.Location = new System.Drawing.Point(1127, 104);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(254, 31);
            this.order_statusTextBox.TabIndex = 29;
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.Location = new System.Drawing.Point(679, 33);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(254, 31);
            this.ship_address2TextBox.TabIndex = 13;
            // 
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(1127, 68);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(254, 31);
            this.paid_dateDateTimePicker.TabIndex = 27;
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.Location = new System.Drawing.Point(1127, 33);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(254, 31);
            this.payment_typeTextBox.TabIndex = 25;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.Location = new System.Drawing.Point(679, 188);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(254, 31);
            this.ship_countryTextBox.TabIndex = 23;
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(679, 148);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(254, 31);
            this.ship_postal_codeTextBox.TabIndex = 21;
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.Location = new System.Drawing.Point(679, 110);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(254, 31);
            this.ship_stateTextBox.TabIndex = 17;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.Location = new System.Drawing.Point(679, 73);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(254, 31);
            this.ship_cityTextBox.TabIndex = 15;
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.Location = new System.Drawing.Point(194, 222);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(254, 31);
            this.ship_address1TextBox.TabIndex = 11;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.Location = new System.Drawing.Point(194, 185);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(254, 31);
            this.ship_nameTextBox.TabIndex = 9;
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(194, 148);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(254, 31);
            this.shipped_dateDateTimePicker.TabIndex = 7;
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(194, 111);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(254, 31);
            this.order_dateDateTimePicker.TabIndex = 5;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Location = new System.Drawing.Point(1924, 885);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(1754, 885);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(128, 52);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(1582, 885);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 52);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(1418, 885);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 52);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInHoaDon.Location = new System.Drawing.Point(1044, 885);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(155, 52);
            this.btnInHoaDon.TabIndex = 3;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(1251, 885);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 52);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2063, 961);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grpThongTinChiTietDonHang);
            this.Controls.Add(this.grpThongTinDonHang);
            this.Controls.Add(this.grbDanhSachDonHang);
            this.Name = "FrmDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDonHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            this.grbDanhSachDonHang.ResumeLayout(false);
            this.grbDanhSachDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            this.grpThongTinChiTietDonHang.ResumeLayout(false);
            this.grpThongTinChiTietDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGiamGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.grpThongTinDonHang.ResumeLayout(false);
            this.grpThongTinDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShipping_fee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachDonHang;
        private System.Windows.Forms.GroupBox grpThongTinChiTietDonHang;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.GroupBox grpThongTinDonHang;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox payment_typeTextBox;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox ship_postal_codeTextBox;
        private System.Windows.Forms.TextBox ship_stateTextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_address2TextBox;
        private System.Windows.Forms.TextBox ship_address1TextBox;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.DateTimePicker shipped_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnInHoaDon;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.Button btnLayDanhSachDonHang;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudGiamGia;
        private System.Windows.Forms.NumericUpDown nudDonGia;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.ComboBox cbbCustomer;
        private System.Windows.Forms.ComboBox cbbEmployee;
        private System.Windows.Forms.ComboBox cbbProduct;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nudShipping_fee;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}