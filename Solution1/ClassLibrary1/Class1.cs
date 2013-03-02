using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static decimal Add(string a, string b)
        {
            decimal x;
            decimal y;

            decimal.TryParse(a, out x);
            decimal.TryParse(b, out y);

            return Add(x, y);
        }
    }
}
