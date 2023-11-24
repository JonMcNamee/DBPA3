namespace McNameeLab3
{
    partial class frmKitchenSupply
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpOrderItems = new System.Windows.Forms.GroupBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpOrderManagement = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddRemove = new System.Windows.Forms.Button();
            this.lblSelectedOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picRandomPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabOrders = new System.Windows.Forms.TabPage();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.orderIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabServices = new System.Windows.Forms.TabPage();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.serviceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).BeginInit();
            this.grpOrderItems.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpOrderManagement.SuspendLayout();
            this.grpOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRandomPictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.AutoGenerateColumns = false;
            this.dgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.orderIdDataGridViewTextBoxColumn1,
            this.productIdDataGridViewTextBoxColumn2,
            this.serviceIdDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.priceDataGridViewTextBoxColumn2});
            this.dgvOrderItems.DataSource = this.orderItemBindingSource;
            this.dgvOrderItems.Location = new System.Drawing.Point(8, 14);
            this.dgvOrderItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.RowHeadersWidth = 51;
            this.dgvOrderItems.RowTemplate.Height = 29;
            this.dgvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderItems.Size = new System.Drawing.Size(806, 257);
            this.dgvOrderItems.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LineId";
            this.dataGridViewTextBoxColumn2.HeaderText = "LineId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn1
            // 
            this.orderIdDataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn1.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn1.Name = "orderIdDataGridViewTextBoxColumn1";
            this.orderIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn2
            // 
            this.productIdDataGridViewTextBoxColumn2.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn2.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn2.Name = "productIdDataGridViewTextBoxColumn2";
            this.productIdDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // serviceIdDataGridViewTextBoxColumn1
            // 
            this.serviceIdDataGridViewTextBoxColumn1.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn1.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn1.Name = "serviceIdDataGridViewTextBoxColumn1";
            this.serviceIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn2
            // 
            this.priceDataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn2.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn2.Name = "priceDataGridViewTextBoxColumn2";
            this.priceDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // orderItemBindingSource
            // 
            this.orderItemBindingSource.DataSource = typeof(McNameeLab3.Models.OrderItem);
            // 
            // grpOrderItems
            // 
            this.grpOrderItems.Controls.Add(this.dgvOrderItems);
            this.grpOrderItems.Location = new System.Drawing.Point(14, 332);
            this.grpOrderItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderItems.Name = "grpOrderItems";
            this.grpOrderItems.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderItems.Size = new System.Drawing.Size(819, 276);
            this.grpOrderItems.TabIndex = 1;
            this.grpOrderItems.TabStop = false;
            this.grpOrderItems.Text = "Order Items";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Location = new System.Drawing.Point(851, 31);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.Size = new System.Drawing.Size(274, 70);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(5, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(264, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpOrderManagement
            // 
            this.grpOrderManagement.Controls.Add(this.btnDelete);
            this.grpOrderManagement.Controls.Add(this.btnCreateOrder);
            this.grpOrderManagement.Controls.Add(this.lblSelectedItem);
            this.grpOrderManagement.Controls.Add(this.label2);
            this.grpOrderManagement.Controls.Add(this.btnAddRemove);
            this.grpOrderManagement.Controls.Add(this.lblSelectedOrder);
            this.grpOrderManagement.Controls.Add(this.label1);
            this.grpOrderManagement.Location = new System.Drawing.Point(851, 105);
            this.grpOrderManagement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderManagement.Name = "grpOrderManagement";
            this.grpOrderManagement.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderManagement.Size = new System.Drawing.Size(274, 220);
            this.grpOrderManagement.TabIndex = 3;
            this.grpOrderManagement.TabStop = false;
            this.grpOrderManagement.Text = "Order Management";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(5, 172);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(263, 43);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(5, 80);
            this.btnCreateOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(263, 43);
            this.btnCreateOrder.TabIndex = 5;
            this.btnCreateOrder.Text = "Create Order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedItem.Location = new System.Drawing.Point(108, 46);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(161, 19);
            this.lblSelectedItem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Item:";
            // 
            // btnAddRemove
            // 
            this.btnAddRemove.Location = new System.Drawing.Point(5, 126);
            this.btnAddRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRemove.Name = "btnAddRemove";
            this.btnAddRemove.Size = new System.Drawing.Size(263, 43);
            this.btnAddRemove.TabIndex = 2;
            this.btnAddRemove.Text = "Add/Remove Items";
            this.btnAddRemove.UseVisualStyleBackColor = true;
            this.btnAddRemove.Click += new System.EventHandler(this.btnAddRemove_Click);
            // 
            // lblSelectedOrder
            // 
            this.lblSelectedOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelectedOrder.Location = new System.Drawing.Point(108, 25);
            this.lblSelectedOrder.Name = "lblSelectedOrder";
            this.lblSelectedOrder.Size = new System.Drawing.Size(161, 19);
            this.lblSelectedOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Order:";
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.lblTotal);
            this.grpOrderDetails.Controls.Add(this.lblTax);
            this.grpOrderDetails.Controls.Add(this.lblSubtotal);
            this.grpOrderDetails.Controls.Add(this.lblNumItems);
            this.grpOrderDetails.Controls.Add(this.lblCustomer);
            this.grpOrderDetails.Controls.Add(this.label8);
            this.grpOrderDetails.Controls.Add(this.label7);
            this.grpOrderDetails.Controls.Add(this.label6);
            this.grpOrderDetails.Controls.Add(this.label5);
            this.grpOrderDetails.Controls.Add(this.label4);
            this.grpOrderDetails.Location = new System.Drawing.Point(851, 332);
            this.grpOrderDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpOrderDetails.Size = new System.Drawing.Size(274, 143);
            this.grpOrderDetails.TabIndex = 4;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "Order Details";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(121, 117);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(148, 19);
            this.lblTotal.TabIndex = 9;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(121, 95);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(148, 19);
            this.lblTax.TabIndex = 8;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Location = new System.Drawing.Point(121, 74);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(148, 19);
            this.lblSubtotal.TabIndex = 7;
            // 
            // lblNumItems
            // 
            this.lblNumItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumItems.Location = new System.Drawing.Point(121, 52);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(148, 19);
            this.lblNumItems.TabIndex = 6;
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomer.Location = new System.Drawing.Point(121, 29);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(148, 19);
            this.lblCustomer.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Customer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sub-Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of Items:";
            // 
            // picRandomPictureBox
            // 
            this.picRandomPictureBox.Location = new System.Drawing.Point(851, 480);
            this.picRandomPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRandomPictureBox.Name = "picRandomPictureBox";
            this.picRandomPictureBox.Size = new System.Drawing.Size(269, 124);
            this.picRandomPictureBox.TabIndex = 5;
            this.picRandomPictureBox.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabOrders);
            this.tabControl.Controls.Add(this.tabProducts);
            this.tabControl.Controls.Add(this.tabServices);
            this.tabControl.Location = new System.Drawing.Point(14, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(819, 315);
            this.tabControl.TabIndex = 6;
            // 
            // tabOrders
            // 
            this.tabOrders.Controls.Add(this.dgvOrders);
            this.tabOrders.Location = new System.Drawing.Point(4, 24);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrders.Size = new System.Drawing.Size(811, 287);
            this.tabOrders.TabIndex = 0;
            this.tabOrders.Text = "Orders";
            this.tabOrders.UseVisualStyleBackColor = true;
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIdDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn});
            this.dgvOrders.DataSource = this.orderBindingSource;
            this.dgvOrders.Location = new System.Drawing.Point(0, 3);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowTemplate.Height = 25;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(805, 278);
            this.dgvOrders.TabIndex = 0;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            this.orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            this.orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(McNameeLab3.Models.Order);
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.dgvProducts);
            this.tabProducts.Location = new System.Drawing.Point(4, 24);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(811, 287);
            this.tabProducts.TabIndex = 1;
            this.tabProducts.Text = "Products";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityInStockDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvProducts.DataSource = this.productBindingSource;
            this.dgvProducts.Location = new System.Drawing.Point(4, 6);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(804, 281);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityInStockDataGridViewTextBoxColumn
            // 
            this.quantityInStockDataGridViewTextBoxColumn.DataPropertyName = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.HeaderText = "QuantityInStock";
            this.quantityInStockDataGridViewTextBoxColumn.Name = "quantityInStockDataGridViewTextBoxColumn";
            this.quantityInStockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(McNameeLab3.Models.Product);
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.dgvServices);
            this.tabServices.Location = new System.Drawing.Point(4, 24);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(811, 287);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "Services";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoGenerateColumns = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIdDataGridViewTextBoxColumn,
            this.serviceNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1});
            this.dgvServices.DataSource = this.serviceBindingSource;
            this.dgvServices.Location = new System.Drawing.Point(3, 3);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowTemplate.Height = 25;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(805, 281);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // serviceIdDataGridViewTextBoxColumn
            // 
            this.serviceIdDataGridViewTextBoxColumn.DataPropertyName = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.HeaderText = "ServiceId";
            this.serviceIdDataGridViewTextBoxColumn.Name = "serviceIdDataGridViewTextBoxColumn";
            this.serviceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serviceNameDataGridViewTextBoxColumn
            // 
            this.serviceNameDataGridViewTextBoxColumn.DataPropertyName = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.HeaderText = "ServiceName";
            this.serviceNameDataGridViewTextBoxColumn.Name = "serviceNameDataGridViewTextBoxColumn";
            this.serviceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(McNameeLab3.Models.Service);
            // 
            // frmKitchenSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 617);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.picRandomPictureBox);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.grpOrderManagement);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpOrderItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmKitchenSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitchen Supply by Jon McNamee";
            this.Load += new System.EventHandler(this.frmKitchenSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemBindingSource)).EndInit();
            this.grpOrderItems.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpOrderManagement.ResumeLayout(false);
            this.grpOrderManagement.PerformLayout();
            this.grpOrderDetails.ResumeLayout(false);
            this.grpOrderDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRandomPictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tabServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvOrderItems;
        private GroupBox grpOrderItems;
        private GroupBox grpSearch;
        private TextBox txtSearch;
        private GroupBox grpOrderManagement;
        private Label lblSelectedItem;
        private Label label2;
        private Button btnAddRemove;
        private Label lblSelectedOrder;
        private Label label1;
        private Button btnCreateOrder;
        private Button btnDelete;
        private GroupBox grpOrderDetails;
        private Label lblTotal;
        private Label lblTax;
        private Label lblSubtotal;
        private Label lblNumItems;
        private Label lblCustomer;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox picRandomPictureBox;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lineIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TabControl tabControl;
        private TabPage tabOrders;
        private TabPage tabProducts;
        private DataGridView dgvOrders;
        private DataGridView dgvProducts;
        private TabPage tabServices;
        private DataGridView dgvServices;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityInStockDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private BindingSource serviceBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn serviceIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn2;
        private BindingSource orderItemBindingSource;
    }
}