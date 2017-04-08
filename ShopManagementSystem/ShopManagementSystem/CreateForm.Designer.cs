namespace ShopManagementSystem
{
    partial class CreateForm
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
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.panelSupplier = new System.Windows.Forms.Panel();
            this.panelOrder = new System.Windows.Forms.Panel();
            this.panelItem = new System.Windows.Forms.Panel();
            this.panelCategory = new System.Windows.Forms.Panel();
            this.labelCategoryName = new System.Windows.Forms.Label();
            this.textCategoryName = new System.Windows.Forms.TextBox();
            this.textCategoryDescription = new System.Windows.Forms.TextBox();
            this.labelCategoryDescription = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelOrderCustomerId = new System.Windows.Forms.Label();
            this.comboOrderCustomerIds = new System.Windows.Forms.ComboBox();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.dateOrderTimeDate = new System.Windows.Forms.DateTimePicker();
            this.labelOrderOrderrules = new System.Windows.Forms.Label();
            this.listOrderOrderrules = new BrightIdeasSoftware.ObjectListView();
            this.columnItemId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnItemAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonOrderAdd = new System.Windows.Forms.Button();
            this.buttonOrderRemove = new System.Windows.Forms.Button();
            this.labelItemName = new System.Windows.Forms.Label();
            this.textItemName = new System.Windows.Forms.TextBox();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.numItemPrice = new System.Windows.Forms.NumericUpDown();
            this.labelItemCategory = new System.Windows.Forms.Label();
            this.comboItemCategory = new System.Windows.Forms.ComboBox();
            this.labelItemDescription = new System.Windows.Forms.Label();
            this.textItemDescription = new System.Windows.Forms.TextBox();
            this.comboItemSupplier = new System.Windows.Forms.ComboBox();
            this.labelItemSupplier = new System.Windows.Forms.Label();
            this.numItemStock = new System.Windows.Forms.NumericUpDown();
            this.labelItemStock = new System.Windows.Forms.Label();
            this.labelSupplierName = new System.Windows.Forms.Label();
            this.textSupplierName = new System.Windows.Forms.TextBox();
            this.textSupplierAddress = new System.Windows.Forms.TextBox();
            this.labelSupplierAddress = new System.Windows.Forms.Label();
            this.textSupplierZipcode = new System.Windows.Forms.TextBox();
            this.labelSupplierZipcode = new System.Windows.Forms.Label();
            this.textCustomerZipcode = new System.Windows.Forms.TextBox();
            this.labelCustomerZipcode = new System.Windows.Forms.Label();
            this.textCustomerAddress = new System.Windows.Forms.TextBox();
            this.labelCujstomerAddress = new System.Windows.Forms.Label();
            this.textCustomerName = new System.Windows.Forms.TextBox();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.textCustomerPhone = new System.Windows.Forms.TextBox();
            this.labelCustomerPhone = new System.Windows.Forms.Label();
            this.panelCustomer.SuspendLayout();
            this.panelSupplier.SuspendLayout();
            this.panelOrder.SuspendLayout();
            this.panelItem.SuspendLayout();
            this.panelCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOrderOrderrules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCustomer
            // 
            this.panelCustomer.Controls.Add(this.textCustomerPhone);
            this.panelCustomer.Controls.Add(this.labelCustomerPhone);
            this.panelCustomer.Controls.Add(this.textCustomerZipcode);
            this.panelCustomer.Controls.Add(this.labelCustomerZipcode);
            this.panelCustomer.Controls.Add(this.textCustomerAddress);
            this.panelCustomer.Controls.Add(this.labelCujstomerAddress);
            this.panelCustomer.Controls.Add(this.textCustomerName);
            this.panelCustomer.Controls.Add(this.labelCustomerName);
            this.panelCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomer.Location = new System.Drawing.Point(0, 0);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(284, 261);
            this.panelCustomer.TabIndex = 2;
            // 
            // panelSupplier
            // 
            this.panelSupplier.Controls.Add(this.textSupplierZipcode);
            this.panelSupplier.Controls.Add(this.labelSupplierZipcode);
            this.panelSupplier.Controls.Add(this.textSupplierAddress);
            this.panelSupplier.Controls.Add(this.labelSupplierAddress);
            this.panelSupplier.Controls.Add(this.textSupplierName);
            this.panelSupplier.Controls.Add(this.labelSupplierName);
            this.panelSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSupplier.Location = new System.Drawing.Point(0, 0);
            this.panelSupplier.Name = "panelSupplier";
            this.panelSupplier.Size = new System.Drawing.Size(284, 261);
            this.panelSupplier.TabIndex = 3;
            // 
            // panelOrder
            // 
            this.panelOrder.Controls.Add(this.buttonOrderRemove);
            this.panelOrder.Controls.Add(this.buttonOrderAdd);
            this.panelOrder.Controls.Add(this.listOrderOrderrules);
            this.panelOrder.Controls.Add(this.dateOrderTimeDate);
            this.panelOrder.Controls.Add(this.comboOrderCustomerIds);
            this.panelOrder.Controls.Add(this.labelOrderCustomerId);
            this.panelOrder.Controls.Add(this.labelOrderDate);
            this.panelOrder.Controls.Add(this.labelOrderOrderrules);
            this.panelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrder.Location = new System.Drawing.Point(0, 0);
            this.panelOrder.Name = "panelOrder";
            this.panelOrder.Size = new System.Drawing.Size(284, 261);
            this.panelOrder.TabIndex = 4;
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.numItemStock);
            this.panelItem.Controls.Add(this.labelItemStock);
            this.panelItem.Controls.Add(this.comboItemSupplier);
            this.panelItem.Controls.Add(this.labelItemSupplier);
            this.panelItem.Controls.Add(this.labelItemDescription);
            this.panelItem.Controls.Add(this.textItemDescription);
            this.panelItem.Controls.Add(this.comboItemCategory);
            this.panelItem.Controls.Add(this.labelItemCategory);
            this.panelItem.Controls.Add(this.numItemPrice);
            this.panelItem.Controls.Add(this.labelItemPrice);
            this.panelItem.Controls.Add(this.textItemName);
            this.panelItem.Controls.Add(this.labelItemName);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(284, 261);
            this.panelItem.TabIndex = 5;
            // 
            // panelCategory
            // 
            this.panelCategory.Controls.Add(this.textCategoryDescription);
            this.panelCategory.Controls.Add(this.labelCategoryDescription);
            this.panelCategory.Controls.Add(this.textCategoryName);
            this.panelCategory.Controls.Add(this.labelCategoryName);
            this.panelCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCategory.Location = new System.Drawing.Point(0, 0);
            this.panelCategory.Name = "panelCategory";
            this.panelCategory.Size = new System.Drawing.Size(284, 261);
            this.panelCategory.TabIndex = 6;
            // 
            // labelCategoryName
            // 
            this.labelCategoryName.AutoSize = true;
            this.labelCategoryName.Location = new System.Drawing.Point(12, 15);
            this.labelCategoryName.Name = "labelCategoryName";
            this.labelCategoryName.Size = new System.Drawing.Size(41, 13);
            this.labelCategoryName.TabIndex = 0;
            this.labelCategoryName.Text = "Name: ";
            // 
            // textCategoryName
            // 
            this.textCategoryName.Location = new System.Drawing.Point(84, 12);
            this.textCategoryName.Name = "textCategoryName";
            this.textCategoryName.Size = new System.Drawing.Size(180, 20);
            this.textCategoryName.TabIndex = 1;
            // 
            // textCategoryDescription
            // 
            this.textCategoryDescription.Location = new System.Drawing.Point(84, 51);
            this.textCategoryDescription.Multiline = true;
            this.textCategoryDescription.Name = "textCategoryDescription";
            this.textCategoryDescription.Size = new System.Drawing.Size(180, 162);
            this.textCategoryDescription.TabIndex = 3;
            // 
            // labelCategoryDescription
            // 
            this.labelCategoryDescription.AutoSize = true;
            this.labelCategoryDescription.Location = new System.Drawing.Point(12, 51);
            this.labelCategoryDescription.Name = "labelCategoryDescription";
            this.labelCategoryDescription.Size = new System.Drawing.Size(66, 13);
            this.labelCategoryDescription.TabIndex = 2;
            this.labelCategoryDescription.Text = "Description: ";
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(0, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(284, 31);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelOrderCustomerId
            // 
            this.labelOrderCustomerId.AutoSize = true;
            this.labelOrderCustomerId.Location = new System.Drawing.Point(12, 14);
            this.labelOrderCustomerId.Name = "labelOrderCustomerId";
            this.labelOrderCustomerId.Size = new System.Drawing.Size(71, 13);
            this.labelOrderCustomerId.TabIndex = 0;
            this.labelOrderCustomerId.Text = "Customer ID: ";
            // 
            // comboOrderCustomerIds
            // 
            this.comboOrderCustomerIds.FormattingEnabled = true;
            this.comboOrderCustomerIds.Location = new System.Drawing.Point(84, 11);
            this.comboOrderCustomerIds.Name = "comboOrderCustomerIds";
            this.comboOrderCustomerIds.Size = new System.Drawing.Size(121, 21);
            this.comboOrderCustomerIds.TabIndex = 1;
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(47, 54);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(36, 13);
            this.labelOrderDate.TabIndex = 2;
            this.labelOrderDate.Text = "Date: ";
            // 
            // dateOrderTimeDate
            // 
            this.dateOrderTimeDate.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateOrderTimeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOrderTimeDate.Location = new System.Drawing.Point(84, 51);
            this.dateOrderTimeDate.Name = "dateOrderTimeDate";
            this.dateOrderTimeDate.ShowUpDown = true;
            this.dateOrderTimeDate.Size = new System.Drawing.Size(121, 20);
            this.dateOrderTimeDate.TabIndex = 3;
            // 
            // labelOrderOrderrules
            // 
            this.labelOrderOrderrules.AutoSize = true;
            this.labelOrderOrderrules.Location = new System.Drawing.Point(22, 84);
            this.labelOrderOrderrules.Name = "labelOrderOrderrules";
            this.labelOrderOrderrules.Size = new System.Drawing.Size(61, 13);
            this.labelOrderOrderrules.TabIndex = 4;
            this.labelOrderOrderrules.Text = "Orderrules: ";
            // 
            // listOrderOrderrules
            // 
            this.listOrderOrderrules.AllColumns.Add(this.columnItemId);
            this.listOrderOrderrules.AllColumns.Add(this.columnItemAmount);
            this.listOrderOrderrules.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            this.listOrderOrderrules.CellEditTabChangesRows = true;
            this.listOrderOrderrules.CellEditUseWholeCell = false;
            this.listOrderOrderrules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnItemId,
            this.columnItemAmount});
            this.listOrderOrderrules.Cursor = System.Windows.Forms.Cursors.Default;
            this.listOrderOrderrules.Location = new System.Drawing.Point(84, 84);
            this.listOrderOrderrules.Name = "listOrderOrderrules";
            this.listOrderOrderrules.Size = new System.Drawing.Size(180, 129);
            this.listOrderOrderrules.TabIndex = 5;
            this.listOrderOrderrules.UseCompatibleStateImageBehavior = false;
            this.listOrderOrderrules.View = System.Windows.Forms.View.Details;
            // 
            // columnItemId
            // 
            this.columnItemId.AspectName = "Item_Id";
            this.columnItemId.Groupable = false;
            this.columnItemId.Text = "Item ID";
            this.columnItemId.Width = 86;
            // 
            // columnItemAmount
            // 
            this.columnItemAmount.AspectName = "Amount";
            this.columnItemAmount.Groupable = false;
            this.columnItemAmount.Text = "Amount";
            this.columnItemAmount.Width = 90;
            // 
            // buttonOrderAdd
            // 
            this.buttonOrderAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderAdd.Location = new System.Drawing.Point(58, 134);
            this.buttonOrderAdd.Name = "buttonOrderAdd";
            this.buttonOrderAdd.Size = new System.Drawing.Size(20, 20);
            this.buttonOrderAdd.TabIndex = 6;
            this.buttonOrderAdd.Text = "+";
            this.buttonOrderAdd.UseVisualStyleBackColor = true;
            this.buttonOrderAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOrderRemove
            // 
            this.buttonOrderRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderRemove.Location = new System.Drawing.Point(58, 160);
            this.buttonOrderRemove.Name = "buttonOrderRemove";
            this.buttonOrderRemove.Size = new System.Drawing.Size(20, 20);
            this.buttonOrderRemove.TabIndex = 7;
            this.buttonOrderRemove.Text = "-";
            this.buttonOrderRemove.UseVisualStyleBackColor = true;
            this.buttonOrderRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Location = new System.Drawing.Point(37, 15);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(41, 13);
            this.labelItemName.TabIndex = 0;
            this.labelItemName.Text = "Name: ";
            // 
            // textItemName
            // 
            this.textItemName.Location = new System.Drawing.Point(84, 12);
            this.textItemName.Name = "textItemName";
            this.textItemName.Size = new System.Drawing.Size(121, 20);
            this.textItemName.TabIndex = 1;
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Location = new System.Drawing.Point(41, 41);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(37, 13);
            this.labelItemPrice.TabIndex = 2;
            this.labelItemPrice.Text = "Price: ";
            // 
            // numItemPrice
            // 
            this.numItemPrice.Location = new System.Drawing.Point(84, 39);
            this.numItemPrice.Name = "numItemPrice";
            this.numItemPrice.Size = new System.Drawing.Size(62, 20);
            this.numItemPrice.TabIndex = 3;
            // 
            // labelItemCategory
            // 
            this.labelItemCategory.AutoSize = true;
            this.labelItemCategory.Location = new System.Drawing.Point(23, 68);
            this.labelItemCategory.Name = "labelItemCategory";
            this.labelItemCategory.Size = new System.Drawing.Size(55, 13);
            this.labelItemCategory.TabIndex = 5;
            this.labelItemCategory.Text = "Category: ";
            // 
            // comboItemCategory
            // 
            this.comboItemCategory.FormattingEnabled = true;
            this.comboItemCategory.Location = new System.Drawing.Point(84, 65);
            this.comboItemCategory.Name = "comboItemCategory";
            this.comboItemCategory.Size = new System.Drawing.Size(121, 21);
            this.comboItemCategory.TabIndex = 6;
            // 
            // labelItemDescription
            // 
            this.labelItemDescription.AutoSize = true;
            this.labelItemDescription.Location = new System.Drawing.Point(12, 96);
            this.labelItemDescription.Name = "labelItemDescription";
            this.labelItemDescription.Size = new System.Drawing.Size(66, 13);
            this.labelItemDescription.TabIndex = 8;
            this.labelItemDescription.Text = "Description: ";
            // 
            // textItemDescription
            // 
            this.textItemDescription.Location = new System.Drawing.Point(84, 93);
            this.textItemDescription.Multiline = true;
            this.textItemDescription.Name = "textItemDescription";
            this.textItemDescription.Size = new System.Drawing.Size(121, 76);
            this.textItemDescription.TabIndex = 7;
            // 
            // comboItemSupplier
            // 
            this.comboItemSupplier.FormattingEnabled = true;
            this.comboItemSupplier.Location = new System.Drawing.Point(84, 175);
            this.comboItemSupplier.Name = "comboItemSupplier";
            this.comboItemSupplier.Size = new System.Drawing.Size(121, 21);
            this.comboItemSupplier.TabIndex = 10;
            // 
            // labelItemSupplier
            // 
            this.labelItemSupplier.AutoSize = true;
            this.labelItemSupplier.Location = new System.Drawing.Point(27, 178);
            this.labelItemSupplier.Name = "labelItemSupplier";
            this.labelItemSupplier.Size = new System.Drawing.Size(51, 13);
            this.labelItemSupplier.TabIndex = 9;
            this.labelItemSupplier.Text = "Supplier: ";
            // 
            // numItemStock
            // 
            this.numItemStock.Location = new System.Drawing.Point(84, 204);
            this.numItemStock.Name = "numItemStock";
            this.numItemStock.Size = new System.Drawing.Size(62, 20);
            this.numItemStock.TabIndex = 12;
            // 
            // labelItemStock
            // 
            this.labelItemStock.AutoSize = true;
            this.labelItemStock.Location = new System.Drawing.Point(37, 206);
            this.labelItemStock.Name = "labelItemStock";
            this.labelItemStock.Size = new System.Drawing.Size(41, 13);
            this.labelItemStock.TabIndex = 11;
            this.labelItemStock.Text = "Stock: ";
            // 
            // labelSupplierName
            // 
            this.labelSupplierName.AutoSize = true;
            this.labelSupplierName.Location = new System.Drawing.Point(22, 15);
            this.labelSupplierName.Name = "labelSupplierName";
            this.labelSupplierName.Size = new System.Drawing.Size(41, 13);
            this.labelSupplierName.TabIndex = 0;
            this.labelSupplierName.Text = "Name: ";
            // 
            // textSupplierName
            // 
            this.textSupplierName.Location = new System.Drawing.Point(69, 11);
            this.textSupplierName.Name = "textSupplierName";
            this.textSupplierName.Size = new System.Drawing.Size(100, 20);
            this.textSupplierName.TabIndex = 1;
            // 
            // textSupplierAddress
            // 
            this.textSupplierAddress.Location = new System.Drawing.Point(69, 38);
            this.textSupplierAddress.Name = "textSupplierAddress";
            this.textSupplierAddress.Size = new System.Drawing.Size(100, 20);
            this.textSupplierAddress.TabIndex = 3;
            // 
            // labelSupplierAddress
            // 
            this.labelSupplierAddress.AutoSize = true;
            this.labelSupplierAddress.Location = new System.Drawing.Point(12, 42);
            this.labelSupplierAddress.Name = "labelSupplierAddress";
            this.labelSupplierAddress.Size = new System.Drawing.Size(51, 13);
            this.labelSupplierAddress.TabIndex = 2;
            this.labelSupplierAddress.Text = "Address: ";
            // 
            // textSupplierZipcode
            // 
            this.textSupplierZipcode.Location = new System.Drawing.Point(69, 64);
            this.textSupplierZipcode.MaxLength = 8;
            this.textSupplierZipcode.Name = "textSupplierZipcode";
            this.textSupplierZipcode.Size = new System.Drawing.Size(58, 20);
            this.textSupplierZipcode.TabIndex = 5;
            // 
            // labelSupplierZipcode
            // 
            this.labelSupplierZipcode.AutoSize = true;
            this.labelSupplierZipcode.Location = new System.Drawing.Point(12, 68);
            this.labelSupplierZipcode.Name = "labelSupplierZipcode";
            this.labelSupplierZipcode.Size = new System.Drawing.Size(52, 13);
            this.labelSupplierZipcode.TabIndex = 4;
            this.labelSupplierZipcode.Text = "Zipcode: ";
            // 
            // textCustomerZipcode
            // 
            this.textCustomerZipcode.Location = new System.Drawing.Point(69, 67);
            this.textCustomerZipcode.MaxLength = 8;
            this.textCustomerZipcode.Name = "textCustomerZipcode";
            this.textCustomerZipcode.Size = new System.Drawing.Size(58, 20);
            this.textCustomerZipcode.TabIndex = 11;
            // 
            // labelCustomerZipcode
            // 
            this.labelCustomerZipcode.AutoSize = true;
            this.labelCustomerZipcode.Location = new System.Drawing.Point(12, 71);
            this.labelCustomerZipcode.Name = "labelCustomerZipcode";
            this.labelCustomerZipcode.Size = new System.Drawing.Size(52, 13);
            this.labelCustomerZipcode.TabIndex = 10;
            this.labelCustomerZipcode.Text = "Zipcode: ";
            // 
            // textCustomerAddress
            // 
            this.textCustomerAddress.Location = new System.Drawing.Point(69, 41);
            this.textCustomerAddress.Name = "textCustomerAddress";
            this.textCustomerAddress.Size = new System.Drawing.Size(100, 20);
            this.textCustomerAddress.TabIndex = 9;
            // 
            // labelCujstomerAddress
            // 
            this.labelCujstomerAddress.AutoSize = true;
            this.labelCujstomerAddress.Location = new System.Drawing.Point(12, 45);
            this.labelCujstomerAddress.Name = "labelCujstomerAddress";
            this.labelCujstomerAddress.Size = new System.Drawing.Size(51, 13);
            this.labelCujstomerAddress.TabIndex = 8;
            this.labelCujstomerAddress.Text = "Address: ";
            // 
            // textCustomerName
            // 
            this.textCustomerName.Location = new System.Drawing.Point(69, 14);
            this.textCustomerName.Name = "textCustomerName";
            this.textCustomerName.Size = new System.Drawing.Size(100, 20);
            this.textCustomerName.TabIndex = 7;
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(22, 18);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(41, 13);
            this.labelCustomerName.TabIndex = 6;
            this.labelCustomerName.Text = "Name: ";
            // 
            // textCustomerPhone
            // 
            this.textCustomerPhone.Location = new System.Drawing.Point(69, 93);
            this.textCustomerPhone.Name = "textCustomerPhone";
            this.textCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.textCustomerPhone.TabIndex = 13;
            // 
            // labelCustomerPhone
            // 
            this.labelCustomerPhone.AutoSize = true;
            this.labelCustomerPhone.Location = new System.Drawing.Point(19, 97);
            this.labelCustomerPhone.Name = "labelCustomerPhone";
            this.labelCustomerPhone.Size = new System.Drawing.Size(44, 13);
            this.labelCustomerPhone.TabIndex = 12;
            this.labelCustomerPhone.Text = "Phone: ";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.panelSupplier);
            this.Controls.Add(this.panelItem);
            this.Controls.Add(this.panelCategory);
            this.Controls.Add(this.panelOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            this.panelCustomer.ResumeLayout(false);
            this.panelCustomer.PerformLayout();
            this.panelSupplier.ResumeLayout(false);
            this.panelSupplier.PerformLayout();
            this.panelOrder.ResumeLayout(false);
            this.panelOrder.PerformLayout();
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            this.panelCategory.ResumeLayout(false);
            this.panelCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOrderOrderrules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numItemStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCustomer;
        private System.Windows.Forms.Panel panelSupplier;
        private System.Windows.Forms.Panel panelOrder;
        private System.Windows.Forms.Panel panelItem;
        private System.Windows.Forms.Panel panelCategory;
        private System.Windows.Forms.TextBox textCategoryDescription;
        private System.Windows.Forms.Label labelCategoryDescription;
        private System.Windows.Forms.TextBox textCategoryName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboOrderCustomerIds;
        private System.Windows.Forms.Label labelOrderCustomerId;
        private System.Windows.Forms.DateTimePicker dateOrderTimeDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelOrderOrderrules;
        private BrightIdeasSoftware.ObjectListView listOrderOrderrules;
        private BrightIdeasSoftware.OLVColumn columnItemId;
        private BrightIdeasSoftware.OLVColumn columnItemAmount;
        private System.Windows.Forms.Button buttonOrderAdd;
        private System.Windows.Forms.Button buttonOrderRemove;
        private System.Windows.Forms.TextBox textItemName;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.NumericUpDown numItemPrice;
        private System.Windows.Forms.Label labelItemPrice;
        private System.Windows.Forms.ComboBox comboItemCategory;
        private System.Windows.Forms.Label labelItemCategory;
        private System.Windows.Forms.Label labelItemDescription;
        private System.Windows.Forms.TextBox textItemDescription;
        private System.Windows.Forms.ComboBox comboItemSupplier;
        private System.Windows.Forms.Label labelItemSupplier;
        private System.Windows.Forms.NumericUpDown numItemStock;
        private System.Windows.Forms.Label labelItemStock;
        private System.Windows.Forms.TextBox textSupplierZipcode;
        private System.Windows.Forms.Label labelSupplierZipcode;
        private System.Windows.Forms.TextBox textSupplierAddress;
        private System.Windows.Forms.Label labelSupplierAddress;
        private System.Windows.Forms.TextBox textSupplierName;
        private System.Windows.Forms.Label labelSupplierName;
        private System.Windows.Forms.TextBox textCustomerPhone;
        private System.Windows.Forms.Label labelCustomerPhone;
        private System.Windows.Forms.TextBox textCustomerZipcode;
        private System.Windows.Forms.Label labelCustomerZipcode;
        private System.Windows.Forms.TextBox textCustomerAddress;
        private System.Windows.Forms.Label labelCujstomerAddress;
        private System.Windows.Forms.TextBox textCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
    }
}