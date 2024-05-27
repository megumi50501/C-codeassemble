using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class GenericWhere
    {
        static void Main()
        {
            // Tは、IEnumerableインターフェイスの制約つき
            void ListPrint<T>(in T col) where T : IEnumerable
            {
                // IEnumerableインターフェイスなので、foreachループが使える
                foreach (var v in col)
                {
                    Console.WriteLine(v);
                }
            }

            var list = new List<string>() { "Hello", "World", "Good-Bye", "3", "4" };

            ListPrint(list); // 出力：HelloWorldGood-Bye
        }
    }
}
