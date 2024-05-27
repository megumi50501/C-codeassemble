using chap6_chap6all;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    internal class ClsMethod
    {
        //値を返さない、パラメータのないメソッド
        public void PrintOne()
        {
            Console.WriteLine("1");
        }
        static void Main()
        {
            var test = new Chap6all(); //classの後ろの箱(今回はChap6all)を入力。インスタンス生成。
            //.PrintOne(); //PrintOneメソッド呼び出し。
            //出力値：1
        }
    }
}
