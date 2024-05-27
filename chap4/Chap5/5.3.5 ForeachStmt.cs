using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class ForeachStmt
    {
        static void Main()
        {
            string[] j = { "グー", "チョキ", "パー" };

            // 配列のデータを1つずつ取得
            foreach (string str in j)
            {
                System.Console.WriteLine(str);
            }
        }
    }
}
