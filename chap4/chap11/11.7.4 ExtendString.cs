using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    public static class StringExtener
    {
        //拡張メソッド(16進文字列を数値型に変換)
        public static int Hex2Int(this string s)
        {
            return Convert.ToInt32(s, 16);
        }
    }

    internal class ExtendString
    {
        static void Main()
        {
            var s = "D3";
            Console.WriteLine(s.Hex2Int());  //出力：211
        }
    }
}
