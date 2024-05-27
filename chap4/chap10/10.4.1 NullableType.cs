using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//null許容型

namespace chap10
{
    internal class NullableType
    {
        static void Main()
        {
            //nullが代入できる
            int? x = null;
            if (!x.HasValue)  //値がないから
            {
                Console.WriteLine("null");  //出力：null
            }
            x = 10;
            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            Console.WriteLine(x == 10);
            Console.WriteLine(x + 10);
        }
    }
}
