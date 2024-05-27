using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class TestClass9
    {
        // aの2乗と3乗を求める
        public void TestFunc(int a, out int b, out int c)
        {
            b = a * a;
            c = a * a * a;
        }
    }

    internal class ClsOutParam
    {
        static void Main()
        {
            var test = new TestClass9();

            int x, y;                   // パラメータ変数の初期化は不要

            // パラメータ変数xとyに3の2乗と3乗が代入される
            test.TestFunc(3, out x, out y);

            //test.TestFunc(3, out int x, out var y);


            Console.WriteLine(x);     // 出力値：9
            Console.WriteLine(y);     // 出力値：27
        }
    }
}
