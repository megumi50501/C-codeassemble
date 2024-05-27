using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    public struct Point
    {
        public double lat, lon;

        public Point(double y, double x)
        {
            lon = y;
            lat = x;
        }
    }

    public static class GetMeshCode
    {
        //1次メッシュコードを求める(int型にキャストすることで小数点以下を切り捨てる)
        public static int Mesh1(in this Point p) => (int)(p.lat * 1.5) * 100 + (int)(p.lon - 100);
    }

    internal class ExtendRef
    {
        public static void Main()
        {
            var p = new Point(34.687426, 135.525845);

            Console.WriteLine(p.Mesh1());
        }
    }
}
