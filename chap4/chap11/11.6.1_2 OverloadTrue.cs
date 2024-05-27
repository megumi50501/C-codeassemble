using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    class TestClass4
    {
        private readonly int num;
        private readonly string? str;

        public TestClass4(int num, string? str)
        {
            this.num = num;
            this.str = str;
        }

        // true演算子の定義
        public static bool operator true(TestClass4 a)
        {
            return (a.num != 0) && (a.str != null);
        }

        // false演算子の定義
        public static bool operator false(TestClass4 a)
        {
            return (a.num == 0) && (a.str == null);
        }
    }

    internal class OverloadTrue
    {
        //true,falseの判定
        public static void BoolTest(TestClass4 t)
        {
            //true演算子で判断
            if (t)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        public static void Main()
        {
            var a = new TestClass4(1, "演算子");
            var b = new TestClass4(0, null);

            BoolTest(a);    //出力：true
            BoolTest(b);    //出力：false
        }
    }
}
