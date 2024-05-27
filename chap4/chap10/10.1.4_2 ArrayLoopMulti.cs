using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    internal class ArrayLoopMulti
    {
        static void Main()
        {
            //2次元配列
            string[,] a = { { "一", "二" }, { "三", "四" }, { "五", "六" } };

            //二次元目の要素数だけ横に表示
            for (var i = 0; i < a.GetLength(0); i++)
            {

                for (var j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine(a[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
