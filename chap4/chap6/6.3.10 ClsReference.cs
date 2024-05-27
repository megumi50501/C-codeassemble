using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class TestClass7
    {
        // aを３倍して表示する
        public void TestFunc(ref int a)
        {
            a *= 3; // パラメーターの変数aを3倍

            Console.WriteLine(a);
        }
    }

    internal class ClsReference
    {
        static void Main()
        {
            var test = new TestClass7();
            int a = 5;               // 初期化が必要

            test.TestFunc(ref a);  // 出力値：15
            Console.WriteLine(a);  // 出力値：15
        }
    }
}
