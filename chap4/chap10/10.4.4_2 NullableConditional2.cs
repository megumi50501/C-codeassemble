using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    internal class NullableConditional2
    {
        static void Main()
        {
            var t2 = new Team2();

            //?.演算子と??演算子の組み合わせ
            string n2 = t2.Member?.Name ?? "nothing";
            Console.WriteLine(n2);   //出力：nothing
        }
    }
}
