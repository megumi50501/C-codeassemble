using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4
{
    internal class PrintShift
    {
        static void Main()
        {
            int a = 162; //16進数では0xA2

            //2進数文字列に変換
            Console.WriteLine(Convert.ToString(a, 2));
            Console.WriteLine(Convert.ToString(a << 3, 2));
            Console.WriteLine(Convert.ToString(a >> 3, 2));
        }
    }
}
