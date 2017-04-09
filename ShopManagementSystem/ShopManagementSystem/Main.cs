using BrightIdeasSoftware;
using ShopManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class formMain : Form
    {
        private bool firstTime = true;
        private ShopmsEntities dbContext = new ShopmsEntities(); // objectListView needs a live context
        private List<ListTypeCombination> lists = new List<ListTypeCombination>();
        private List<KeyValuePair<ToolStripItem, Type>> createStrips = new List<KeyValuePair<ToolStripItem, Type>>();

        // TODO: Add 'supplier' column to Item list
        public formMain()
        {
            InitializeComponent();

            // Generate dbase rows if there arent any
            // Generates new data if Item table doesnt contain anything (it's OK for now..)
            if (!dbContext.Item.Any())
                Generation.Generate();

            // Add lists to list
            lists.Add(new ListTypeCombination(listShopItems, dbContext.Item));
            lists.Add(new ListTypeCombination(listShopOrders, dbContext.Order));
            lists.Add(new ListTypeCombination(listShopOrderrules, dbContext.Orderrule));
            lists.Add(new ListTypeCombination(listShopSuppliers, dbContext.Supplier));
            lists.Add(new ListTypeCombination(listShopCustomers, dbContext.Customer));
            lists.Add(new ListTypeCombination(listShopCategories, dbContext.Category));

            foreach (ListTypeCombination combi in lists)
            {
                // Initialize data list
                combi.list.SetObjects(combi.dbSet);

                // Initialize cell editors
                combi.list.CellEditStarting += new CellEditEventHandler(this.lists_cellEditStarting);
                combi.list.CellEditValidating += new CellEditEventHandler(this.lists_cellEditValidating);
                combi.list.CellEditFinishing += new CellEditEventHandler(this.lists_cellEditFinishing);
                combi.list.CellEditFinished += new CellEditEventHandler(this.lists_cellEditFinished);
            }

            // Initialize toolstrip items
            // 'Create' items
            createStrips.Add(new KeyValuePair<ToolStripItem, Type>(toolStripCreateItem, typeof(Item)));
            createStrips.Add(new KeyValuePair<ToolStripItem, Type>(toolStripCreateOrder, typeof(Order)));
            createStrips.Add(new KeyValuePair<ToolStripItem, Type>(toolStripCreateSupplier, typeof(Supplier)));
            createStrips.Add(new KeyValuePair<ToolStripItem, Type>(toolStripCreateCustomer, typeof(Customer)));
            createStrips.Add(new KeyValuePair<ToolStripItem, Type>(toolStripCreateCategory, typeof(Category)));

            foreach (KeyValuePair<ToolStripItem, Type> pair in createStrips)
            {
                pair.Key.Click += new EventHandler(this.createRecord);
            }
        }

        private void createRecord(object sender, EventArgs e)
        {
            // Check what type to create
            ToolStripItem item = (ToolStripItem)sender;
            foreach (KeyValuePair<ToolStripItem, Type> pair in createStrips)
            {
                // Show the right form for creation
                if (pair.Key == item)
                {
                    Type type = pair.Value as Type;
                    (new CreateForm(type, dbContext)).ShowDialog();
                    // TODO: Refresh list
                    lists.Where(x => x.dbSet.ElementType == type).FirstOrDefault().list.BuildList();
                }
            }
        }

        private void toolStripSearch_Enter(object sender, EventArgs e)
        {
            // Clear initial text
            if (firstTime)
            {
                toolStripSearch.Clear();
                toolStripSearch.ForeColor = Color.Black;
                firstTime = false;
            }
        }

        private void toolStripSearch_TextChanged(object sender, EventArgs e)
        {
            // TODO: Make dynamic
            // Filter list
            listShopItems.ModelFilter = new ModelFilter(delegate (object modelObject)
            {
                Item item = (Item)modelObject;
                return item.Id.ToString().Contains(toolStripSearch.Text) || // ID
                    item.Name.Contains(toolStripSearch.Text) || // Name
                    item.Description.Contains(toolStripSearch.Text) || // Description
                    item.Price.ToString().Contains(toolStripSearch.Text) || // Price
                    item.Stock.ToString().Contains(toolStripSearch.Text) || // Stock
                    item.Category.Name.Contains(toolStripSearch.Text); // Category
            });

            listShopOrders.ModelFilter = new ModelFilter(delegate (object modelObject)
            {
                Order order = (Order)modelObject;
                return order.Id.ToString().Contains(toolStripSearch.Text) || // ID
                    order.Customer_Id.ToString().Contains(toolStripSearch.Text) || // Customer ID
                    order.Date.ToString().Contains(toolStripSearch.Text); // Date
            });

            listShopOrderrules.ModelFilter = new ModelFilter(delegate (object modelObject)
            {
                Orderrule orderrule = (Orderrule)modelObject;
                return orderrule.Id.ToString().Contains(toolStripSearch.Text) || // ID
                    orderrule.Order_Id.ToString().Contains(toolStripSearch.Text) || // Order ID
                    orderrule.Item_Id.ToString().Contains(toolStripSearch.Text); // Item ID
            });

            listShopSuppliers.ModelFilter = new ModelFilter(delegate (object modelObject)
            {
                Supplier supplier = (Supplier)modelObject;
                return supplier.Id.ToString().Contains(toolStripSearch.Text) || // ID
                    supplier.Name.Contains(toolStripSearch.Text) || // Name
                    supplier.Address.Contains(toolStripSearch.Text) || // Address
                    supplier.Zipcode.Contains(toolStripSearch.Text); // Zipcode
            });

            listShopCustomers.ModelFilter = new ModelFilter(delegate (object modelObject)
            {
                Customer customer = (Customer)modelObject;
                return customer.Id.ToString().Contains(toolStripSearch.Text) || // ID
                    customer.Name.Contains(toolStripSearch.Text) || // Name
                    customer.Address.Contains(toolStripSearch.Text) || // Address
                    customer.Zipcode.Contains(toolStripSearch.Text) || // Zipcode
                    customer.Phone.Contains(toolStripSearch.Text); // Phone
            });

            listShopCategories.ModelFilter = new ModelFilter(delegate (object modelObject)
            {
                Category category = (Category)modelObject;
                return category.Id.ToString().Contains(toolStripSearch.Text) || // ID
                    category.Name.Contains(toolStripSearch.Text) || // Name
                    category.Description.Contains(toolStripSearch.Text); // Description
            });
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopmsDataSet.Item' table. You can move, or remove it, as needed.
            //this.itemTableAdapter.Fill(this.shopmsDataSet.Item);
        }

        // Custom cell editors
        private void lists_cellEditStarting(object sender, CellEditEventArgs e)
        {
            ObjectListView list = (ObjectListView)sender;

            // Global editors
            if (e.Value is Decimal)
            {
                NumericUpDown num = new NumericUpDown();
                num.Minimum = 0;
                num.Maximum = decimal.MaxValue;
                num.Value = (decimal)e.Value;
                num.Bounds = e.CellBounds;
                e.Control = num;
            }
            else if (e.Value is DateTime)
            {
                // TODO: Find Date+Time picker to use here
                DateTimePicker pick = new DateTimePicker();
                pick.Format = DateTimePickerFormat.Custom;
                pick.CustomFormat = "dd-MM-yyyy hh:mm:ss";
                pick.ShowUpDown = true;
                pick.Value = (DateTime)e.Value;
                pick.Bounds = e.CellBounds;
                e.Control = pick;
            }

            // Items editor
            if (list.Name == listShopItems.Name)
            {
                // Category combo
                if (e.Column.AspectName == "CategoryName")
                {
                    ComboBox cbox = new ComboBox();
                    dbContext.Category.ToList().ForEach((category) => { cbox.Items.Add(category.Name); });
                    cbox.SelectedItem = e.Value;
                    cbox.Bounds = e.CellBounds;
                    e.Control = cbox;
                }
            }
            // Orders editor
            else if (list.Name == listShopOrders.Name)
            {
                // Customer ID combo
                if (e.Column.AspectName == "Customer_Id")
                {
                    ComboBox cbox = new ComboBox();
                    dbContext.Customer.ToList().ForEach((customer) => { cbox.Items.Add(customer.Id); });
                    cbox.SelectedItem = e.Value;
                    cbox.Bounds = e.CellBounds;
                    e.Control = cbox;
                }
            }
            // Orderrules editor
            else if (list.Name == listShopOrderrules.Name)
            {
                // Order ID combo
                if (e.Column.AspectName == "Order_Id")
                {
                    ComboBox cbox = new ComboBox();
                    dbContext.Order.ToList().ForEach((order) => { cbox.Items.Add(order.Id); });
                    cbox.SelectedItem = e.Value;
                    cbox.Bounds = e.CellBounds;
                    e.Control = cbox;
                }
                // Item ID combo
                else if (e.Column.AspectName == "Item_Id")
                {
                    ComboBox cbox = new ComboBox();
                    dbContext.Item.ToList().ForEach((item) => { cbox.Items.Add(item.Id); });
                    cbox.SelectedItem = e.Value;
                    cbox.Bounds = e.CellBounds;
                    e.Control = cbox;
                }
            }
        }

        // TODO: Shorten this
        private void lists_cellEditValidating(object sender, CellEditEventArgs e)
        {
            ObjectListView list = (ObjectListView)sender;

            // Items editor
            if (list.Name == listShopItems.Name)
            {
                // Category combo
                if (e.Column.AspectName == "CategoryName")
                {
                    try
                    {
                        string name = (e.Control as ComboBox).SelectedItem.ToString();
                        dbContext.Category.First(x => x.Name == name);
                    }
                    catch (Exception ex)
                    {
                        if (ex is ArgumentNullException)
                            MessageBox.Show("Please make sure you dont fill in empty values.", "Error", MessageBoxButtons.OK);
                        else if (ex is InvalidOperationException)
                            MessageBox.Show("Something went wrong while validating your changes...\n\nBelow this line is the error message\n-----------\n" + ex, "Error", MessageBoxButtons.OK);

                        e.Cancel = true;
                    }
                }
            }
            // Orders editor
            else if (list.Name == listShopOrders.Name)
            {
                // Customer ID combo
                if (e.Column.AspectName == "Customer_Id")
                {
                    try
                    {
                        int id = Convert.ToInt32((e.Control as ComboBox).SelectedItem);
                        dbContext.Customer.First(x => x.Id == id);
                    }
                    catch (Exception ex)
                    {
                        if (ex is ArgumentNullException)
                            MessageBox.Show("Please make sure you dont fill in empty values.", "Error", MessageBoxButtons.OK);
                        else if (ex is InvalidOperationException)
                            MessageBox.Show("Something went wrong while validating your changes...\n\nBelow this line is the error message\n-----------\n" + ex, "Error", MessageBoxButtons.OK);
                        else if (ex is InvalidCastException)
                            MessageBox.Show("Please make sure you only fill in numbers where necessary.", "Error", MessageBoxButtons.OK);

                        e.Cancel = true;
                    }
                }
            }
            // Orderrules editor
            else if (list.Name == listShopOrderrules.Name)
            {
                // Order ID combo
                if (e.Column.AspectName == "Order_Id")
                {
                    try
                    {
                        int id = Convert.ToInt32((e.Control as ComboBox).SelectedItem);
                        dbContext.Order.First(x => x.Id == id);
                    }
                    catch (Exception ex)
                    {
                        if (ex is ArgumentNullException)
                            MessageBox.Show("Please make sure you dont fill in empty values.", "Error", MessageBoxButtons.OK);
                        else if (ex is InvalidOperationException)
                            MessageBox.Show("Something went wrong while validating your changes...\n\nBelow this line is the error message\n-----------\n" + ex, "Error", MessageBoxButtons.OK);
                        else if (ex is InvalidCastException)
                            MessageBox.Show("Please make sure you only fill in numbers where necessary.", "Error", MessageBoxButtons.OK);

                        e.Cancel = true;
                    }
                }
                // Item ID combo
                else if (e.Column.AspectName == "Item_Id")
                {
                    try
                    {
                        int id = Convert.ToInt32((e.Control as ComboBox).SelectedItem);
                        dbContext.Item.First(x => x.Id == id);
                    }
                    catch (Exception ex)
                    {
                        if (ex is ArgumentNullException)
                            MessageBox.Show("Please make sure you dont fill in empty values.", "Error", MessageBoxButtons.OK);
                        else if (ex is InvalidOperationException)
                            MessageBox.Show("Something went wrong while validating your changes...\n\nBelow this line is the error message\n-----------\n" + ex, "Error", MessageBoxButtons.OK);
                        else if (ex is InvalidCastException)
                            MessageBox.Show("Please make sure you only fill in numbers where necessary.", "Error", MessageBoxButtons.OK);

                        e.Cancel = true;
                    }
                }
            }
        }

        private void lists_cellEditFinishing(object sender, CellEditEventArgs e)
        {
            ObjectListView list = (ObjectListView)sender;

            // Items
            if (list.Name == listShopItems.Name)
            {
                Item item = (Item)e.RowObject;

                // Category
                if (e.Column.AspectName == "CategoryName")
                {
                    string categoryName = (e.Control as ComboBox).SelectedItem.ToString();
                    item.Category = dbContext.Category.First(x => x.Name == categoryName);
                }

                listShopItems.RefreshItem(e.ListViewItem);
            }
            // Orders
            else if (list.Name == listShopOrders.Name)
            {
                Order order = (Order)e.RowObject;

                // Customer ID
                if (e.Column.AspectName == "Customer_Id")
                {
                    int id = Convert.ToInt32((e.Control as ComboBox).SelectedItem);
                    order.Customer = dbContext.Customer.First(x => x.Id == id);
                }

                listShopOrders.RefreshItem(e.ListViewItem);
            }
            // Orderrules
            else if (list.Name == listShopOrderrules.Name)
            {
                Orderrule orderrule = (Orderrule)e.RowObject;

                // Order ID
                if (e.Column.AspectName == "Order_Id")
                {
                    int id = Convert.ToInt32((e.Control as ComboBox).SelectedItem);
                    orderrule.Order = dbContext.Order.First(x => x.Id == id);
                }
                // Item ID
                else if (e.Column.AspectName == "Item_Id")
                {
                    int id = Convert.ToInt32((e.Control as ComboBox).SelectedItem);
                    orderrule.Item = dbContext.Item.First(x => x.Id == id);
                }

                listShopOrderrules.RefreshItem(e.ListViewItem);
            }

            e.Cancel = true;
        }

        private void lists_cellEditFinished(object sender, CellEditEventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex is DbUpdateException || ex is DbUpdateConcurrencyException ||
                    ex is DbEntityValidationException || ex is NotSupportedException ||
                    ex is ObjectDisposedException || ex is InvalidOperationException)
                {
                    MessageBox.Show("Something went wrong while saving your changes...\n\nBelow this line is the error message\n-----------\n" + ex, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListTypeCombination combi in lists)
            {
                // Get active list
                if (combi.list.Focused)
                {
                    // Get selected item
                    object selectedItem = combi.list.SelectedObject;

                    DeleteObject(combi.list, selectedItem, combi.dbSet.ElementType.Name);

                    break;
                }
            }

        }

        // TODO: Shorten
        private void DeleteObject(ObjectListView list, object selectedItem, string typeName, bool silent = false)
        {
            Action extraRebuild = () => { };
            switch (typeName)
            {
                case "Item":
                    Item item = (Item)selectedItem;
                    if (item.Orderrule.Any())
                    {
                        string orderruleIds = "";
                        int counter = 1;
                        item.Orderrule.ToList().ForEach((orderrule) => { orderruleIds += orderrule.Id.ToString() + (counter < item.Orderrule.Count() ? "," : ""); counter++; });
                        if (!silent)
                        {
                            DialogResult result = MessageBox.Show(string.Format("This item has a relation with orderrule{0} (id:{1}), if you proceed the orderrule{0} will be deleted aswell\n\nDo you want to proceed?", (item.Orderrule.Count() > 1 ? "s" : ""), orderruleIds), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result != DialogResult.Yes)
                                break;
                        }
                    }

                    //dbContext.Orderrule.Where(x => x.Item_Id == item.Id).ToList().ForEach((orderrule) => { DeleteObject(list, orderrule, orderrule.GetType().Name, true); });
                    dbContext.Item.Remove(item);
                    listShopItems.RemoveObject(selectedItem); // Needed, otherwise it crashes when it wants to show the item's category formatted name
                    extraRebuild = () => listShopOrderrules.BuildList();
                    break;
                case "Order":
                    Order order = (Order)selectedItem;
                    if (order.Orderrule.Any())
                    {
                        string orderruleIds = "";
                        int counter = 1;
                        order.Orderrule.ToList().ForEach((orderrule) => { orderruleIds += orderrule.Id.ToString() + (counter < order.Orderrule.Count() ? "," : ""); counter++; });
                        if (!silent)
                        {
                            DialogResult result = MessageBox.Show(string.Format("This order has a relation with orderrule{0} (id:{1}), if you proceed the orderrule{0} will be deleted aswell\n\nDo you want to proceed?", (order.Orderrule.Count() > 1 ? "s" : ""), orderruleIds), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result != DialogResult.Yes)
                                break; 
                        }
                    }

                    //dbContext.Orderrule.Where(x => x.Order_Id == order.Id).ToList().ForEach((orderrule) => { DeleteObject(list, orderrule, orderrule.GetType().Name, true); });
                    dbContext.Order.Remove(order);
                    extraRebuild = () => listShopOrderrules.BuildList();
                    break;
                case "Orderrule":
                    Orderrule rule = (Orderrule)selectedItem;

                    dbContext.Orderrule.Remove(rule);
                    break;
                case "Supplier":
                    Supplier supplier = (Supplier)selectedItem;
                    if (supplier.Item.Any())
                    {
                        string itemIds = "";
                        int counter = 1;
                        supplier.Item.ToList().ForEach((_item) => { itemIds += _item.Id.ToString() + (counter < supplier.Item.Count() ? "," : ""); counter++; });
                        if (!silent)
                        {
                            DialogResult result = MessageBox.Show(string.Format("This supplier has a relation with item{0} (id:{1}), if you proceed the item{0} will be deleted aswell\n\nDo you want to proceed?", (supplier.Item.Count() > 1 ? "s" : ""), itemIds), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result != DialogResult.Yes)
                                break; 
                        }
                    }

                    //dbContext.Item.Where(x => x.Supplier_Id == supplier.Id).ToList().ForEach((_item) => { DeleteObject(list, _item, _item.GetType().Name, true); });
                    dbContext.Supplier.Remove(supplier);
                    extraRebuild = () => listShopItems.BuildList();
                    break;
                case "Customer":
                    Customer customer = (Customer)selectedItem;
                    if (customer.Order.Any())
                    {
                        string orderIds = "";
                        int counter = 1;
                        customer.Order.ToList().ForEach((_order) => { orderIds += _order.Id.ToString() + (counter < customer.Order.Count() ? "," : ""); counter++; });
                        if (!silent)
                        {
                            DialogResult result = MessageBox.Show(string.Format("This customer has a relation with order{0} (id:{1}), if you proceed the order{0} will be deleted aswell\n\nDo you want to proceed?", (customer.Order.Count() > 1 ? "s" : ""), orderIds), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result != DialogResult.Yes)
                                break; 
                        }
                    }

                    //dbContext.Order.Where(x => x.Customer_Id == customer.Id).ToList().ForEach((_order) => { DeleteObject(list, _order, _order.GetType().Name, true); });
                    dbContext.Customer.Remove(customer);
                    extraRebuild = () => listShopOrders.BuildList();
                    break;
                case "Category":
                    Category category = (Category)selectedItem;
                    if (category.Item.Any())
                    {
                        string itemIds = "";
                        int counter = 1;
                        category.Item.ToList().ForEach((_item) => { itemIds += _item.Id.ToString() + (counter < category.Item.Count() ? "," : ""); counter++; });
                        if (!silent)
                        {
                            DialogResult result = MessageBox.Show(string.Format("This category has a relation with item{0} (id:{1}), if you proceed the item{0} will be deleted aswell\n\nDo you want to proceed?", (category.Item.Count() > 1 ? "s" : ""), itemIds), "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result != DialogResult.Yes)
                                break;
                        }
                    }

                    //dbContext.Item.Where(x => x.Category_Id == category.Id).ToList().ForEach((_item) => { DeleteObject(list, _item, _item.GetType().Name, true); });
                    dbContext.Category.Remove(category);
                    extraRebuild = () => listShopItems.BuildList();
                    break;
                default:
                    break;
            }

            // Save changes in db
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex is DbUpdateException || ex is DbUpdateConcurrencyException ||
                    ex is DbEntityValidationException || ex is NotSupportedException ||
                    ex is ObjectDisposedException || ex is InvalidOperationException)
                {
                    MessageBox.Show("Something went wrong while saving your changes...\n\nBelow this line is the error message\n-----------\n" + ex, "Error", MessageBoxButtons.OK);
                }
            }

            // Refresh list
            list.BuildList();
            extraRebuild();
        }
    }

    public class ListTypeCombination
    {
        public ObjectListView list { get; }
        public DbSet dbSet { get; }

        public ListTypeCombination(ObjectListView list, DbSet dbSet)
        {
            this.list = list;
            this.dbSet = dbSet;
        }
    }

}