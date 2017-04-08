using BrightIdeasSoftware;
using ShopManagementSystem;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
                return item.Name.Contains(toolStripSearch.Text) || // Name
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
            Console.WriteLine(list.Name);

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
                pick.CustomFormat = "dd-mm-yyyy hh:mm:ss";
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