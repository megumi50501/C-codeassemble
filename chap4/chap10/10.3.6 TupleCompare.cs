using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//タプル同士の比較

namespace chap10
{
    internal class TupleCompare
    {
        static void Main()
        {
            (int n, string name) t1 = (1, "sample");
            (int num, string str) t2 = (3, "テスト");

            Console.WriteLine(t1 != t2);  //出力：true
            //次のように変換される
            Console.WriteLine(t1.n != t2.num || t1.name != t2.str);  //出力：true

            t1 = t2;
            Console.WriteLine(t1 == t2);  //出力：true
            //次のように変換される
            Console.WriteLine(t1.n == t2.num && t1.name == t2.str);  //出力：true
        }
    }
}
