using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class TestClass3
    {
        public int CalcAdd2(int a, int b, int c)
        {
            return a + b + c; // パラメーターのa、b、ｃを加算して返す
        }
    }

    internal class ClsNameParam2
    {
        static void Main()
        {
            var test = new TestClass3();

            // パラメータの混在
            int a = test.CalcAdd2(3, c: 4, b: 2);

            // C# 7.2以降OK
            int b = test.CalcAdd2(a: 3, 4, 1);

            // NG（順序を変更できない）
            //int c = test.CalcAdd2(b: p, a: 3, 1);

            Console.WriteLine(a);               // 出力値：9
            Console.WriteLine(b);               // 出力値：8
        }
    }
}
