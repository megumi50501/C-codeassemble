using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    internal class ClsRefEase
    {
        static void Main()
        {
            int c = 1;
            int d = 2;

            ref int x = ref c < d ? ref c : ref d;

            x = 5;

            //cの値も書き換わる
            Console.WriteLine(c);
        }
    }
}
