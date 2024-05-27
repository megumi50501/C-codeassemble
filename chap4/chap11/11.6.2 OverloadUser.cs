using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    class TestClass5
    {
        private readonly int num;
        private readonly string str;

        public TestClass5(int num, string str)
        {
            this.num = num;
            this.str = str;
        }

        public void Output()
        {
            Console.WriteLine(this.num);
            Console.WriteLine(this.str);
        }

        //明示的な変換
        public static explicit operator TestClass5 (int num)
        {
            return new TestClass5(num, "明示的");
        }

        //暗黙的な変換
        public static implicit operator TestClass5(string str)
        {
            return new TestClass5(0, str);
        }
    }

    internal class OverloadUser
    {
        public static void Main()
        {
            //明示的な変換
            var a = (TestClass5)3;
            a.Output();

            //暗黙的な変換
            TestClass5 b = "暗黙的";
            b.Output();
        }
    }
}
