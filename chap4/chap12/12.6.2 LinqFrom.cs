using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class LinqFrom
    {
        static void Main()
        {
            // c:\以下のファイルを取得
            var result = from f in System.IO.Directory.GetFiles(@"c:\") select f;

            // 結果データを表示
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
