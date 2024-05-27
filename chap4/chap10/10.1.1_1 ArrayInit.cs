using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    internal class ArrayInit
    {
        static void Main()
        {
            //int型の配列の定義
            int[] array = new int[10];

            //代入
            array[0] = 1;
            array[1] = 2;

            //参照
            Console.WriteLine(array[0] + array[1]); //出力：3
        }
    }
}
