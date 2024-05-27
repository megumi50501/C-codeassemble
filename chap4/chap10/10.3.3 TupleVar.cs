using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//タプル要素名の推論

namespace chap10
{
    internal class TupleVar
    {
        static void Main()
        {
            int x = 1, y = 2;
            var t = (x, y);
            Console.WriteLine(t.x); // 出力値：1
            Console.WriteLine(t.y); // 出力値：2

            // C#7.0では、要素に名前が付かず、次のようにする必要があった
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);
        }
    }
}
