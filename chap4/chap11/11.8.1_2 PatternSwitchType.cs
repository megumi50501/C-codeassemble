using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class PatternSwitchType
    {
        static void Main()
        {
            object test = "test";

            // 型のパターンマッチング
            var str = test switch
            {
                // int _ => "int", // C#8での書き方
                int => "int",
                long => "long",
                string => "string",
                _ => "none"
            };
            Console.WriteLine(str);// 出力：string
        }
    }
}
