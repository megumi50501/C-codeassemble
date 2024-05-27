using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//??演算子

namespace chap10
{
    //null許容参照型を使用しない
#nullable enable
    internal class NullableCoalescing
    {
        static void Main()
        {
            int? a = null;
            Console.WriteLine(a ?? 10);  //出力：10

            a = 5;
            Console.WriteLine(a ?? 10);  //出力：5

            //参照型でも使える
            string s = null;
            Console.WriteLine(s ?? "Empty");  //出力：Empty

            //sがnullなら右辺が代入される
            s ??= "空の文字列";
            Console.WriteLine(s);
        }
    }
}
