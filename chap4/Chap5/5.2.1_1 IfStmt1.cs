using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class IfStmt1
    {
        static void Main()
        {
            int x = 5;

            if (x < 10) //xが10より小さい場合
            {
                x *= 10;　//xを10倍する
            }
            Console.WriteLine(x); //出力値：50
        }
    }
}
