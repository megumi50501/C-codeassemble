using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class LambdaShadow
    {
        public static void Main()
        {
            int b = 2;
            LocalFunctionShadow(3);   //出力：9

            static void LocalFunctionShadow(int b)
            {
                Console.WriteLine(b * b);   //bは外側のbとは別の変数
            }
        }
    }
}
