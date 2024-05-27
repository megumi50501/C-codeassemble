using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap4
{
    internal class Print30pe
    {
        static void Main()
        {
            int x = -5;

            Console.WriteLine(x >= 0 ? x : -x); //出力値：5
            Console.WriteLine(x < 0 ? '負' : '正'); //出力値：負
        }
    }
}
