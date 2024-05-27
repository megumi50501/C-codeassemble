using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap3_Anonymous;
class Anonymous
{
    static void Main()
    {
        var x = new { Name = "匿名", Age = 18 };

        Console.WriteLine(x.Name); // 出力値：匿名

        // 読み取り専用のためエラーとなる
        // x.Age = 20;
    }

}

