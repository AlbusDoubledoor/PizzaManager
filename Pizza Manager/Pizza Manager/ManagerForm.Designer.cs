namespace Pizza_Manager
{
    partial class ManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.OrderInfo = new System.Windows.Forms.DataGridView();
            this.onlineClientTextbox = new System.Windows.Forms.MaskedTextBox();
            this.OfficerListBox = new System.Windows.Forms.ListBox();
            this.RefreshProduct = new System.Windows.Forms.Button();
            this.DiscountTextBox = new System.Windows.Forms.MaskedTextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.UpdateDiscount = new System.Windows.Forms.Button();
            this.ProductListBox = new System.Windows.Forms.ListBox();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.ProductLabel = new System.Windows.Forms.Label();
            this.ActionTextBox = new System.Windows.Forms.TextBox();
            this.AddSaleList = new System.Windows.Forms.Button();
            this.OrderPlaceListbox = new System.Windows.Forms.ListBox();
            this.OnlineClientLabel = new System.Windows.Forms.Label();
            this.OrderPlaceLabel = new System.Windows.Forms.Label();
            this.ProcessOfficerLabel = new System.Windows.Forms.Label();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.RefreshOrderList = new System.Windows.Forms.Button();
            this.ChooseOrderButton = new System.Windows.Forms.Button();
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.SaleListView = new System.Windows.Forms.DataGridView();
            this.LossTab = new System.Windows.Forms.TabPage();
            this.LossInfo = new System.Windows.Forms.DataGridView();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextbox = new System.Windows.Forms.TextBox();
            this.AddLossToTicketButton = new System.Windows.Forms.Button();
            this.LossListView = new System.Windows.Forms.DataGridView();
            this.CostTextbox = new System.Windows.Forms.MaskedTextBox();
            this.losstypeListBox = new System.Windows.Forms.ListBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.LossTypeLabel = new System.Windows.Forms.Label();
            this.AddLossTicket = new System.Windows.Forms.Button();
            this.RefreshLossTickets = new System.Windows.Forms.Button();
            this.ChooseLossTicket = new System.Windows.Forms.Button();
            this.LossTicketListBox = new System.Windows.Forms.ListBox();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.NumberProductsTextbox = new System.Windows.Forms.MaskedTextBox();
            this.ProductBuyListBox = new System.Windows.Forms.ListBox();
            this.BuyProductButton = new System.Windows.Forms.Button();
            this.AvailableLabel = new System.Windows.Forms.Label();
            this.StoredLabel = new System.Windows.Forms.Label();
            this.AvailableProducts = new System.Windows.Forms.DataGridView();
            this.RefreshProductsButton = new System.Windows.Forms.Button();
            this.ProductOfficeStorage = new System.Windows.Forms.DataGridView();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ChangeUserButton = new System.Windows.Forms.Button();
            this.MainTabControl.SuspendLayout();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleListView)).BeginInit();
            this.LossTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LossInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LossListView)).BeginInit();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOfficeStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.OrdersTab);
            this.MainTabControl.Controls.Add(this.LossTab);
            this.MainTabControl.Controls.Add(this.ProductsTab);
            this.MainTabControl.Location = new System.Drawing.Point(4, 3);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(906, 525);
            this.MainTabControl.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.BackColor = System.Drawing.Color.Ivory;
            this.OrdersTab.Controls.Add(this.OrderInfo);
            this.OrdersTab.Controls.Add(this.onlineClientTextbox);
            this.OrdersTab.Controls.Add(this.OfficerListBox);
            this.OrdersTab.Controls.Add(this.RefreshProduct);
            this.OrdersTab.Controls.Add(this.DiscountTextBox);
            this.OrdersTab.Controls.Add(this.DiscountLabel);
            this.OrdersTab.Controls.Add(this.UpdateDiscount);
            this.OrdersTab.Controls.Add(this.ProductListBox);
            this.OrdersTab.Controls.Add(this.ActionLabel);
            this.OrdersTab.Controls.Add(this.ProductLabel);
            this.OrdersTab.Controls.Add(this.ActionTextBox);
            this.OrdersTab.Controls.Add(this.AddSaleList);
            this.OrdersTab.Controls.Add(this.OrderPlaceListbox);
            this.OrdersTab.Controls.Add(this.OnlineClientLabel);
            this.OrdersTab.Controls.Add(this.OrderPlaceLabel);
            this.OrdersTab.Controls.Add(this.ProcessOfficerLabel);
            this.OrdersTab.Controls.Add(this.AddOrderButton);
            this.OrdersTab.Controls.Add(this.RefreshOrderList);
            this.OrdersTab.Controls.Add(this.ChooseOrderButton);
            this.OrdersTab.Controls.Add(this.OrderListBox);
            this.OrdersTab.Controls.Add(this.SaleListView);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(898, 499);
            this.OrdersTab.TabIndex = 0;
            this.OrdersTab.Text = "Заказы";
            // 
            // OrderInfo
            // 
            this.OrderInfo.AllowUserToAddRows = false;
            this.OrderInfo.AllowUserToDeleteRows = false;
            this.OrderInfo.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.OrderInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderInfo.BackgroundColor = System.Drawing.Color.Ivory;
            this.OrderInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.OrderInfo.ColumnHeadersHeight = 30;
            this.OrderInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.OrderInfo.GridColor = System.Drawing.Color.Black;
            this.OrderInfo.Location = new System.Drawing.Point(410, 6);
            this.OrderInfo.Name = "OrderInfo";
            this.OrderInfo.ReadOnly = true;
            this.OrderInfo.RowHeadersVisible = false;
            this.OrderInfo.RowTemplate.Height = 40;
            this.OrderInfo.RowTemplate.ReadOnly = true;
            this.OrderInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderInfo.ShowEditingIcon = false;
            this.OrderInfo.Size = new System.Drawing.Size(479, 125);
            this.OrderInfo.TabIndex = 28;
            // 
            // onlineClientTextbox
            // 
            this.onlineClientTextbox.Location = new System.Drawing.Point(95, 373);
            this.onlineClientTextbox.Mask = "0000";
            this.onlineClientTextbox.Name = "onlineClientTextbox";
            this.onlineClientTextbox.Size = new System.Drawing.Size(108, 20);
            this.onlineClientTextbox.TabIndex = 27;
            this.onlineClientTextbox.ValidatingType = typeof(int);
            // 
            // OfficerListBox
            // 
            this.OfficerListBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.OfficerListBox.FormattingEnabled = true;
            this.OfficerListBox.ItemHeight = 19;
            this.OfficerListBox.Location = new System.Drawing.Point(95, 300);
            this.OfficerListBox.Name = "OfficerListBox";
            this.OfficerListBox.Size = new System.Drawing.Size(108, 23);
            this.OfficerListBox.TabIndex = 26;
            // 
            // RefreshProduct
            // 
            this.RefreshProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RefreshProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshProduct.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.RefreshProduct.ForeColor = System.Drawing.Color.White;
            this.RefreshProduct.Location = new System.Drawing.Point(507, 399);
            this.RefreshProduct.Name = "RefreshProduct";
            this.RefreshProduct.Size = new System.Drawing.Size(127, 94);
            this.RefreshProduct.TabIndex = 25;
            this.RefreshProduct.Text = "Обновить список продуктов";
            this.RefreshProduct.UseVisualStyleBackColor = false;
            this.RefreshProduct.Click += new System.EventHandler(this.RefreshProduct_Click);
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(727, 370);
            this.DiscountTextBox.Mask = "0000000000.00";
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(162, 20);
            this.DiscountTextBox.TabIndex = 24;
            this.DiscountTextBox.ValidatingType = typeof(int);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Location = new System.Drawing.Point(677, 370);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(44, 13);
            this.DiscountLabel.TabIndex = 23;
            this.DiscountLabel.Text = "Скидка";
            // 
            // UpdateDiscount
            // 
            this.UpdateDiscount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.UpdateDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateDiscount.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.UpdateDiscount.ForeColor = System.Drawing.Color.White;
            this.UpdateDiscount.Location = new System.Drawing.Point(681, 399);
            this.UpdateDiscount.Name = "UpdateDiscount";
            this.UpdateDiscount.Size = new System.Drawing.Size(208, 94);
            this.UpdateDiscount.TabIndex = 22;
            this.UpdateDiscount.Text = "Обновить скидку";
            this.UpdateDiscount.UseVisualStyleBackColor = false;
            this.UpdateDiscount.Click += new System.EventHandler(this.UpdateDiscount_Click);
            // 
            // ProductListBox
            // 
            this.ProductListBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ProductListBox.FormattingEnabled = true;
            this.ProductListBox.ItemHeight = 19;
            this.ProductListBox.Location = new System.Drawing.Point(393, 307);
            this.ProductListBox.Name = "ProductListBox";
            this.ProductListBox.Size = new System.Drawing.Size(108, 42);
            this.ProductListBox.TabIndex = 21;
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Location = new System.Drawing.Point(304, 373);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(38, 13);
            this.ActionLabel.TabIndex = 20;
            this.ActionLabel.Text = "Акция";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.Location = new System.Drawing.Point(304, 310);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(49, 13);
            this.ProductLabel.TabIndex = 19;
            this.ProductLabel.Text = "Продукт";
            // 
            // ActionTextBox
            // 
            this.ActionTextBox.Location = new System.Drawing.Point(393, 373);
            this.ActionTextBox.Name = "ActionTextBox";
            this.ActionTextBox.Size = new System.Drawing.Size(108, 20);
            this.ActionTextBox.TabIndex = 17;
            // 
            // AddSaleList
            // 
            this.AddSaleList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddSaleList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddSaleList.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.AddSaleList.ForeColor = System.Drawing.Color.White;
            this.AddSaleList.Location = new System.Drawing.Point(307, 399);
            this.AddSaleList.Name = "AddSaleList";
            this.AddSaleList.Size = new System.Drawing.Size(194, 94);
            this.AddSaleList.TabIndex = 15;
            this.AddSaleList.Text = "Добавить позицию";
            this.AddSaleList.UseVisualStyleBackColor = false;
            this.AddSaleList.Click += new System.EventHandler(this.AddSaleList_Click);
            // 
            // OrderPlaceListbox
            // 
            this.OrderPlaceListbox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.OrderPlaceListbox.FormattingEnabled = true;
            this.OrderPlaceListbox.ItemHeight = 19;
            this.OrderPlaceListbox.Items.AddRange(new object[] {
            "В ресторане",
            "Онлайн"});
            this.OrderPlaceListbox.Location = new System.Drawing.Point(95, 337);
            this.OrderPlaceListbox.Name = "OrderPlaceListbox";
            this.OrderPlaceListbox.Size = new System.Drawing.Size(108, 23);
            this.OrderPlaceListbox.TabIndex = 14;
            // 
            // OnlineClientLabel
            // 
            this.OnlineClientLabel.AutoSize = true;
            this.OnlineClientLabel.Location = new System.Drawing.Point(6, 373);
            this.OnlineClientLabel.Name = "OnlineClientLabel";
            this.OnlineClientLabel.Size = new System.Drawing.Size(83, 13);
            this.OnlineClientLabel.TabIndex = 13;
            this.OnlineClientLabel.Text = "Онлайн-клиент";
            // 
            // OrderPlaceLabel
            // 
            this.OrderPlaceLabel.AutoSize = true;
            this.OrderPlaceLabel.Location = new System.Drawing.Point(6, 337);
            this.OrderPlaceLabel.Name = "OrderPlaceLabel";
            this.OrderPlaceLabel.Size = new System.Drawing.Size(78, 13);
            this.OrderPlaceLabel.TabIndex = 12;
            this.OrderPlaceLabel.Text = "Место заказа";
            // 
            // ProcessOfficerLabel
            // 
            this.ProcessOfficerLabel.AutoSize = true;
            this.ProcessOfficerLabel.Location = new System.Drawing.Point(6, 307);
            this.ProcessOfficerLabel.Name = "ProcessOfficerLabel";
            this.ProcessOfficerLabel.Size = new System.Drawing.Size(62, 13);
            this.ProcessOfficerLabel.TabIndex = 11;
            this.ProcessOfficerLabel.Text = "Обработал";
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddOrderButton.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.Location = new System.Drawing.Point(6, 399);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(197, 94);
            this.AddOrderButton.TabIndex = 7;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // RefreshOrderList
            // 
            this.RefreshOrderList.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RefreshOrderList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshOrderList.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.RefreshOrderList.ForeColor = System.Drawing.Color.White;
            this.RefreshOrderList.Location = new System.Drawing.Point(262, 6);
            this.RefreshOrderList.Name = "RefreshOrderList";
            this.RefreshOrderList.Size = new System.Drawing.Size(142, 125);
            this.RefreshOrderList.TabIndex = 6;
            this.RefreshOrderList.Text = "Обновить список заказов";
            this.RefreshOrderList.UseVisualStyleBackColor = false;
            this.RefreshOrderList.Click += new System.EventHandler(this.RefreshOrderList_Click);
            // 
            // ChooseOrderButton
            // 
            this.ChooseOrderButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ChooseOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseOrderButton.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.ChooseOrderButton.ForeColor = System.Drawing.Color.White;
            this.ChooseOrderButton.Location = new System.Drawing.Point(114, 6);
            this.ChooseOrderButton.Name = "ChooseOrderButton";
            this.ChooseOrderButton.Size = new System.Drawing.Size(142, 125);
            this.ChooseOrderButton.TabIndex = 5;
            this.ChooseOrderButton.Text = "Выбрать заказ";
            this.ChooseOrderButton.UseVisualStyleBackColor = false;
            this.ChooseOrderButton.Click += new System.EventHandler(this.ChooseOrderButton_Click);
            // 
            // OrderListBox
            // 
            this.OrderListBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.ItemHeight = 19;
            this.OrderListBox.Location = new System.Drawing.Point(6, 6);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(102, 118);
            this.OrderListBox.TabIndex = 2;
            // 
            // SaleListView
            // 
            this.SaleListView.AllowUserToAddRows = false;
            this.SaleListView.AllowUserToDeleteRows = false;
            this.SaleListView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.SaleListView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.SaleListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleListView.BackgroundColor = System.Drawing.Color.Ivory;
            this.SaleListView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.SaleListView.ColumnHeadersHeight = 40;
            this.SaleListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleListView.DefaultCellStyle = dataGridViewCellStyle4;
            this.SaleListView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.SaleListView.GridColor = System.Drawing.Color.Black;
            this.SaleListView.Location = new System.Drawing.Point(3, 137);
            this.SaleListView.Name = "SaleListView";
            this.SaleListView.ReadOnly = true;
            this.SaleListView.RowHeadersVisible = false;
            this.SaleListView.RowTemplate.Height = 70;
            this.SaleListView.RowTemplate.ReadOnly = true;
            this.SaleListView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SaleListView.ShowEditingIcon = false;
            this.SaleListView.Size = new System.Drawing.Size(886, 153);
            this.SaleListView.TabIndex = 1;
            // 
            // LossTab
            // 
            this.LossTab.BackColor = System.Drawing.Color.Ivory;
            this.LossTab.Controls.Add(this.LossInfo);
            this.LossTab.Controls.Add(this.DescriptionLabel);
            this.LossTab.Controls.Add(this.DescriptionTextbox);
            this.LossTab.Controls.Add(this.AddLossToTicketButton);
            this.LossTab.Controls.Add(this.LossListView);
            this.LossTab.Controls.Add(this.CostTextbox);
            this.LossTab.Controls.Add(this.losstypeListBox);
            this.LossTab.Controls.Add(this.CostLabel);
            this.LossTab.Controls.Add(this.LossTypeLabel);
            this.LossTab.Controls.Add(this.AddLossTicket);
            this.LossTab.Controls.Add(this.RefreshLossTickets);
            this.LossTab.Controls.Add(this.ChooseLossTicket);
            this.LossTab.Controls.Add(this.LossTicketListBox);
            this.LossTab.Location = new System.Drawing.Point(4, 22);
            this.LossTab.Name = "LossTab";
            this.LossTab.Padding = new System.Windows.Forms.Padding(3);
            this.LossTab.Size = new System.Drawing.Size(898, 499);
            this.LossTab.TabIndex = 1;
            this.LossTab.Text = "Расходы";
            // 
            // LossInfo
            // 
            this.LossInfo.AllowUserToAddRows = false;
            this.LossInfo.AllowUserToDeleteRows = false;
            this.LossInfo.AllowUserToResizeColumns = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.LossInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.LossInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LossInfo.BackgroundColor = System.Drawing.Color.Ivory;
            this.LossInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.LossInfo.ColumnHeadersHeight = 30;
            this.LossInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LossInfo.DefaultCellStyle = dataGridViewCellStyle6;
            this.LossInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.LossInfo.GridColor = System.Drawing.Color.Black;
            this.LossInfo.Location = new System.Drawing.Point(410, 6);
            this.LossInfo.Name = "LossInfo";
            this.LossInfo.ReadOnly = true;
            this.LossInfo.RowHeadersVisible = false;
            this.LossInfo.RowTemplate.Height = 40;
            this.LossInfo.RowTemplate.ReadOnly = true;
            this.LossInfo.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LossInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LossInfo.ShowEditingIcon = false;
            this.LossInfo.Size = new System.Drawing.Size(482, 118);
            this.LossInfo.TabIndex = 41;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(502, 409);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(57, 13);
            this.DescriptionLabel.TabIndex = 40;
            this.DescriptionLabel.Text = "Описание";
            // 
            // DescriptionTextbox
            // 
            this.DescriptionTextbox.Location = new System.Drawing.Point(505, 425);
            this.DescriptionTextbox.Multiline = true;
            this.DescriptionTextbox.Name = "DescriptionTextbox";
            this.DescriptionTextbox.Size = new System.Drawing.Size(184, 68);
            this.DescriptionTextbox.TabIndex = 39;
            this.DescriptionTextbox.Text = "\r\n\r\n";
            // 
            // AddLossToTicketButton
            // 
            this.AddLossToTicketButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddLossToTicketButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddLossToTicketButton.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.AddLossToTicketButton.ForeColor = System.Drawing.Color.White;
            this.AddLossToTicketButton.Location = new System.Drawing.Point(707, 397);
            this.AddLossToTicketButton.Name = "AddLossToTicketButton";
            this.AddLossToTicketButton.Size = new System.Drawing.Size(185, 96);
            this.AddLossToTicketButton.TabIndex = 33;
            this.AddLossToTicketButton.Text = "Добавить позицию";
            this.AddLossToTicketButton.UseVisualStyleBackColor = false;
            this.AddLossToTicketButton.Click += new System.EventHandler(this.AddLossToTicketButton_Click);
            // 
            // LossListView
            // 
            this.LossListView.AllowUserToAddRows = false;
            this.LossListView.AllowUserToDeleteRows = false;
            this.LossListView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.LossListView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.LossListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LossListView.BackgroundColor = System.Drawing.Color.Ivory;
            this.LossListView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.LossListView.ColumnHeadersHeight = 40;
            this.LossListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LossListView.DefaultCellStyle = dataGridViewCellStyle8;
            this.LossListView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.LossListView.GridColor = System.Drawing.Color.Black;
            this.LossListView.Location = new System.Drawing.Point(6, 145);
            this.LossListView.Name = "LossListView";
            this.LossListView.ReadOnly = true;
            this.LossListView.RowHeadersVisible = false;
            this.LossListView.RowTemplate.Height = 70;
            this.LossListView.RowTemplate.ReadOnly = true;
            this.LossListView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LossListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LossListView.ShowEditingIcon = false;
            this.LossListView.Size = new System.Drawing.Size(886, 239);
            this.LossListView.TabIndex = 22;
            // 
            // CostTextbox
            // 
            this.CostTextbox.Location = new System.Drawing.Point(316, 473);
            this.CostTextbox.Mask = "0000000000.00";
            this.CostTextbox.Name = "CostTextbox";
            this.CostTextbox.Size = new System.Drawing.Size(162, 20);
            this.CostTextbox.TabIndex = 38;
            this.CostTextbox.ValidatingType = typeof(int);
            // 
            // losstypeListBox
            // 
            this.losstypeListBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.losstypeListBox.FormattingEnabled = true;
            this.losstypeListBox.ItemHeight = 19;
            this.losstypeListBox.Items.AddRange(new object[] {
            "Закупка продуктов",
            "Зарплата",
            "Мероприятие",
            "Разбитая посуда",
            "Украденные блюда",
            "Прочие убытки"});
            this.losstypeListBox.Location = new System.Drawing.Point(316, 406);
            this.losstypeListBox.Name = "losstypeListBox";
            this.losstypeListBox.Size = new System.Drawing.Size(162, 61);
            this.losstypeListBox.TabIndex = 37;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(243, 476);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(62, 13);
            this.CostLabel.TabIndex = 36;
            this.CostLabel.Text = "Стоимость";
            // 
            // LossTypeLabel
            // 
            this.LossTypeLabel.AutoSize = true;
            this.LossTypeLabel.Location = new System.Drawing.Point(243, 406);
            this.LossTypeLabel.Name = "LossTypeLabel";
            this.LossTypeLabel.Size = new System.Drawing.Size(70, 13);
            this.LossTypeLabel.TabIndex = 35;
            this.LossTypeLabel.Text = "Тип расхода";
            // 
            // AddLossTicket
            // 
            this.AddLossTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddLossTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddLossTicket.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.AddLossTicket.ForeColor = System.Drawing.Color.White;
            this.AddLossTicket.Location = new System.Drawing.Point(6, 399);
            this.AddLossTicket.Name = "AddLossTicket";
            this.AddLossTicket.Size = new System.Drawing.Size(197, 94);
            this.AddLossTicket.TabIndex = 26;
            this.AddLossTicket.Text = "Добавить расход";
            this.AddLossTicket.UseVisualStyleBackColor = false;
            this.AddLossTicket.Click += new System.EventHandler(this.AddLossTicket_Click);
            // 
            // RefreshLossTickets
            // 
            this.RefreshLossTickets.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RefreshLossTickets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshLossTickets.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.RefreshLossTickets.ForeColor = System.Drawing.Color.White;
            this.RefreshLossTickets.Location = new System.Drawing.Point(262, 6);
            this.RefreshLossTickets.Name = "RefreshLossTickets";
            this.RefreshLossTickets.Size = new System.Drawing.Size(142, 118);
            this.RefreshLossTickets.TabIndex = 25;
            this.RefreshLossTickets.Text = "Обновить список расходов";
            this.RefreshLossTickets.UseVisualStyleBackColor = false;
            this.RefreshLossTickets.Click += new System.EventHandler(this.RefreshLossTickets_Click);
            // 
            // ChooseLossTicket
            // 
            this.ChooseLossTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ChooseLossTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChooseLossTicket.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.ChooseLossTicket.ForeColor = System.Drawing.Color.White;
            this.ChooseLossTicket.Location = new System.Drawing.Point(114, 6);
            this.ChooseLossTicket.Name = "ChooseLossTicket";
            this.ChooseLossTicket.Size = new System.Drawing.Size(142, 118);
            this.ChooseLossTicket.TabIndex = 24;
            this.ChooseLossTicket.Text = "Выбрать расход";
            this.ChooseLossTicket.UseVisualStyleBackColor = false;
            this.ChooseLossTicket.Click += new System.EventHandler(this.ChooseLossTicket_Click);
            // 
            // LossTicketListBox
            // 
            this.LossTicketListBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LossTicketListBox.FormattingEnabled = true;
            this.LossTicketListBox.ItemHeight = 19;
            this.LossTicketListBox.Location = new System.Drawing.Point(6, 6);
            this.LossTicketListBox.Name = "LossTicketListBox";
            this.LossTicketListBox.Size = new System.Drawing.Size(102, 118);
            this.LossTicketListBox.TabIndex = 23;
            // 
            // ProductsTab
            // 
            this.ProductsTab.BackColor = System.Drawing.Color.Ivory;
            this.ProductsTab.Controls.Add(this.NumberProductsTextbox);
            this.ProductsTab.Controls.Add(this.ProductBuyListBox);
            this.ProductsTab.Controls.Add(this.BuyProductButton);
            this.ProductsTab.Controls.Add(this.AvailableLabel);
            this.ProductsTab.Controls.Add(this.StoredLabel);
            this.ProductsTab.Controls.Add(this.AvailableProducts);
            this.ProductsTab.Controls.Add(this.RefreshProductsButton);
            this.ProductsTab.Controls.Add(this.ProductOfficeStorage);
            this.ProductsTab.Location = new System.Drawing.Point(4, 22);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Size = new System.Drawing.Size(898, 499);
            this.ProductsTab.TabIndex = 2;
            this.ProductsTab.Text = "Продукты";
            // 
            // NumberProductsTextbox
            // 
            this.NumberProductsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NumberProductsTextbox.Location = new System.Drawing.Point(275, 374);
            this.NumberProductsTextbox.Mask = "00000";
            this.NumberProductsTextbox.Name = "NumberProductsTextbox";
            this.NumberProductsTextbox.Size = new System.Drawing.Size(255, 32);
            this.NumberProductsTextbox.TabIndex = 29;
            this.NumberProductsTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductBuyListBox
            // 
            this.ProductBuyListBox.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.ProductBuyListBox.FormattingEnabled = true;
            this.ProductBuyListBox.ItemHeight = 21;
            this.ProductBuyListBox.Location = new System.Drawing.Point(275, 308);
            this.ProductBuyListBox.Name = "ProductBuyListBox";
            this.ProductBuyListBox.Size = new System.Drawing.Size(255, 46);
            this.ProductBuyListBox.TabIndex = 28;
            // 
            // BuyProductButton
            // 
            this.BuyProductButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BuyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BuyProductButton.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.BuyProductButton.ForeColor = System.Drawing.Color.White;
            this.BuyProductButton.Location = new System.Drawing.Point(275, 427);
            this.BuyProductButton.Name = "BuyProductButton";
            this.BuyProductButton.Size = new System.Drawing.Size(255, 47);
            this.BuyProductButton.TabIndex = 5;
            this.BuyProductButton.Text = "Закупить продукт";
            this.BuyProductButton.UseVisualStyleBackColor = false;
            this.BuyProductButton.Click += new System.EventHandler(this.BuyProductButton_Click);
            // 
            // AvailableLabel
            // 
            this.AvailableLabel.AutoSize = true;
            this.AvailableLabel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.AvailableLabel.Location = new System.Drawing.Point(429, 68);
            this.AvailableLabel.Name = "AvailableLabel";
            this.AvailableLabel.Size = new System.Drawing.Size(222, 25);
            this.AvailableLabel.TabIndex = 27;
            this.AvailableLabel.Text = "Доступные продукты:";
            // 
            // StoredLabel
            // 
            this.StoredLabel.AutoSize = true;
            this.StoredLabel.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.StoredLabel.Location = new System.Drawing.Point(4, 68);
            this.StoredLabel.Name = "StoredLabel";
            this.StoredLabel.Size = new System.Drawing.Size(265, 25);
            this.StoredLabel.TabIndex = 26;
            this.StoredLabel.Text = "Хранится на предприятии:";
            // 
            // AvailableProducts
            // 
            this.AvailableProducts.AllowUserToAddRows = false;
            this.AvailableProducts.AllowUserToDeleteRows = false;
            this.AvailableProducts.AllowUserToResizeColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.AvailableProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.AvailableProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AvailableProducts.BackgroundColor = System.Drawing.Color.Ivory;
            this.AvailableProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.AvailableProducts.ColumnHeadersHeight = 40;
            this.AvailableProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AvailableProducts.DefaultCellStyle = dataGridViewCellStyle10;
            this.AvailableProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AvailableProducts.GridColor = System.Drawing.Color.Black;
            this.AvailableProducts.Location = new System.Drawing.Point(415, 106);
            this.AvailableProducts.Name = "AvailableProducts";
            this.AvailableProducts.ReadOnly = true;
            this.AvailableProducts.RowHeadersVisible = false;
            this.AvailableProducts.RowTemplate.Height = 70;
            this.AvailableProducts.RowTemplate.ReadOnly = true;
            this.AvailableProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AvailableProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AvailableProducts.ShowEditingIcon = false;
            this.AvailableProducts.Size = new System.Drawing.Size(469, 184);
            this.AvailableProducts.TabIndex = 25;
            // 
            // RefreshProductsButton
            // 
            this.RefreshProductsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.RefreshProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RefreshProductsButton.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.RefreshProductsButton.ForeColor = System.Drawing.Color.White;
            this.RefreshProductsButton.Location = new System.Drawing.Point(275, 3);
            this.RefreshProductsButton.Name = "RefreshProductsButton";
            this.RefreshProductsButton.Size = new System.Drawing.Size(255, 47);
            this.RefreshProductsButton.TabIndex = 24;
            this.RefreshProductsButton.Text = "Обновить списки";
            this.RefreshProductsButton.UseVisualStyleBackColor = false;
            this.RefreshProductsButton.Click += new System.EventHandler(this.RefreshProductsButton_Click);
            // 
            // ProductOfficeStorage
            // 
            this.ProductOfficeStorage.AllowUserToAddRows = false;
            this.ProductOfficeStorage.AllowUserToDeleteRows = false;
            this.ProductOfficeStorage.AllowUserToResizeColumns = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ProductOfficeStorage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.ProductOfficeStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductOfficeStorage.BackgroundColor = System.Drawing.Color.Ivory;
            this.ProductOfficeStorage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ProductOfficeStorage.ColumnHeadersHeight = 40;
            this.ProductOfficeStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductOfficeStorage.DefaultCellStyle = dataGridViewCellStyle12;
            this.ProductOfficeStorage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ProductOfficeStorage.GridColor = System.Drawing.Color.Black;
            this.ProductOfficeStorage.Location = new System.Drawing.Point(4, 106);
            this.ProductOfficeStorage.Name = "ProductOfficeStorage";
            this.ProductOfficeStorage.ReadOnly = true;
            this.ProductOfficeStorage.RowHeadersVisible = false;
            this.ProductOfficeStorage.RowTemplate.Height = 70;
            this.ProductOfficeStorage.RowTemplate.ReadOnly = true;
            this.ProductOfficeStorage.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductOfficeStorage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductOfficeStorage.ShowEditingIcon = false;
            this.ProductOfficeStorage.Size = new System.Drawing.Size(405, 184);
            this.ProductOfficeStorage.TabIndex = 23;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(754, 534);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(156, 47);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ChangeUserButton
            // 
            this.ChangeUserButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ChangeUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChangeUserButton.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.ChangeUserButton.ForeColor = System.Drawing.Color.White;
            this.ChangeUserButton.Location = new System.Drawing.Point(488, 534);
            this.ChangeUserButton.Name = "ChangeUserButton";
            this.ChangeUserButton.Size = new System.Drawing.Size(255, 47);
            this.ChangeUserButton.TabIndex = 4;
            this.ChangeUserButton.Text = "Сменить пользователя";
            this.ChangeUserButton.UseVisualStyleBackColor = false;
            this.ChangeUserButton.Click += new System.EventHandler(this.ChangeUserButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(922, 593);
            this.Controls.Add(this.ChangeUserButton);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.ExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizza Manager (Сотрудник)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExitButton_Click);
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.OrdersTab.ResumeLayout(false);
            this.OrdersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleListView)).EndInit();
            this.LossTab.ResumeLayout(false);
            this.LossTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LossInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LossListView)).EndInit();
            this.ProductsTab.ResumeLayout(false);
            this.ProductsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvailableProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductOfficeStorage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.TabPage LossTab;
        private System.Windows.Forms.TabPage ProductsTab;
        private System.Windows.Forms.DataGridView SaleListView;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ChangeUserButton;
        private System.Windows.Forms.Button RefreshOrderList;
        private System.Windows.Forms.Button ChooseOrderButton;
        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.MaskedTextBox DiscountTextBox;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Button UpdateDiscount;
        private System.Windows.Forms.ListBox ProductListBox;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Label ProductLabel;
        private System.Windows.Forms.TextBox ActionTextBox;
        private System.Windows.Forms.Button AddSaleList;
        private System.Windows.Forms.ListBox OrderPlaceListbox;
        private System.Windows.Forms.Label OnlineClientLabel;
        private System.Windows.Forms.Label OrderPlaceLabel;
        private System.Windows.Forms.Label ProcessOfficerLabel;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.ListBox losstypeListBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label LossTypeLabel;
        private System.Windows.Forms.Button AddLossToTicketButton;
        private System.Windows.Forms.Button AddLossTicket;
        private System.Windows.Forms.Button RefreshLossTickets;
        private System.Windows.Forms.Button ChooseLossTicket;
        private System.Windows.Forms.ListBox LossTicketListBox;
        private System.Windows.Forms.DataGridView LossListView;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextbox;
        private System.Windows.Forms.MaskedTextBox CostTextbox;
        private System.Windows.Forms.Button RefreshProduct;
        private System.Windows.Forms.ListBox OfficerListBox;
        private System.Windows.Forms.MaskedTextBox onlineClientTextbox;
        private System.Windows.Forms.DataGridView OrderInfo;
        private System.Windows.Forms.DataGridView LossInfo;
        private System.Windows.Forms.DataGridView ProductOfficeStorage;
        private System.Windows.Forms.Button RefreshProductsButton;
        private System.Windows.Forms.Label AvailableLabel;
        private System.Windows.Forms.Label StoredLabel;
        private System.Windows.Forms.DataGridView AvailableProducts;
        private System.Windows.Forms.MaskedTextBox NumberProductsTextbox;
        private System.Windows.Forms.ListBox ProductBuyListBox;
        private System.Windows.Forms.Button BuyProductButton;
    }
}