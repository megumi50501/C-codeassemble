using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    class TestClass6
    {
        readonly string Str;
        readonly int Num;

        public TestClass6(int num, string str)
        {
            this.Num = num;
            this.Str = str;
        }

        //ラムダ式による定義
        public void Output() => Console.WriteLine($"{this.Num} {this.Str}");

        //+演算子のユーザ定義(inキーワードはOK)
        public static TestClass6 operator +(in TestClass6 a, in TestClass6 b) => new(a.Num + b.Num, a.Str + b.Str);
    }

    internal class OverloadIn
    {
        public static void Main()
        {
            var a = new TestClass6(1, "演算子");
            a += new TestClass6(2, "オーバーロード");

            a.Output();     //出力：3　演算子オーバーロード
        }
    }
}
