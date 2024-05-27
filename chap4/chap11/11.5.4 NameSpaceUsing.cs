using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;
using static System.DateTime;　//構造体も可能

namespace chap11
{
    internal class NameSpaceUsing
    {
        static void Main()
        {
            //System.Math.Sqrtの省略
            var sq = Sqrt(10 * 10);
            WriteLine(sq);           //出力：10

            //System.Date.Nowの省略
            WriteLine(Now);          //出力は現在日時
        }
    }
}
