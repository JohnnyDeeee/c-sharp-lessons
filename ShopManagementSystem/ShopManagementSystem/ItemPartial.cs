using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem
{
    partial class Item
    {
        // Most of these functions are used for the ObjectListView AspectNames (they are kinda hacks)
        public string FormattedStock { get { return Stock > 0 ? Stock.ToString() : "Out of stock!"; } }
        public string CategoryName { get { return Category.Name; } }
    }
}
