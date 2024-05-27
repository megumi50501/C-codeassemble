using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class Span
    {
        static void Main()
        {
            //int型の配列
            var dartaary = new int[] { 2020,7, 24, 9 ,0 };

            //dartaaryの2番目(1番目は0)から2要素分の参照
            var span = new Span<int>(dartaary, 1, 2);

            foreach (var d in span)
            {
                Console.WriteLine(d);  //出力：724
            }

            span[0] = 5;   //span構造体の要素を更新

            foreach(var d in dartaary)
            {
                Console.WriteLine(d);   //出力：202052490
                //元の配列の値が書き換わっている
            }

            //文字列から作成(3番目から1文字目)
            var span2 = "Microsoft".AsSpan().Slice(2, 1);
            Console.WriteLine(span2[0]);  //出力：c

            //span2はReadOnluSpanなので書き換えできない
            //span2[0] = "a";
        }
    }
}
