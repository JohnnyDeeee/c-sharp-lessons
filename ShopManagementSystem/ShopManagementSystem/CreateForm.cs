using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class CreateForm : Form
    {
        private ShopmsEntities dbContext;

        public CreateForm(object createType, ShopmsEntities dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;

            panelCategory.Visible = false;
            panelCustomer.Visible = false;
            panelItem.Visible = false;
            panelOrder.Visible = false;
            panelSupplier.Visible = false;

            if ((createType as Type).Name == typeof(Category).Name)
                panelCategory.Visible = true;
            else if ((createType as Type).Name == typeof(Customer).Name)
                panelCustomer.Visible = true;
            else if ((createType as Type).Name == typeof(Item).Name)
            {
                panelItem.Visible = true;
                numItemPrice.Maximum = decimal.MaxValue;
                numItemStock.Maximum = decimal.MaxValue;
                dbContext.Category.ToList().ForEach((category) => { comboItemCategory.Items.Add(category.Name); });
                dbContext.Supplier.ToList().ForEach((supplier) => { comboItemSupplier.Items.Add(supplier.Id); });
            }
            else if ((createType as Type).Name == typeof(Order).Name)
            {
                panelOrder.Visible = true;
                // TODO: Most of the handlers are the same as in Main.cs, so maybe make it central somewhere
                listOrderOrderrules.CellEditStarting += new CellEditEventHandler(this.list_cellEditStarting);
                listOrderOrderrules.CellEditValidating += new CellEditEventHandler(this.list_cellEditValidating);
                listOrderOrderrules.CellEditFinishing += new CellEditEventHandler(this.list_cellEditFinishing);

                dbContext.Customer.ToList().ForEach((customer) => { comboOrderCustomerIds.Items.Add(customer.Id); });
                dateOrderTimeDate.Value = DateTime.Now;
            }
            else if ((createType as Type).Name == typeof(Supplier).Name)
                panelSupplier.Visible = true;

            // Set window title
            Text = "Create " + (createType as Type).Name;
        }

        private void list_cellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column.AspectName == "Item_Id")
            {
                ComboBox cbox = new ComboBox();
                dbContext.Item.ToList().ForEach((item) => { cbox.Items.Add(item.Id); });
                cbox.SelectedItem = e.Value;
                cbox.Bounds = e.CellBounds;
                e.Control = cbox;
            }
            // TODO: Make sure you cannot order more than the items stock by adding 2 rules
            // with the same ID and the max stock..
            else if (e.Column.AspectName == "Amount")
            {
                Orderrule rule = (e.RowObject as Orderrule);
                NumericUpDown num = new NumericUpDown();
                num.Minimum = 1;
                num.Maximum = dbContext.Item.Where(x => x.Id == rule.Item.Id).FirstOrDefault().Stock;
                num.Value = Convert.ToDecimal(e.Value);
                num.Bounds = e.CellBounds;
                e.Control = num;
            }
        }

        private void list_cellEditValidating(object sender, CellEditEventArgs e)
        {
            if (e.Column.AspectName == "Item_Id")
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

        private void list_cellEditFinishing(object sender, CellEditEventArgs e)
        {
            if (e.Column.AspectName == "Item_Id")
            {
                Orderrule orderrule = (Orderrule)e.RowObject;
                int id = Convert.ToInt32((e.Control as ComboBox).SelectedItem);
                orderrule.Item = dbContext.Item.First(x => x.Id == id);
                orderrule.Item_Id = orderrule.Item.Id;
                listOrderOrderrules.RefreshItem(e.ListViewItem);

                e.Cancel = true;
            }
        }

        // Add row to list
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Orderrule rule = new Orderrule();
            rule.Item = dbContext.Item.Where(x => x.Stock > 0).FirstOrDefault(); // Make sure we dont choose an item that is not available
            rule.Item_Id = rule.Item.Id;
            rule.Amount = 1;
            rule.Order_Id = dbContext.Order.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1; // This is gonna be the id for the current Order
            listOrderOrderrules.AddObject(rule);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (panelOrder.Visible)
            {
                // Create new order with specified info
                Order order = new Order();
                int customerId = Convert.ToInt32(comboOrderCustomerIds.SelectedItem);
                order.Customer_Id = dbContext.Customer.Where(x => x.Id == customerId).FirstOrDefault().Id;
                order.Date = dateOrderTimeDate.Value;

                // Add the orderrule(s) to this order
                for (int i = 0; i < listOrderOrderrules.GetItemCount(); i++)
                {
                    Orderrule rule = listOrderOrderrules.GetItem(i).RowObject as Orderrule;
                    order.Orderrule.Add(rule);

                    // Update the item stock accordingly
                    dbContext.Item.Where(x => x.Id == rule.Item.Id).FirstOrDefault().Stock -= (int)rule.Amount;
                }

                dbContext.Order.Add(order);
            }
            else if (panelCategory.Visible)
            {
                // Create new Category
                Category category = new Category();
                category.Name = textCategoryName.Text;
                category.Description = textCategoryDescription.Text;

                dbContext.Category.Add(category);
            }
            else if (panelItem.Visible)
            {
                // Create new Item
                Item item = new Item();
                item.Name = textItemName.Text;
                item.Description = textItemDescription.Text;
                string categoryName = comboItemCategory.SelectedItem.ToString();
                item.Category_Id = dbContext.Category.Where(x => x.Name == categoryName).FirstOrDefault().Id;
                item.Price = numItemPrice.Value;
                int supplierId = Convert.ToInt32(comboItemSupplier.SelectedItem.ToString());
                item.Supplier_Id = dbContext.Supplier.Where(x => x.Id == supplierId).FirstOrDefault().Id;
                item.Stock = (int)numItemStock.Value;

                dbContext.Item.Add(item);
            }
            else if (panelSupplier.Visible)
            {
                // Create new Supplier
                Supplier supplier = new Supplier();
                supplier.Name = textSupplierName.Text;
                supplier.Address = textSupplierAddress.Text;
                supplier.Zipcode = textSupplierZipcode.Text;

                dbContext.Supplier.Add(supplier);
            }
            else if (panelCustomer.Visible)
            {
                // Create new Customer
                Customer customer = new Customer();
                customer.Name = textCustomerName.Text;
                customer.Address = textCustomerAddress.Text;
                customer.Zipcode = textCustomerZipcode.Text;
                customer.Phone = textCustomerPhone.Text;

                dbContext.Customer.Add(customer);
            }

            dbContext.SaveChanges();
            Close();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listOrderOrderrules.RemoveObject(listOrderOrderrules.SelectedObject);
        }
    }
}
