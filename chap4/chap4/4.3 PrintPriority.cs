using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4
{
    internal class PrintPriority
    {
        static void Main()
        {
            int a, b = 2;

            // a = b *= 5 + 10;  これだとなぜ結果が30になるのかが分かりにくい。
            // a = (b *= (5 + 10)); 手順1
            //a =　b = (b * (5 + 10)); bが2なので最終的に。手順2
            a = b = 30;
            Console.WriteLine(a);
        }
    }
}
