using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class LambdaScope
    {
        public static void Main()
        {
            int b = 2;

            //変数bを参照できる
            Action<int> Multi = n => { Console.WriteLine(n * b); };

            Multi(5);        //出力：10
        }
    }
}
