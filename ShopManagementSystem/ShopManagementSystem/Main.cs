using BrightIdeasSoftware;
using ShopManagementSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class formMain : Form
    {
        private bool firstTime = true;
        private ShopmsEntities dbContext = new ShopmsEntities(); // objectListView needs a live context

        public formMain()
        {
            InitializeComponent();

            // Generate dbase rows if there arent any
            // Generates new data if Item table doesnt contain anything (it's OK for now..)
            if (!dbContext.Item.Any())
                Generation.Generate();

            // Initialize data list
            listShopItems.SetObjects(dbContext.Item);
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
        }
    }
}