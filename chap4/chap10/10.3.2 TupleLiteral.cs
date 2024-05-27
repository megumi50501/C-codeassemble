using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//タプル型のリテラル

namespace chap10
{
    internal class TupleLiteral
    {
        static void Main()
        {
            //タプル型の戻り値
            (string name, int age) GetMember()
            {
                var n = "Wings";
                var a = 18;
                return (n, a);   //タプル型のリテラル
            }
            var m = GetMember();
            Console.WriteLine(m.name);  //出力：Wings 
            Console.WriteLine(m.age);   //出力：１８
        }
    }
}
