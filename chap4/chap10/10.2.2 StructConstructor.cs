using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    struct Simple2
    {
        public int Number;
        public string Name;

        //パラメータ付きのコンストラクタ
        public Simple2(int n, string s)
        {
            Number = n;
            Name = s;
        }
        //C# 10.0では定義可。
        public Simple2()
        {
            Number = -1;
            Name = "既定";
        }
    }

    internal class StructConstructor
    {
        static void Main()
        {
            //既定のコンストラクタが呼び出される
            var s0 = new Simple2();
            Console.WriteLine(s0.Number);   //出力：-1
            Console.WriteLine(s0.Name);     //出力：既定

            //既定値で初期化される
            Simple2 s1 = default;
            Console.WriteLine(s1.Number);   //出力：0
            Console.WriteLine(s1.Name);     //何も出力されない

            //明示的にコンストラクタを呼び出す
            var s2 = new Simple2(1, "testname");

            Console.WriteLine(s2.Number);   //出力：1
            Console.WriteLine(s2.Name);     //出力：testname

            //コンストラクタは呼ばれない
            Simple2 ss;

            //メンバが未定義でコンパイルエラー
            //Console.WriteLine(ss.Name);
        }
    }
}
