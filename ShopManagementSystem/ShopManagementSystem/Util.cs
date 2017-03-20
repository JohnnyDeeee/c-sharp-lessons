using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagementSystem
{
    static class Util
    {
        private static Random rand = new Random();

        // Returns a random decimal value
        // source: http://www.java2s.com/Code/CSharp/Development-Class/ReturnsarandomDecimalvalue.htm
        public static decimal RandomDecimal(int min = 0, int max = 100)
        {
            return rand.Next(min, max) / 13.6m;
        }
    }
}
