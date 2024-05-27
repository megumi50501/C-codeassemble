using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class GenericListInit
    {
        static void Main()
        {
            //コレクション初期化子を用いた定義
            var list = new List<string>() { "Hello", "World", "Good-Bye" };

            //foreachによるデータ参照
            foreach(var s in list)
            {
                Console.WriteLine(s);
            }
        }
    }
}
