using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class LinqWhere
    {
        static void Main()
        {
            //C:\以下のファイルを取得
            var result = from f in System.IO.Directory.GetFiles(@"C:\")
                         where f.Length < 10 //長さが10未満のもの
                         select f;

            //結果データを表示
            foreach(var x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
