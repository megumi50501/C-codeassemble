using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class TestClass6
    {
        //aを3倍にして表示
        public void TestFunc(int a)
        {
            //パラメータの変数aを3倍
            a *= 3;

            Console.WriteLine(a);
        }
    }

    internal class ClsCallValue
    {
        static void Main()
        {
            var test = new TestClass6();
            int a = 5;

            test.TestFunc(a);  //出力値：15
            Console.WriteLine(a);  //出力値：5
        }
    }
}
