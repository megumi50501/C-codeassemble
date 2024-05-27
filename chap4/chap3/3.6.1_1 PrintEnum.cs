using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap3
{
    internal class PrintEnum
    {
        enum Day
        {
            Sun, Mon, Tue, Wed, Thu, Fri, Sat
        }

        static void Main()
        {
            Console.WriteLine(Day.Sun);      // 出力値：Sun
            Console.WriteLine((int)Day.Sat); // 出力値：6
        }
    }
}
