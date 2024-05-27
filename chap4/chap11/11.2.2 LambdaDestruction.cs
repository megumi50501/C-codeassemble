using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class LambdaDestruction
    {
        public static void Main()
        {
            //1つの_は、パラメータとして使える
            Func<int, int, int> func1 = (_, p) => _ * p;

            //2つの_は、破棄の意味になる
            Func<int, int, int> func2 = (_, _) => 0;

            Console.WriteLine(func1(5, 2));   //出力：10
            Console.WriteLine(func2(5, 2));   //出力：0
        }
    }
}
