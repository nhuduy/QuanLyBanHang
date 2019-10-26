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
            System.Windows.Forms.Label employee_idLabel;
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label order_dateLabel;
            System.Windows.Forms.Label shipped_dateLabel;
            System.Windows.Forms.Label ship_nameLabel;
            System.Windows.Forms.Label ship_address1Label;
            System.Windows.Forms.Label ship_address2Label;
            System.Windows.Forms.Label ship_cityLabel;
            System.Windows.Forms.Label ship_stateLabel;
            System.Windows.Forms.Label shipping_feeLabel;
            System.Windows.Forms.Label ship_postal_codeLabel;
            System.Windows.Forms.Label ship_countryLabel;
            System.Windows.Forms.Label payment_typeLabel;
            System.Windows.Forms.Label paid_dateLabel;
            System.Windows.Forms.Label order_statusLabel;
            System.Windows.Forms.Label order_idLabel;
            System.Windows.Forms.Label product_idLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label unit_priceLabel;
            System.Windows.Forms.Label discountLabel;
            System.Windows.Forms.Label order_detail_statusLabel;
            System.Windows.Forms.Label date_allocatedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatHang));
            this.gbThongtindonhang = new System.Windows.Forms.GroupBox();
            this.order_statusTextBox = new System.Windows.Forms.TextBox();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet = new QuanLyBanHang.QuanLyBanHangDataSet();
            this.paid_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payment_typeTextBox = new System.Windows.Forms.TextBox();
            this.ship_countryTextBox = new System.Windows.Forms.TextBox();
            this.ship_postal_codeTextBox = new System.Windows.Forms.TextBox();
            this.shipping_feeTextBox = new System.Windows.Forms.TextBox();
            this.ship_stateTextBox = new System.Windows.Forms.TextBox();
            this.ship_cityTextBox = new System.Windows.Forms.TextBox();
            this.ship_address2TextBox = new System.Windows.Forms.TextBox();
            this.ship_address1TextBox = new System.Windows.Forms.TextBox();
            this.ship_nameTextBox = new System.Windows.Forms.TextBox();
            this.shipped_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.employee_idTextBox = new System.Windows.Forms.TextBox();
            this.gbThongtinchitietdonhang = new System.Windows.Forms.GroupBox();
            this.order_detailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThemSP = new System.Windows.Forms.Button();
            this.date_allocatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.order_detail_statusTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.unit_priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.product_idTextBox = new System.Windows.Forms.TextBox();
            this.order_idTextBox = new System.Windows.Forms.TextBox();
            this.order_detailsTableAdapter = new QuanLyBanHang.QuanLyBanHangDataSetTableAdapters.order_detailsTableAdapter();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuudonhang = new System.Windows.Forms.Button();
            this.btnXoadonhang = new System.Windows.Forms.Button();
            this.btnSuadonhang = new System.Windows.Forms.Button();
            this.btnThemdonhang = new System.Windows.Forms.Button();
            employee_idLabel = new System.Windows.Forms.Label();
            customer_idLabel = new System.Windows.Forms.Label();
            order_dateLabel = new System.Windows.Forms.Label();
            shipped_dateLabel = new System.Windows.Forms.Label();
            ship_nameLabel = new System.Windows.Forms.Label();
            ship_address1Label = new System.Windows.Forms.Label();
            ship_address2Label = new System.Windows.Forms.Label();
            ship_cityLabel = new System.Windows.Forms.Label();
            ship_stateLabel = new System.Windows.Forms.Label();
            shipping_feeLabel = new System.Windows.Forms.Label();
            ship_postal_codeLabel = new System.Windows.Forms.Label();
            ship_countryLabel = new System.Windows.Forms.Label();
            payment_typeLabel = new System.Windows.Forms.Label();
            paid_dateLabel = new System.Windows.Forms.Label();
            order_statusLabel = new System.Windows.Forms.Label();
            order_idLabel = new System.Windows.Forms.Label();
            product_idLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            unit_priceLabel = new System.Windows.Forms.Label();
            discountLabel = new System.Windows.Forms.Label();
            order_detail_statusLabel = new System.Windows.Forms.Label();
            date_allocatedLabel = new System.Windows.Forms.Label();
            this.gbThongtindonhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).BeginInit();
            this.gbThongtinchitietdonhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // employee_idLabel
            // 
            employee_idLabel.AutoSize = true;
            employee_idLabel.Location = new System.Drawing.Point(26, 41);
            employee_idLabel.Name = "employee_idLabel";
            employee_idLabel.Size = new System.Drawing.Size(134, 25);
            employee_idLabel.TabIndex = 0;
            employee_idLabel.Text = "employee id:";
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(31, 78);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(129, 25);
            customer_idLabel.TabIndex = 2;
            customer_idLabel.Text = "customer id:";
            // 
            // order_dateLabel
            // 
            order_dateLabel.AutoSize = true;
            order_dateLabel.Location = new System.Drawing.Point(44, 116);
            order_dateLabel.Name = "order_dateLabel";
            order_dateLabel.Size = new System.Drawing.Size(116, 25);
            order_dateLabel.TabIndex = 4;
            order_dateLabel.Text = "order date:";
            // 
            // shipped_dateLabel
            // 
            shipped_dateLabel.AutoSize = true;
            shipped_dateLabel.Location = new System.Drawing.Point(18, 153);
            shipped_dateLabel.Name = "shipped_dateLabel";
            shipped_dateLabel.Size = new System.Drawing.Size(142, 25);
            shipped_dateLabel.TabIndex = 6;
            shipped_dateLabel.Text = "shipped date:";
            // 
            // ship_nameLabel
            // 
            ship_nameLabel.AutoSize = true;
            ship_nameLabel.Location = new System.Drawing.Point(43, 189);
            ship_nameLabel.Name = "ship_nameLabel";
            ship_nameLabel.Size = new System.Drawing.Size(117, 25);
            ship_nameLabel.TabIndex = 8;
            ship_nameLabel.Text = "ship name:";
            // 
            // ship_address1Label
            // 
            ship_address1Label.AutoSize = true;
            ship_address1Label.Location = new System.Drawing.Point(7, 226);
            ship_address1Label.Name = "ship_address1Label";
            ship_address1Label.Size = new System.Drawing.Size(153, 25);
            ship_address1Label.TabIndex = 10;
            ship_address1Label.Text = "ship address1:";
            // 
            // ship_address2Label
            // 
            ship_address2Label.AutoSize = true;
            ship_address2Label.Location = new System.Drawing.Point(571, 42);
            ship_address2Label.Name = "ship_address2Label";
            ship_address2Label.Size = new System.Drawing.Size(153, 25);
            ship_address2Label.TabIndex = 12;
            ship_address2Label.Text = "ship address2:";
            // 
            // ship_cityLabel
            // 
            ship_cityLabel.AutoSize = true;
            ship_cityLabel.Location = new System.Drawing.Point(627, 79);
            ship_cityLabel.Name = "ship_cityLabel";
            ship_cityLabel.Size = new System.Drawing.Size(97, 25);
            ship_cityLabel.TabIndex = 14;
            ship_cityLabel.Text = "ship city:";
            // 
            // ship_stateLabel
            // 
            ship_stateLabel.AutoSize = true;
            ship_stateLabel.Location = new System.Drawing.Point(613, 116);
            ship_stateLabel.Name = "ship_stateLabel";
            ship_stateLabel.Size = new System.Drawing.Size(111, 25);
            ship_stateLabel.TabIndex = 16;
            ship_stateLabel.Text = "ship state:";
            // 
            // shipping_feeLabel
            // 
            shipping_feeLabel.AutoSize = true;
            shipping_feeLabel.Location = new System.Drawing.Point(589, 228);
            shipping_feeLabel.Name = "shipping_feeLabel";
            shipping_feeLabel.Size = new System.Drawing.Size(135, 25);
            shipping_feeLabel.TabIndex = 18;
            shipping_feeLabel.Text = "shipping fee:";
            // 
            // ship_postal_codeLabel
            // 
            ship_postal_codeLabel.AutoSize = true;
            ship_postal_codeLabel.Location = new System.Drawing.Point(549, 154);
            ship_postal_codeLabel.Name = "ship_postal_codeLabel";
            ship_postal_codeLabel.Size = new System.Drawing.Size(175, 25);
            ship_postal_codeLabel.TabIndex = 20;
            ship_postal_codeLabel.Text = "ship postal code:";
            // 
            // ship_countryLabel
            // 
            ship_countryLabel.AutoSize = true;
            ship_countryLabel.Location = new System.Drawing.Point(589, 191);
            ship_countryLabel.Name = "ship_countryLabel";
            ship_countryLabel.Size = new System.Drawing.Size(135, 25);
            ship_countryLabel.TabIndex = 22;
            ship_countryLabel.Text = "ship country:";
            // 
            // payment_typeLabel
            // 
            payment_typeLabel.AutoSize = true;
            payment_typeLabel.Location = new System.Drawing.Point(1042, 42);
            payment_typeLabel.Name = "payment_typeLabel";
            payment_typeLabel.Size = new System.Drawing.Size(147, 25);
            payment_typeLabel.TabIndex = 24;
            payment_typeLabel.Text = "payment type:";
            // 
            // paid_dateLabel
            // 
            paid_dateLabel.AutoSize = true;
            paid_dateLabel.Location = new System.Drawing.Point(1082, 78);
            paid_dateLabel.Name = "paid_dateLabel";
            paid_dateLabel.Size = new System.Drawing.Size(107, 25);
            paid_dateLabel.TabIndex = 26;
            paid_dateLabel.Text = "paid date:";
            // 
            // order_statusLabel
            // 
            order_statusLabel.AutoSize = true;
            order_statusLabel.Location = new System.Drawing.Point(1057, 113);
            order_statusLabel.Name = "order_statusLabel";
            order_statusLabel.Size = new System.Drawing.Size(132, 25);
            order_statusLabel.TabIndex = 28;
            order_statusLabel.Text = "order status:";
            // 
            // order_idLabel
            // 
            order_idLabel.AutoSize = true;
            order_idLabel.Location = new System.Drawing.Point(11, 42);
            order_idLabel.Name = "order_idLabel";
            order_idLabel.Size = new System.Drawing.Size(91, 25);
            order_idLabel.TabIndex = 0;
            order_idLabel.Text = "order id:";
            // 
            // product_idLabel
            // 
            product_idLabel.AutoSize = true;
            product_idLabel.Location = new System.Drawing.Point(193, 42);
            product_idLabel.Name = "product_idLabel";
            product_idLabel.Size = new System.Drawing.Size(113, 25);
            product_idLabel.TabIndex = 2;
            product_idLabel.Text = "product id:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(396, 39);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(94, 25);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "quantity:";
            // 
            // unit_priceLabel
            // 
            unit_priceLabel.AutoSize = true;
            unit_priceLabel.Location = new System.Drawing.Point(601, 42);
            unit_priceLabel.Name = "unit_priceLabel";
            unit_priceLabel.Size = new System.Drawing.Size(106, 25);
            unit_priceLabel.TabIndex = 6;
            unit_priceLabel.Text = "unit price:";
            // 
            // discountLabel
            // 
            discountLabel.AutoSize = true;
            discountLabel.Location = new System.Drawing.Point(808, 42);
            discountLabel.Name = "discountLabel";
            discountLabel.Size = new System.Drawing.Size(99, 25);
            discountLabel.TabIndex = 8;
            discountLabel.Text = "discount:";
            // 
            // order_detail_statusLabel
            // 
            order_detail_statusLabel.AutoSize = true;
            order_detail_statusLabel.Location = new System.Drawing.Point(1015, 42);
            order_detail_statusLabel.Name = "order_detail_statusLabel";
            order_detail_statusLabel.Size = new System.Drawing.Size(190, 25);
            order_detail_statusLabel.TabIndex = 10;
            order_detail_statusLabel.Text = "order detail status:";
            // 
            // date_allocatedLabel
            // 
            date_allocatedLabel.AutoSize = true;
            date_allocatedLabel.Location = new System.Drawing.Point(1252, 42);
            date_allocatedLabel.Name = "date_allocatedLabel";
            date_allocatedLabel.Size = new System.Drawing.Size(153, 25);
            date_allocatedLabel.TabIndex = 12;
            date_allocatedLabel.Text = "date allocated:";
            // 
            // gbThongtindonhang
            // 
            this.gbThongtindonhang.Controls.Add(order_statusLabel);
            this.gbThongtindonhang.Controls.Add(this.order_statusTextBox);
            this.gbThongtindonhang.Controls.Add(paid_dateLabel);
            this.gbThongtindonhang.Controls.Add(this.paid_dateDateTimePicker);
            this.gbThongtindonhang.Controls.Add(payment_typeLabel);
            this.gbThongtindonhang.Controls.Add(this.payment_typeTextBox);
            this.gbThongtindonhang.Controls.Add(ship_countryLabel);
            this.gbThongtindonhang.Controls.Add(this.ship_countryTextBox);
            this.gbThongtindonhang.Controls.Add(ship_postal_codeLabel);
            this.gbThongtindonhang.Controls.Add(this.ship_postal_codeTextBox);
            this.gbThongtindonhang.Controls.Add(shipping_feeLabel);
            this.gbThongtindonhang.Controls.Add(this.shipping_feeTextBox);
            this.gbThongtindonhang.Controls.Add(ship_stateLabel);
            this.gbThongtindonhang.Controls.Add(this.ship_stateTextBox);
            this.gbThongtindonhang.Controls.Add(ship_cityLabel);
            this.gbThongtindonhang.Controls.Add(this.ship_cityTextBox);
            this.gbThongtindonhang.Controls.Add(ship_address2Label);
            this.gbThongtindonhang.Controls.Add(this.ship_address2TextBox);
            this.gbThongtindonhang.Controls.Add(ship_address1Label);
            this.gbThongtindonhang.Controls.Add(this.ship_address1TextBox);
            this.gbThongtindonhang.Controls.Add(ship_nameLabel);
            this.gbThongtindonhang.Controls.Add(this.ship_nameTextBox);
            this.gbThongtindonhang.Controls.Add(shipped_dateLabel);
            this.gbThongtindonhang.Controls.Add(this.shipped_dateDateTimePicker);
            this.gbThongtindonhang.Controls.Add(order_dateLabel);
            this.gbThongtindonhang.Controls.Add(this.order_dateDateTimePicker);
            this.gbThongtindonhang.Controls.Add(customer_idLabel);
            this.gbThongtindonhang.Controls.Add(this.customer_idTextBox);
            this.gbThongtindonhang.Controls.Add(employee_idLabel);
            this.gbThongtindonhang.Controls.Add(this.employee_idTextBox);
            this.gbThongtindonhang.Location = new System.Drawing.Point(13, 13);
            this.gbThongtindonhang.Name = "gbThongtindonhang";
            this.gbThongtindonhang.Size = new System.Drawing.Size(1575, 280);
            this.gbThongtindonhang.TabIndex = 0;
            this.gbThongtindonhang.TabStop = false;
            this.gbThongtindonhang.Text = "Thông tin đơn hàng";
            // 
            // order_statusTextBox
            // 
            this.order_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_status", true));
            this.order_statusTextBox.Location = new System.Drawing.Point(1195, 110);
            this.order_statusTextBox.Name = "order_statusTextBox";
            this.order_statusTextBox.Size = new System.Drawing.Size(363, 31);
            this.order_statusTextBox.TabIndex = 29;
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
            // paid_dateDateTimePicker
            // 
            this.paid_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "paid_date", true));
            this.paid_dateDateTimePicker.Location = new System.Drawing.Point(1195, 74);
            this.paid_dateDateTimePicker.Name = "paid_dateDateTimePicker";
            this.paid_dateDateTimePicker.Size = new System.Drawing.Size(363, 31);
            this.paid_dateDateTimePicker.TabIndex = 27;
            // 
            // payment_typeTextBox
            // 
            this.payment_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "payment_type", true));
            this.payment_typeTextBox.Location = new System.Drawing.Point(1195, 39);
            this.payment_typeTextBox.Name = "payment_typeTextBox";
            this.payment_typeTextBox.Size = new System.Drawing.Size(363, 31);
            this.payment_typeTextBox.TabIndex = 25;
            // 
            // ship_countryTextBox
            // 
            this.ship_countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_country", true));
            this.ship_countryTextBox.Location = new System.Drawing.Point(730, 188);
            this.ship_countryTextBox.Name = "ship_countryTextBox";
            this.ship_countryTextBox.Size = new System.Drawing.Size(295, 31);
            this.ship_countryTextBox.TabIndex = 23;
            // 
            // ship_postal_codeTextBox
            // 
            this.ship_postal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_postal_code", true));
            this.ship_postal_codeTextBox.Location = new System.Drawing.Point(730, 151);
            this.ship_postal_codeTextBox.Name = "ship_postal_codeTextBox";
            this.ship_postal_codeTextBox.Size = new System.Drawing.Size(295, 31);
            this.ship_postal_codeTextBox.TabIndex = 21;
            // 
            // shipping_feeTextBox
            // 
            this.shipping_feeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "shipping_fee", true));
            this.shipping_feeTextBox.Location = new System.Drawing.Point(730, 225);
            this.shipping_feeTextBox.Name = "shipping_feeTextBox";
            this.shipping_feeTextBox.Size = new System.Drawing.Size(295, 31);
            this.shipping_feeTextBox.TabIndex = 19;
            // 
            // ship_stateTextBox
            // 
            this.ship_stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_state", true));
            this.ship_stateTextBox.Location = new System.Drawing.Point(730, 113);
            this.ship_stateTextBox.Name = "ship_stateTextBox";
            this.ship_stateTextBox.Size = new System.Drawing.Size(295, 31);
            this.ship_stateTextBox.TabIndex = 17;
            // 
            // ship_cityTextBox
            // 
            this.ship_cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_city", true));
            this.ship_cityTextBox.Location = new System.Drawing.Point(730, 76);
            this.ship_cityTextBox.Name = "ship_cityTextBox";
            this.ship_cityTextBox.Size = new System.Drawing.Size(295, 31);
            this.ship_cityTextBox.TabIndex = 15;
            // 
            // ship_address2TextBox
            // 
            this.ship_address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address2", true));
            this.ship_address2TextBox.Location = new System.Drawing.Point(730, 39);
            this.ship_address2TextBox.Name = "ship_address2TextBox";
            this.ship_address2TextBox.Size = new System.Drawing.Size(295, 31);
            this.ship_address2TextBox.TabIndex = 13;
            // 
            // ship_address1TextBox
            // 
            this.ship_address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_address1", true));
            this.ship_address1TextBox.Location = new System.Drawing.Point(166, 223);
            this.ship_address1TextBox.Name = "ship_address1TextBox";
            this.ship_address1TextBox.Size = new System.Drawing.Size(360, 31);
            this.ship_address1TextBox.TabIndex = 11;
            // 
            // ship_nameTextBox
            // 
            this.ship_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_name", true));
            this.ship_nameTextBox.Location = new System.Drawing.Point(166, 186);
            this.ship_nameTextBox.Name = "ship_nameTextBox";
            this.ship_nameTextBox.Size = new System.Drawing.Size(360, 31);
            this.ship_nameTextBox.TabIndex = 9;
            // 
            // shipped_dateDateTimePicker
            // 
            this.shipped_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "shipped_date", true));
            this.shipped_dateDateTimePicker.Location = new System.Drawing.Point(166, 149);
            this.shipped_dateDateTimePicker.Name = "shipped_dateDateTimePicker";
            this.shipped_dateDateTimePicker.Size = new System.Drawing.Size(360, 31);
            this.shipped_dateDateTimePicker.TabIndex = 7;
            // 
            // order_dateDateTimePicker
            // 
            this.order_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ordersBindingSource, "order_date", true));
            this.order_dateDateTimePicker.Location = new System.Drawing.Point(166, 112);
            this.order_dateDateTimePicker.Name = "order_dateDateTimePicker";
            this.order_dateDateTimePicker.Size = new System.Drawing.Size(360, 31);
            this.order_dateDateTimePicker.TabIndex = 5;
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(166, 75);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(360, 31);
            this.customer_idTextBox.TabIndex = 3;
            // 
            // employee_idTextBox
            // 
            this.employee_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "employee_id", true));
            this.employee_idTextBox.Location = new System.Drawing.Point(166, 38);
            this.employee_idTextBox.Name = "employee_idTextBox";
            this.employee_idTextBox.Size = new System.Drawing.Size(360, 31);
            this.employee_idTextBox.TabIndex = 1;
            // 
            // gbThongtinchitietdonhang
            // 
            this.gbThongtinchitietdonhang.Controls.Add(this.order_detailsDataGridView);
            this.gbThongtinchitietdonhang.Controls.Add(this.btnThemSP);
            this.gbThongtinchitietdonhang.Controls.Add(date_allocatedLabel);
            this.gbThongtinchitietdonhang.Controls.Add(this.date_allocatedDateTimePicker);
            this.gbThongtinchitietdonhang.Controls.Add(order_detail_statusLabel);
            this.gbThongtinchitietdonhang.Controls.Add(this.order_detail_statusTextBox);
            this.gbThongtinchitietdonhang.Controls.Add(discountLabel);
            this.gbThongtinchitietdonhang.Controls.Add(this.discountTextBox);
            this.gbThongtinchitietdonhang.Controls.Add(unit_priceLabel);
            this.gbThongtinchitietdonhang.Controls.Add(this.unit_priceTextBox);
            this.gbThongtinchitietdonhang.Controls.Add(quantityLabel);
            this.gbThongtinchitietdonhang.Controls.Add(this.quantityTextBox);
            this.gbThongtinchitietdonhang.Controls.Add(product_idLabel);
            this.gbThongtinchitietdonhang.Controls.Add(this.product_idTextBox);
            this.gbThongtinchitietdonhang.Controls.Add(order_idLabel);
            this.gbThongtinchitietdonhang.Controls.Add(this.order_idTextBox);
            this.gbThongtinchitietdonhang.Location = new System.Drawing.Point(13, 319);
            this.gbThongtinchitietdonhang.Name = "gbThongtinchitietdonhang";
            this.gbThongtinchitietdonhang.Size = new System.Drawing.Size(1578, 593);
            this.gbThongtinchitietdonhang.TabIndex = 0;
            this.gbThongtinchitietdonhang.TabStop = false;
            this.gbThongtinchitietdonhang.Text = "Thông tin chi tiết đơn hàng";
            // 
            // order_detailsDataGridView
            // 
            this.order_detailsDataGridView.AutoGenerateColumns = false;
            this.order_detailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_detailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.order_detailsDataGridView.DataSource = this.order_detailsBindingSource;
            this.order_detailsDataGridView.Location = new System.Drawing.Point(12, 127);
            this.order_detailsDataGridView.Name = "order_detailsDataGridView";
            this.order_detailsDataGridView.RowHeadersWidth = 82;
            this.order_detailsDataGridView.RowTemplate.Height = 33;
            this.order_detailsDataGridView.Size = new System.Drawing.Size(1546, 445);
            this.order_detailsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "order_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "order_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "product_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "product_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "unit_price";
            this.dataGridViewTextBoxColumn4.HeaderText = "unit_price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "discount";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "order_detail_status";
            this.dataGridViewTextBoxColumn6.HeaderText = "order_detail_status";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "date_allocated";
            this.dataGridViewTextBoxColumn7.HeaderText = "date_allocated";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // order_detailsBindingSource
            // 
            this.order_detailsBindingSource.DataMember = "order_details";
            this.order_detailsBindingSource.DataSource = this.quanLyBanHangDataSet;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(1422, 70);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(136, 31);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Text = "Thêm SP";
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // date_allocatedDateTimePicker
            // 
            this.date_allocatedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.order_detailsBindingSource, "date_allocated", true));
            this.date_allocatedDateTimePicker.Location = new System.Drawing.Point(1257, 70);
            this.date_allocatedDateTimePicker.Name = "date_allocatedDateTimePicker";
            this.date_allocatedDateTimePicker.Size = new System.Drawing.Size(148, 31);
            this.date_allocatedDateTimePicker.TabIndex = 13;
            // 
            // order_detail_statusTextBox
            // 
            this.order_detail_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "order_detail_status", true));
            this.order_detail_statusTextBox.Location = new System.Drawing.Point(1020, 70);
            this.order_detail_statusTextBox.Name = "order_detail_statusTextBox";
            this.order_detail_statusTextBox.Size = new System.Drawing.Size(185, 31);
            this.order_detail_statusTextBox.TabIndex = 11;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(813, 70);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(148, 31);
            this.discountTextBox.TabIndex = 9;
            // 
            // unit_priceTextBox
            // 
            this.unit_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "unit_price", true));
            this.unit_priceTextBox.Location = new System.Drawing.Point(606, 70);
            this.unit_priceTextBox.Name = "unit_priceTextBox";
            this.unit_priceTextBox.Size = new System.Drawing.Size(148, 31);
            this.unit_priceTextBox.TabIndex = 7;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(401, 70);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(148, 31);
            this.quantityTextBox.TabIndex = 5;
            // 
            // product_idTextBox
            // 
            this.product_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "product_id", true));
            this.product_idTextBox.Location = new System.Drawing.Point(198, 70);
            this.product_idTextBox.Name = "product_idTextBox";
            this.product_idTextBox.Size = new System.Drawing.Size(148, 31);
            this.product_idTextBox.TabIndex = 3;
            // 
            // order_idTextBox
            // 
            this.order_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_detailsBindingSource, "order_id", true));
            this.order_idTextBox.Location = new System.Drawing.Point(12, 70);
            this.order_idTextBox.Name = "order_idTextBox";
            this.order_idTextBox.Size = new System.Drawing.Size(148, 31);
            this.order_idTextBox.TabIndex = 1;
            // 
            // order_detailsTableAdapter
            // 
            this.order_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(1600, 42);
            this.ordersBindingNavigator.TabIndex = 1;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1410, 932);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 51);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnLuudonhang
            // 
            this.btnLuudonhang.Location = new System.Drawing.Point(1218, 932);
            this.btnLuudonhang.Name = "btnLuudonhang";
            this.btnLuudonhang.Size = new System.Drawing.Size(161, 51);
            this.btnLuudonhang.TabIndex = 26;
            this.btnLuudonhang.Text = "Lưu ĐH";
            this.btnLuudonhang.UseVisualStyleBackColor = true;
            // 
            // btnXoadonhang
            // 
            this.btnXoadonhang.Location = new System.Drawing.Point(1019, 932);
            this.btnXoadonhang.Name = "btnXoadonhang";
            this.btnXoadonhang.Size = new System.Drawing.Size(161, 51);
            this.btnXoadonhang.TabIndex = 27;
            this.btnXoadonhang.Text = "Xóa ĐH";
            this.btnXoadonhang.UseVisualStyleBackColor = true;
            // 
            // btnSuadonhang
            // 
            this.btnSuadonhang.Location = new System.Drawing.Point(818, 932);
            this.btnSuadonhang.Name = "btnSuadonhang";
            this.btnSuadonhang.Size = new System.Drawing.Size(161, 51);
            this.btnSuadonhang.TabIndex = 28;
            this.btnSuadonhang.Text = "Sửa ĐH";
            this.btnSuadonhang.UseVisualStyleBackColor = true;
            this.btnSuadonhang.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemdonhang
            // 
            this.btnThemdonhang.Location = new System.Drawing.Point(567, 932);
            this.btnThemdonhang.Name = "btnThemdonhang";
            this.btnThemdonhang.Size = new System.Drawing.Size(216, 51);
            this.btnThemdonhang.TabIndex = 29;
            this.btnThemdonhang.Text = "Thêm đơn hàng";
            this.btnThemdonhang.UseVisualStyleBackColor = true;
            // 
            // FrmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1004);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuudonhang);
            this.Controls.Add(this.btnXoadonhang);
            this.Controls.Add(this.btnSuadonhang);
            this.Controls.Add(this.btnThemdonhang);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Controls.Add(this.gbThongtinchitietdonhang);
            this.Controls.Add(this.gbThongtindonhang);
            this.Name = "FrmDatHang";
            this.Text = "FormDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDatHang_Load);
            this.gbThongtindonhang.ResumeLayout(false);
            this.gbThongtindonhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet)).EndInit();
            this.gbThongtinchitietdonhang.ResumeLayout(false);
            this.gbThongtinchitietdonhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongtindonhang;
        private System.Windows.Forms.GroupBox gbThongtinchitietdonhang;
        private QuanLyBanHangDataSet quanLyBanHangDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox order_statusTextBox;
        private System.Windows.Forms.DateTimePicker paid_dateDateTimePicker;
        private System.Windows.Forms.TextBox payment_typeTextBox;
        private System.Windows.Forms.TextBox ship_countryTextBox;
        private System.Windows.Forms.TextBox ship_postal_codeTextBox;
        private System.Windows.Forms.TextBox shipping_feeTextBox;
        private System.Windows.Forms.TextBox ship_stateTextBox;
        private System.Windows.Forms.TextBox ship_cityTextBox;
        private System.Windows.Forms.TextBox ship_address2TextBox;
        private System.Windows.Forms.TextBox ship_address1TextBox;
        private System.Windows.Forms.TextBox ship_nameTextBox;
        private System.Windows.Forms.DateTimePicker shipped_dateDateTimePicker;
        private System.Windows.Forms.DateTimePicker order_dateDateTimePicker;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox employee_idTextBox;
        private QuanLyBanHangDataSetTableAdapters.order_detailsTableAdapter order_detailsTableAdapter;
        private System.Windows.Forms.BindingSource order_detailsBindingSource;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DateTimePicker date_allocatedDateTimePicker;
        private System.Windows.Forms.TextBox order_detail_statusTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox unit_priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox product_idTextBox;
        private System.Windows.Forms.TextBox order_idTextBox;
        private System.Windows.Forms.DataGridView order_detailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuudonhang;
        private System.Windows.Forms.Button btnXoadonhang;
        private System.Windows.Forms.Button btnSuadonhang;
        private System.Windows.Forms.Button btnThemdonhang;
    }
}