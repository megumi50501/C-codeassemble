using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class DoStmt
    {
        static void Main()
        {
            int i = 10;
            do
            {
                Console.WriteLine(++i); //出力結果は11
            }
            while (i < 5);
        }
    }
}
