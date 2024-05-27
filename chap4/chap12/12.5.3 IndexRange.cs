﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class IndexRange
    {
        static void Main()
        {
            var dartaary = new int[] { 2020, 7, 24, 9, 0 };

            //最後から3番目
            Console.WriteLine(dartaary[^3]);  //出力：24

            //2～3番目
            var span = dartaary.AsSpan()[1..3];

            foreach (var d in span)
            {
                Console.Write(d);  //出力：724
            }
        }
    }
}
