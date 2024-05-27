using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//System.Arrayクラスのメソッド

namespace chap10
{
    internal class ArrayMethod
    {
        //配列を横一列に表示する
        public static void PrintArray(int[] a)
        {
            foreach (var x in a)
            {
                Console.WriteLine("{0}", x);
            }
            Console.WriteLine("");
        }

        static void Main()
        {
            int[] arr = { 22, -14, 2, -17, 41, 6, 29 };

            //配列を定義通りに表示する
            PrintArray(arr);

            //配列を昇順に並べる
            Array.Sort(arr);
            PrintArray(arr);

            //配列を反転する(昇順になっていたので降順になる)
            Array.Reverse(arr);
            PrintArray(arr);
        }
    }
}
