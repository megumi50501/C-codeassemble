using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class IfStmt2
    {
        static void Main()
        {
            int x = 15;

            if (x < 10)
            {
                x *= 10;
            }
            else
            {
                x = -x;
            }
            Console.WriteLine(x); //出力値：-15
        }
    }
}
