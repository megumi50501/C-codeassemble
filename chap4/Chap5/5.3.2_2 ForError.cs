using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class ForError
    {
        static void Main()
        {
            string[] j = { "グー", "チョキ", "パー" };

            // 配列の範囲を超えているので、実行時にエラーとなる。
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(j[i]);
            }
        }
    }
}
