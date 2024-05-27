using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class PatternComb
    {
        public static void Main()
        {
            //パターンの組み合わせ
            static string chkvalue(int v) => v switch
            {
                < 2 => "弱い",　　　　　　　　　　//2未満
                >= 2 and < 10 => "普通の",  　    //2以上10未満
                >= 10 and < 20 => "やや強い",   　//10以上20未満
                >= 20 and < 30 => "強い",　　　　 //20以上30未満
                _ => "激しい"                 　  //上記以外
            };

            for(int i = 1; i < 40; i += 10)
            {
                Console.WriteLine($"雨量{i}mmは{chkvalue(i)}雨です");

                //出力：
                //雨量1mmは弱い雨です。
                //雨量は11mmやや強い雨です。
                //雨量は21mm強い雨です。
                //雨量は31mm激しい雨です。
            }
        }
    }
}
