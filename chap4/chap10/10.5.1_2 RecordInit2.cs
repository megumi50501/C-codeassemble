using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    internal class RecordInit2
    {
        record Point(float Lat, float Lon);

        static void Main()
        {
            var p1 = new Point(34.687f, 135.526f);
            Console.WriteLine(p1.Lat);  //出力：34.687
        }
    }
}
