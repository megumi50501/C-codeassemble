using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4
{
    internal class PrintBit
    {
        static void Main()
        {
            int a = 0b0000_0010; //10進数では2
            int b = 0b0000_1111; //10進数では15

            Console.WriteLine(Convert.ToString(a & b, 2));
            Console.WriteLine(Convert.ToString(a | b, 2));
            Console.WriteLine(Convert.ToString(a ^ b, 2));
            Console.WriteLine(Convert.ToString(~a, 2));
        }
    }
}
