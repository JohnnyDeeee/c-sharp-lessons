using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem
{
    partial class Item
    {
        public string FormattedStock { get { return Stock > 0 ? Stock.ToString() : "Out of stock!"; } }
    }
}
