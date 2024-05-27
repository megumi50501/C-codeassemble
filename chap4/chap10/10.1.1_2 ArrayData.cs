using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    internal class ArrayData
    {
        static void Main()
        {
            int[] array2 = { 1, 3, 5 };
            string[] weekDays ={"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

            Console.WriteLine(weekDays[array2[1]]);    //出力:Wed
        }
    }
}
