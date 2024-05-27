using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class Scope2
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);  //実行すると0，1，2，3，4,0,1,2となる
            }
        }
    }
}
