using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    class TestClass3
    {
        private readonly int num;
        private readonly string str;

        public TestClass3(int num, string str)
        {
            this.num = num;
            this.str = str;
        }

        public void Output()
        {
            Console.WriteLine(this.num);
            Console.WriteLine(this.str);
        }

        //+演算子のユーザ定義
        public static TestClass3 operator + (TestClass3 a, TestClass3 b)
        {
            return new TestClass3(a.num + b.num, a.str + b.str);
        }
    }

    internal class OverloadBinary
    {
        public static void Main()
        {
            var a = new TestClass3(1,"演算子");
            var b = new TestClass3(2,"オーバーロード");

            var c = a + b;
            c.Output();
        }
    }
}
