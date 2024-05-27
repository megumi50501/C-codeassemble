using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    internal class RecordEquals
    {
        record Point(String Name, float Lat, float Lon);

        class CPoint
        {
            public String Name { get; init; } = "";
            public float Lat { get; init; } = default;
            public float Lon { get; init; } = default;
        }

        static void Main()
        {
            var c1 = new CPoint();
            var c2 = new CPoint();
            Console.WriteLine(c1 == c2);  //出力：False
            Console.WriteLine(c1 != c2);  //出力：True

            //レコードの比較
            var p1 = new Point("", 0f, 0f);
            var p2 = new Point("", 0f, 0f);
            Console.WriteLine(p1 == p2);  //出力：True
            Console.WriteLine(p1 != p2);  //出力：False
        }
    }
}
