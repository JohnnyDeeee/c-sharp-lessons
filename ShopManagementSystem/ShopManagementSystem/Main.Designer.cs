namespace ShopManagementSystem
{
    partial class formMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tODOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripCreateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreateSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreateCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCreateCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.listShopItems = new BrightIdeasSoftware.ObjectListView();
            this.columnItemId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnItemName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnItemDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnItemPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnItemStock = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnItemCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStripListItem = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlLists = new System.Windows.Forms.TabControl();
            this.tabPageItems = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.listShopOrders = new BrightIdeasSoftware.ObjectListView();
            this.columnOrderId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnOrderCustomerId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnOrderDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageOrderrules = new System.Windows.Forms.TabPage();
            this.listShopOrderrules = new BrightIdeasSoftware.ObjectListView();
            this.columnOrderruleId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnOrderruleOrderId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnOrderruleItemId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageSuppliers = new System.Windows.Forms.TabPage();
            this.listShopSuppliers = new BrightIdeasSoftware.ObjectListView();
            this.columnSupplierId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnSupplierName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnSupplierAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnSupplierZipcode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.listShopCustomers = new BrightIdeasSoftware.ObjectListView();
            this.columnCustomerId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnCustomerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnCustomerAddress = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnCustomerZipcode = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnCustomerPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.listShopCategories = new BrightIdeasSoftware.ObjectListView();
            this.columnCategoryId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnCategoryName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnCategoryDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.shopmsDataSet = new ShopManagementSystem.shopmsDataSet();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemTableAdapter = new ShopManagementSystem.shopmsDataSetTableAdapters.ItemTableAdapter();
            this.showImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopItems)).BeginInit();
            this.contextMenuStripListItem.SuspendLayout();
            this.tabControlLists.SuspendLayout();
            this.tabPageItems.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopOrders)).BeginInit();
            this.tabPageOrderrules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopOrderrules)).BeginInit();
            this.tabPageSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopSuppliers)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopCustomers)).BeginInit();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSearch,
            this.toolStripCreateMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(910, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exportToolStripMenuItem.Text = "Export TODO";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tODOToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // tODOToolStripMenuItem
            // 
            this.tODOToolStripMenuItem.Name = "tODOToolStripMenuItem";
            this.tODOToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.tODOToolStripMenuItem.Text = "TODO";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "test"});
            this.toolStripSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(150, 23);
            this.toolStripSearch.Text = "Search...";
            this.toolStripSearch.ToolTipText = "Enter text here to search.";
            this.toolStripSearch.Enter += new System.EventHandler(this.toolStripSearch_Enter);
            this.toolStripSearch.TextChanged += new System.EventHandler(this.toolStripSearch_TextChanged);
            // 
            // toolStripCreateMenu
            // 
            this.toolStripCreateMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCreateItem,
            this.toolStripCreateOrder,
            this.toolStripCreateSupplier,
            this.toolStripCreateCustomer,
            this.toolStripCreateCategory});
            this.toolStripCreateMenu.Name = "toolStripCreateMenu";
            this.toolStripCreateMenu.Size = new System.Drawing.Size(53, 23);
            this.toolStripCreateMenu.Text = "Create";
            // 
            // toolStripCreateItem
            // 
            this.toolStripCreateItem.Name = "toolStripCreateItem";
            this.toolStripCreateItem.Size = new System.Drawing.Size(126, 22);
            this.toolStripCreateItem.Text = "Item";
            // 
            // toolStripCreateOrder
            // 
            this.toolStripCreateOrder.Name = "toolStripCreateOrder";
            this.toolStripCreateOrder.Size = new System.Drawing.Size(126, 22);
            this.toolStripCreateOrder.Text = "Order";
            // 
            // toolStripCreateSupplier
            // 
            this.toolStripCreateSupplier.Name = "toolStripCreateSupplier";
            this.toolStripCreateSupplier.Size = new System.Drawing.Size(126, 22);
            this.toolStripCreateSupplier.Text = "Supplier";
            // 
            // toolStripCreateCustomer
            // 
            this.toolStripCreateCustomer.Name = "toolStripCreateCustomer";
            this.toolStripCreateCustomer.Size = new System.Drawing.Size(126, 22);
            this.toolStripCreateCustomer.Text = "Customer";
            // 
            // toolStripCreateCategory
            // 
            this.toolStripCreateCategory.Name = "toolStripCreateCategory";
            this.toolStripCreateCategory.Size = new System.Drawing.Size(126, 22);
            this.toolStripCreateCategory.Text = "Category";
            // 
            // listShopItems
            // 
            this.listShopItems.AllColumns.Add(this.columnItemId);
            this.listShopItems.AllColumns.Add(this.columnItemName);
            this.listShopItems.AllColumns.Add(this.columnItemDescription);
            this.listShopItems.AllColumns.Add(this.columnItemPrice);
            this.listShopItems.AllColumns.Add(this.columnItemStock);
            this.listShopItems.AllColumns.Add(this.columnItemCategory);
            this.listShopItems.AllowColumnReorder = true;
            this.listShopItems.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listShopItems.CellEditTabChangesRows = true;
            this.listShopItems.CellEditUseWholeCell = false;
            this.listShopItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItemId,
            this.columnItemName,
            this.columnItemDescription,
            this.columnItemPrice,
            this.columnItemStock,
            this.columnItemCategory});
            this.listShopItems.ContextMenuStrip = this.contextMenuStripListItem;
            this.listShopItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.listShopItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShopItems.FullRowSelect = true;
            this.listShopItems.Location = new System.Drawing.Point(3, 3);
            this.listShopItems.MultiSelect = false;
            this.listShopItems.Name = "listShopItems";
            this.listShopItems.ShowCommandMenuOnRightClick = true;
            this.listShopItems.ShowItemCountOnGroups = true;
            this.listShopItems.Size = new System.Drawing.Size(896, 494);
            this.listShopItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShopItems.TabIndex = 3;
            this.listShopItems.UseCompatibleStateImageBehavior = false;
            this.listShopItems.UseFilterIndicator = true;
            this.listShopItems.UseFiltering = true;
            this.listShopItems.UseHotItem = true;
            this.listShopItems.View = System.Windows.Forms.View.Details;
            // 
            // columnItemId
            // 
            this.columnItemId.AspectName = "Id";
            this.columnItemId.IsEditable = false;
            this.columnItemId.Text = "ID";
            // 
            // columnItemName
            // 
            this.columnItemName.AspectName = "Name";
            this.columnItemName.Text = "Name";
            this.columnItemName.UseInitialLetterForGroup = true;
            // 
            // columnItemDescription
            // 
            this.columnItemDescription.AspectName = "Description";
            this.columnItemDescription.Groupable = false;
            this.columnItemDescription.Text = "Description";
            this.columnItemDescription.Width = 86;
            // 
            // columnItemPrice
            // 
            this.columnItemPrice.AspectName = "Price";
            this.columnItemPrice.AspectToStringFormat = "{0:C}";
            this.columnItemPrice.AutoCompleteEditor = false;
            this.columnItemPrice.AutoCompleteEditorMode = System.Windows.Forms.AutoCompleteMode.None;
            this.columnItemPrice.Text = "Price";
            // 
            // columnItemStock
            // 
            this.columnItemStock.AspectName = "FormattedStock";
            this.columnItemStock.IsEditable = false;
            this.columnItemStock.Text = "Stock";
            // 
            // columnItemCategory
            // 
            this.columnItemCategory.AspectName = "CategoryName";
            this.columnItemCategory.Text = "Category";
            // 
            // contextMenuStripListItem
            // 
            this.contextMenuStripListItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.showImageToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.contextMenuStripListItem.Name = "contextMenuStripListItem";
            this.contextMenuStripListItem.Size = new System.Drawing.Size(153, 92);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            // 
            // tabControlLists
            // 
            this.tabControlLists.Controls.Add(this.tabPageItems);
            this.tabControlLists.Controls.Add(this.tabPageOrders);
            this.tabControlLists.Controls.Add(this.tabPageOrderrules);
            this.tabControlLists.Controls.Add(this.tabPageSuppliers);
            this.tabControlLists.Controls.Add(this.tabPageCustomers);
            this.tabControlLists.Controls.Add(this.tabPageCategories);
            this.tabControlLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLists.HotTrack = true;
            this.tabControlLists.Location = new System.Drawing.Point(0, 27);
            this.tabControlLists.Name = "tabControlLists";
            this.tabControlLists.SelectedIndex = 0;
            this.tabControlLists.Size = new System.Drawing.Size(910, 526);
            this.tabControlLists.TabIndex = 4;
            // 
            // tabPageItems
            // 
            this.tabPageItems.Controls.Add(this.listShopItems);
            this.tabPageItems.Location = new System.Drawing.Point(4, 22);
            this.tabPageItems.Name = "tabPageItems";
            this.tabPageItems.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageItems.Size = new System.Drawing.Size(902, 500);
            this.tabPageItems.TabIndex = 0;
            this.tabPageItems.Tag = "Item";
            this.tabPageItems.Text = "Items";
            this.tabPageItems.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Controls.Add(this.listShopOrders);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(902, 500);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Tag = "Order";
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // listShopOrders
            // 
            this.listShopOrders.AllColumns.Add(this.columnOrderId);
            this.listShopOrders.AllColumns.Add(this.columnOrderCustomerId);
            this.listShopOrders.AllColumns.Add(this.columnOrderDate);
            this.listShopOrders.AllowColumnReorder = true;
            this.listShopOrders.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listShopOrders.CellEditTabChangesRows = true;
            this.listShopOrders.CellEditUseWholeCell = false;
            this.listShopOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderId,
            this.columnOrderCustomerId,
            this.columnOrderDate});
            this.listShopOrders.ContextMenuStrip = this.contextMenuStripListItem;
            this.listShopOrders.Cursor = System.Windows.Forms.Cursors.Default;
            this.listShopOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShopOrders.FullRowSelect = true;
            this.listShopOrders.Location = new System.Drawing.Point(3, 3);
            this.listShopOrders.MultiSelect = false;
            this.listShopOrders.Name = "listShopOrders";
            this.listShopOrders.ShowCommandMenuOnRightClick = true;
            this.listShopOrders.ShowItemCountOnGroups = true;
            this.listShopOrders.Size = new System.Drawing.Size(896, 494);
            this.listShopOrders.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShopOrders.TabIndex = 4;
            this.listShopOrders.UseCompatibleStateImageBehavior = false;
            this.listShopOrders.UseFilterIndicator = true;
            this.listShopOrders.UseFiltering = true;
            this.listShopOrders.UseHotItem = true;
            this.listShopOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnOrderId
            // 
            this.columnOrderId.AspectName = "Id";
            this.columnOrderId.IsEditable = false;
            this.columnOrderId.Text = "ID";
            this.columnOrderId.Width = 50;
            // 
            // columnOrderCustomerId
            // 
            this.columnOrderCustomerId.AspectName = "Customer_Id";
            this.columnOrderCustomerId.Text = "Customer ID";
            this.columnOrderCustomerId.Width = 84;
            // 
            // columnOrderDate
            // 
            this.columnOrderDate.AspectName = "Date";
            this.columnOrderDate.Text = "Date";
            this.columnOrderDate.Width = 102;
            // 
            // tabPageOrderrules
            // 
            this.tabPageOrderrules.Controls.Add(this.listShopOrderrules);
            this.tabPageOrderrules.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrderrules.Name = "tabPageOrderrules";
            this.tabPageOrderrules.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrderrules.Size = new System.Drawing.Size(902, 500);
            this.tabPageOrderrules.TabIndex = 5;
            this.tabPageOrderrules.Tag = "Orderrule";
            this.tabPageOrderrules.Text = "Orderrules";
            this.tabPageOrderrules.UseVisualStyleBackColor = true;
            // 
            // listShopOrderrules
            // 
            this.listShopOrderrules.AllColumns.Add(this.columnOrderruleId);
            this.listShopOrderrules.AllColumns.Add(this.columnOrderruleOrderId);
            this.listShopOrderrules.AllColumns.Add(this.columnOrderruleItemId);
            this.listShopOrderrules.AllowColumnReorder = true;
            this.listShopOrderrules.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listShopOrderrules.CellEditTabChangesRows = true;
            this.listShopOrderrules.CellEditUseWholeCell = false;
            this.listShopOrderrules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOrderruleId,
            this.columnOrderruleOrderId,
            this.columnOrderruleItemId});
            this.listShopOrderrules.ContextMenuStrip = this.contextMenuStripListItem;
            this.listShopOrderrules.Cursor = System.Windows.Forms.Cursors.Default;
            this.listShopOrderrules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShopOrderrules.FullRowSelect = true;
            this.listShopOrderrules.Location = new System.Drawing.Point(3, 3);
            this.listShopOrderrules.MultiSelect = false;
            this.listShopOrderrules.Name = "listShopOrderrules";
            this.listShopOrderrules.ShowCommandMenuOnRightClick = true;
            this.listShopOrderrules.ShowItemCountOnGroups = true;
            this.listShopOrderrules.Size = new System.Drawing.Size(896, 494);
            this.listShopOrderrules.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShopOrderrules.TabIndex = 5;
            this.listShopOrderrules.UseCompatibleStateImageBehavior = false;
            this.listShopOrderrules.UseFilterIndicator = true;
            this.listShopOrderrules.UseFiltering = true;
            this.listShopOrderrules.UseHotItem = true;
            this.listShopOrderrules.View = System.Windows.Forms.View.Details;
            // 
            // columnOrderruleId
            // 
            this.columnOrderruleId.AspectName = "Id";
            this.columnOrderruleId.IsEditable = false;
            this.columnOrderruleId.Text = "ID";
            this.columnOrderruleId.Width = 50;
            // 
            // columnOrderruleOrderId
            // 
            this.columnOrderruleOrderId.AspectName = "Order_Id";
            this.columnOrderruleOrderId.Text = "Order ID";
            this.columnOrderruleOrderId.Width = 102;
            // 
            // columnOrderruleItemId
            // 
            this.columnOrderruleItemId.AspectName = "Item_Id";
            this.columnOrderruleItemId.Text = "Item ID";
            this.columnOrderruleItemId.Width = 84;
            // 
            // tabPageSuppliers
            // 
            this.tabPageSuppliers.Controls.Add(this.listShopSuppliers);
            this.tabPageSuppliers.Location = new System.Drawing.Point(4, 22);
            this.tabPageSuppliers.Name = "tabPageSuppliers";
            this.tabPageSuppliers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSuppliers.Size = new System.Drawing.Size(902, 500);
            this.tabPageSuppliers.TabIndex = 2;
            this.tabPageSuppliers.Tag = "Supplier";
            this.tabPageSuppliers.Text = "Suppliers";
            this.tabPageSuppliers.UseVisualStyleBackColor = true;
            // 
            // listShopSuppliers
            // 
            this.listShopSuppliers.AllColumns.Add(this.columnSupplierId);
            this.listShopSuppliers.AllColumns.Add(this.columnSupplierName);
            this.listShopSuppliers.AllColumns.Add(this.columnSupplierAddress);
            this.listShopSuppliers.AllColumns.Add(this.columnSupplierZipcode);
            this.listShopSuppliers.AllowColumnReorder = true;
            this.listShopSuppliers.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listShopSuppliers.CellEditTabChangesRows = true;
            this.listShopSuppliers.CellEditUseWholeCell = false;
            this.listShopSuppliers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSupplierId,
            this.columnSupplierName,
            this.columnSupplierAddress,
            this.columnSupplierZipcode});
            this.listShopSuppliers.ContextMenuStrip = this.contextMenuStripListItem;
            this.listShopSuppliers.Cursor = System.Windows.Forms.Cursors.Default;
            this.listShopSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShopSuppliers.FullRowSelect = true;
            this.listShopSuppliers.Location = new System.Drawing.Point(3, 3);
            this.listShopSuppliers.MultiSelect = false;
            this.listShopSuppliers.Name = "listShopSuppliers";
            this.listShopSuppliers.ShowCommandMenuOnRightClick = true;
            this.listShopSuppliers.ShowItemCountOnGroups = true;
            this.listShopSuppliers.Size = new System.Drawing.Size(896, 494);
            this.listShopSuppliers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShopSuppliers.TabIndex = 5;
            this.listShopSuppliers.UseCompatibleStateImageBehavior = false;
            this.listShopSuppliers.UseFilterIndicator = true;
            this.listShopSuppliers.UseFiltering = true;
            this.listShopSuppliers.UseHotItem = true;
            this.listShopSuppliers.View = System.Windows.Forms.View.Details;
            // 
            // columnSupplierId
            // 
            this.columnSupplierId.AspectName = "Id";
            this.columnSupplierId.IsEditable = false;
            this.columnSupplierId.Text = "ID";
            // 
            // columnSupplierName
            // 
            this.columnSupplierName.AspectName = "Name";
            this.columnSupplierName.Text = "Name";
            // 
            // columnSupplierAddress
            // 
            this.columnSupplierAddress.AspectName = "Address";
            this.columnSupplierAddress.Text = "Address";
            // 
            // columnSupplierZipcode
            // 
            this.columnSupplierZipcode.AspectName = "Zipcode";
            this.columnSupplierZipcode.Text = "Zipcode";
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.Controls.Add(this.listShopCustomers);
            this.tabPageCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabPageCustomers.Name = "tabPageCustomers";
            this.tabPageCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCustomers.Size = new System.Drawing.Size(902, 500);
            this.tabPageCustomers.TabIndex = 3;
            this.tabPageCustomers.Tag = "Customer";
            this.tabPageCustomers.Text = "Customers";
            this.tabPageCustomers.UseVisualStyleBackColor = true;
            // 
            // listShopCustomers
            // 
            this.listShopCustomers.AllColumns.Add(this.columnCustomerId);
            this.listShopCustomers.AllColumns.Add(this.columnCustomerName);
            this.listShopCustomers.AllColumns.Add(this.columnCustomerAddress);
            this.listShopCustomers.AllColumns.Add(this.columnCustomerZipcode);
            this.listShopCustomers.AllColumns.Add(this.columnCustomerPhone);
            this.listShopCustomers.AllowColumnReorder = true;
            this.listShopCustomers.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listShopCustomers.CellEditTabChangesRows = true;
            this.listShopCustomers.CellEditUseWholeCell = false;
            this.listShopCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCustomerId,
            this.columnCustomerName,
            this.columnCustomerAddress,
            this.columnCustomerZipcode,
            this.columnCustomerPhone});
            this.listShopCustomers.ContextMenuStrip = this.contextMenuStripListItem;
            this.listShopCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.listShopCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShopCustomers.FullRowSelect = true;
            this.listShopCustomers.Location = new System.Drawing.Point(3, 3);
            this.listShopCustomers.MultiSelect = false;
            this.listShopCustomers.Name = "listShopCustomers";
            this.listShopCustomers.ShowCommandMenuOnRightClick = true;
            this.listShopCustomers.ShowItemCountOnGroups = true;
            this.listShopCustomers.Size = new System.Drawing.Size(896, 494);
            this.listShopCustomers.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShopCustomers.TabIndex = 5;
            this.listShopCustomers.UseCompatibleStateImageBehavior = false;
            this.listShopCustomers.UseFilterIndicator = true;
            this.listShopCustomers.UseFiltering = true;
            this.listShopCustomers.UseHotItem = true;
            this.listShopCustomers.View = System.Windows.Forms.View.Details;
            // 
            // columnCustomerId
            // 
            this.columnCustomerId.AspectName = "Id";
            this.columnCustomerId.IsEditable = false;
            this.columnCustomerId.Text = "ID";
            // 
            // columnCustomerName
            // 
            this.columnCustomerName.AspectName = "Name";
            this.columnCustomerName.Text = "Name";
            // 
            // columnCustomerAddress
            // 
            this.columnCustomerAddress.AspectName = "Address";
            this.columnCustomerAddress.Text = "Address";
            // 
            // columnCustomerZipcode
            // 
            this.columnCustomerZipcode.AspectName = "Zipcode";
            this.columnCustomerZipcode.Text = "Zipcode";
            // 
            // columnCustomerPhone
            // 
            this.columnCustomerPhone.AspectName = "Phone";
            this.columnCustomerPhone.Text = "Phone";
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.listShopCategories);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(902, 500);
            this.tabPageCategories.TabIndex = 4;
            this.tabPageCategories.Tag = "Category";
            this.tabPageCategories.Text = "Categories";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // listShopCategories
            // 
            this.listShopCategories.AllColumns.Add(this.columnCategoryId);
            this.listShopCategories.AllColumns.Add(this.columnCategoryName);
            this.listShopCategories.AllColumns.Add(this.columnCategoryDescription);
            this.listShopCategories.AllowColumnReorder = true;
            this.listShopCategories.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listShopCategories.CellEditTabChangesRows = true;
            this.listShopCategories.CellEditUseWholeCell = false;
            this.listShopCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCategoryId,
            this.columnCategoryName,
            this.columnCategoryDescription});
            this.listShopCategories.ContextMenuStrip = this.contextMenuStripListItem;
            this.listShopCategories.Cursor = System.Windows.Forms.Cursors.Default;
            this.listShopCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShopCategories.FullRowSelect = true;
            this.listShopCategories.Location = new System.Drawing.Point(3, 3);
            this.listShopCategories.MultiSelect = false;
            this.listShopCategories.Name = "listShopCategories";
            this.listShopCategories.ShowCommandMenuOnRightClick = true;
            this.listShopCategories.ShowItemCountOnGroups = true;
            this.listShopCategories.Size = new System.Drawing.Size(896, 494);
            this.listShopCategories.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShopCategories.TabIndex = 5;
            this.listShopCategories.UseCompatibleStateImageBehavior = false;
            this.listShopCategories.UseFilterIndicator = true;
            this.listShopCategories.UseFiltering = true;
            this.listShopCategories.UseHotItem = true;
            this.listShopCategories.View = System.Windows.Forms.View.Details;
            // 
            // columnCategoryId
            // 
            this.columnCategoryId.AspectName = "Id";
            this.columnCategoryId.IsEditable = false;
            this.columnCategoryId.Text = "ID";
            // 
            // columnCategoryName
            // 
            this.columnCategoryName.AspectName = "Name";
            this.columnCategoryName.Text = "Name";
            this.columnCategoryName.Width = 110;
            // 
            // columnCategoryDescription
            // 
            this.columnCategoryDescription.AspectName = "Description";
            this.columnCategoryDescription.Text = "Description";
            this.columnCategoryDescription.Width = 170;
            // 
            // shopmsDataSet
            // 
            this.shopmsDataSet.DataSetName = "shopmsDataSet";
            this.shopmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Item";
            this.itemBindingSource.DataSource = this.shopmsDataSet;
            // 
            // itemTableAdapter
            // 
            this.itemTableAdapter.ClearBeforeFill = true;
            // 
            // showImageToolStripMenuItem
            // 
            this.showImageToolStripMenuItem.Name = "showImageToolStripMenuItem";
            this.showImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showImageToolStripMenuItem.Text = "Show image";
            this.showImageToolStripMenuItem.Click += new System.EventHandler(this.showImageToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 553);
            this.Controls.Add(this.tabControlLists);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopItems)).EndInit();
            this.contextMenuStripListItem.ResumeLayout(false);
            this.tabControlLists.ResumeLayout(false);
            this.tabPageItems.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listShopOrders)).EndInit();
            this.tabPageOrderrules.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listShopOrderrules)).EndInit();
            this.tabPageSuppliers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listShopSuppliers)).EndInit();
            this.tabPageCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listShopCustomers)).EndInit();
            this.tabPageCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listShopCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private BrightIdeasSoftware.ObjectListView listShopItems;
        private BrightIdeasSoftware.OLVColumn columnItemName;
        private BrightIdeasSoftware.OLVColumn columnItemPrice;
        private BrightIdeasSoftware.OLVColumn columnItemDescription;
        private BrightIdeasSoftware.OLVColumn columnItemStock;
        private BrightIdeasSoftware.OLVColumn columnItemCategory;
        private System.Windows.Forms.ToolStripTextBox toolStripSearch;
        private System.Windows.Forms.TabControl tabControlLists;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageItems;
        private System.Windows.Forms.TabPage tabPageSuppliers;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageCategories;
        private shopmsDataSet shopmsDataSet;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private shopmsDataSetTableAdapters.ItemTableAdapter itemTableAdapter;
        private BrightIdeasSoftware.ObjectListView listShopOrders;
        private BrightIdeasSoftware.OLVColumn columnOrderCustomerId;
        private BrightIdeasSoftware.OLVColumn columnOrderDate;
        private BrightIdeasSoftware.OLVColumn columnOrderId;
        private BrightIdeasSoftware.OLVColumn columnItemId;
        private System.Windows.Forms.TabPage tabPageOrderrules;
        private BrightIdeasSoftware.ObjectListView listShopOrderrules;
        private BrightIdeasSoftware.OLVColumn columnOrderruleId;
        private BrightIdeasSoftware.OLVColumn columnOrderruleItemId;
        private BrightIdeasSoftware.OLVColumn columnOrderruleOrderId;
        private BrightIdeasSoftware.ObjectListView listShopSuppliers;
        private BrightIdeasSoftware.ObjectListView listShopCustomers;
        private BrightIdeasSoftware.ObjectListView listShopCategories;
        private BrightIdeasSoftware.OLVColumn columnSupplierId;
        private BrightIdeasSoftware.OLVColumn columnSupplierName;
        private BrightIdeasSoftware.OLVColumn columnSupplierAddress;
        private BrightIdeasSoftware.OLVColumn columnSupplierZipcode;
        private BrightIdeasSoftware.OLVColumn columnCustomerId;
        private BrightIdeasSoftware.OLVColumn columnCustomerName;
        private BrightIdeasSoftware.OLVColumn columnCustomerAddress;
        private BrightIdeasSoftware.OLVColumn columnCustomerZipcode;
        private BrightIdeasSoftware.OLVColumn columnCustomerPhone;
        private BrightIdeasSoftware.OLVColumn columnCategoryId;
        private BrightIdeasSoftware.OLVColumn columnCategoryName;
        private BrightIdeasSoftware.OLVColumn columnCategoryDescription;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateOrder;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateSupplier;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateCustomer;
        private System.Windows.Forms.ToolStripMenuItem toolStripCreateCategory;
        private System.Windows.Forms.ToolStripMenuItem tODOToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showImageToolStripMenuItem;
    }
}

