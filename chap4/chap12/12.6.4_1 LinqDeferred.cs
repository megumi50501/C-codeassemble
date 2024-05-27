using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class LinqDeferred
    {
        static void Main()
        {
            // stringのリスト
            var names = new List<string>() { "Tigers", "Giants", "Dragons" };

            // LINQによるデータの取得
            var result = from n in names select n;

            // 結果データを出力
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("");

            // names[1]とnames[2]を入れ替える
            string tmp = names[1];
            names[1] = names[2];
            names[2] = tmp;

            // 再びデータを出力
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
