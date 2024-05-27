using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class ForStmt2
    {
        static void Main()
        {
            for (int i = 0, j = 0; i + j < 10; i++, j += 2)
            {
                Console.WriteLine("{0},{1}", i, j);
            }
        }
    }
}
