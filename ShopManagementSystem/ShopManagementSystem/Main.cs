using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ShopManagementSystem
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            // Generate dbase rows if there arent any
            using (var context = new ShopmsEntities())
            {
                // Generates new data if Item table doesnt contain anything (it's OK for now..)
                if (!context.Item.Any())
                    Generation.Generate();

                // Initialize data list
                //foreach (Item item in context.Item)
                //{
                //    listShopItems.Items.Add(item.Name + " - " + item.Price); // TODO: Create columns in list
                //}
                listShopItems.SetObjects(context.Item);
            }
        }
    }
}
