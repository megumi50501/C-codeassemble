using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//レコードの宣言

namespace chap10
{
    internal class RecordInit1
    {
        record Point
        {
            public String Name { get; set; } = "";
            public float Lat { get; init; } = default;
            public float Lon { get; init; } = default;
        }

        static void Main()
        {
            var p1 = new Point();  //既定値で初期化される
            Console.WriteLine(p1);  //ToString()メソッドが呼ばれる
            //出力：Point { Name = , Let = 0, Lon = 0 }

            //オブジェクト初期化子による初期化
            p1 = new Point
            {
                Name = "大阪城",
                Lat = 34.687f,
                Lon = 135.526f
            };
            Console.WriteLine(p1);
            //出力：Point { Name = 大阪城, Lat = 34.687, Lon = 135.526 }
        }
    }
}
