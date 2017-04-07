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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listShopItems = new BrightIdeasSoftware.ObjectListView();
            this.columnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnStock = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.columnCategory = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopItems)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(910, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // listShopItems
            // 
            this.listShopItems.AllColumns.Add(this.columnName);
            this.listShopItems.AllColumns.Add(this.columnDescription);
            this.listShopItems.AllColumns.Add(this.columnPrice);
            this.listShopItems.AllColumns.Add(this.columnStock);
            this.listShopItems.AllColumns.Add(this.columnCategory);
            this.listShopItems.AllowColumnReorder = true;
            this.listShopItems.CellEditUseWholeCell = false;
            this.listShopItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnDescription,
            this.columnPrice,
            this.columnStock,
            this.columnCategory});
            this.listShopItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.listShopItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listShopItems.Location = new System.Drawing.Point(0, 24);
            this.listShopItems.MultiSelect = false;
            this.listShopItems.Name = "listShopItems";
            this.listShopItems.ShowItemCountOnGroups = true;
            this.listShopItems.Size = new System.Drawing.Size(910, 529);
            this.listShopItems.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listShopItems.TabIndex = 3;
            this.listShopItems.UseCompatibleStateImageBehavior = false;
            this.listShopItems.View = System.Windows.Forms.View.Details;
            // 
            // columnName
            // 
            this.columnName.AspectName = "Name";
            this.columnName.Text = "Name";
            this.columnName.UseInitialLetterForGroup = true;
            // 
            // columnPrice
            // 
            this.columnPrice.AspectName = "Price";
            this.columnPrice.AspectToStringFormat = "{0:C}";
            this.columnPrice.Text = "Price";
            // 
            // columnDescription
            // 
            this.columnDescription.AspectName = "Description";
            this.columnDescription.Groupable = false;
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 86;
            // 
            // columnStock
            // 
            this.columnStock.AspectName = "FormattedStock";
            this.columnStock.Text = "Stock";
            // 
            // columnCategory
            // 
            this.columnCategory.AspectName = "CategoryName";
            this.columnCategory.Text = "Category";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 553);
            this.Controls.Add(this.listShopItems);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Management System";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listShopItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private BrightIdeasSoftware.ObjectListView listShopItems;
        private BrightIdeasSoftware.OLVColumn columnName;
        private BrightIdeasSoftware.OLVColumn columnPrice;
        private BrightIdeasSoftware.OLVColumn columnDescription;
        private BrightIdeasSoftware.OLVColumn columnStock;
        private BrightIdeasSoftware.OLVColumn columnCategory;
    }
}

