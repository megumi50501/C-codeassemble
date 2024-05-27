using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class TestClass
    {
        // 2つのパラメーターを受け取ってint型の値を返すメソッド
        public int CalcAdd(int a, int b)
        {
            return a + b; // パラメーターのaとbを加算して返す
        }
    }

    internal class ClsMethodParam
    {
        static void Main()
        {
            var test = new TestClass();

            int p = 4;
            int a = test.CalcAdd(3, p);   // メソッドの呼び出し

            Console.WriteLine(a);         // 出力値：7
        }
    }
}
