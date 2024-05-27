using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4
{
    internal class PrintInc
    {
        static void Main()
        {
            int a = 5;

            Console.WriteLine(++a); //出力値：6
            Console.WriteLine(a); //出力値：6

            int b = 5;

            Console.WriteLine(b++); //出力値：5
            Console.WriteLine(b); //出力値：6
        }
    }
}
