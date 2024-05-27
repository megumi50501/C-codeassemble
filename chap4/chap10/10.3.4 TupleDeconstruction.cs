using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//タプルの分解

namespace chap10
{
    internal class TupleDeconstruction
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

            //戻り値のタプルを分解しつつ、2つも変数に代入する
            (string name, int age) = GetMember();
            Console.WriteLine(name);  //出力：Wings
            Console.WriteLine(age);   //出力：18

            //型推論
            (var name1, var age1) = GetMember();
            //次のようにも書ける
            // var (name1, age1) = GetMember();

            //不要な値は_で受け取る
            (_, int age2) = GetMember();
            Console.WriteLine(age2);   //出力：18
        }
    }
}
