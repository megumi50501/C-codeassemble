using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    //SampleDelという名前のデリゲートを定義
    delegate void SampleDel2(int x);

    class TestClass1
    {
        public void TestMethod1(int n)
        {
            Console.WriteLine(n);
        }

        //静的メソッド
        public static void TestMethod2(int n)
        {
            Console.WriteLine(n * 2);
        }
    }

    internal class DelegateParam
    {
        //デリゲート型変数をパラメータとしたメソッド
        public static void MethodCallback(int p, SampleDel delVar)
        {
            //デリゲートを介したメソッドの呼び出し
            delVar(p);
        }

        public static void Main()
        {
            var t = new TestClass1();

            //パラメータとしてメソッドを渡す
            MethodCallback(10, t.TestMethod1);          //出力：10
            MethodCallback(10, TestClass1.TestMethod2);　//出力：20
        }
    }
}
