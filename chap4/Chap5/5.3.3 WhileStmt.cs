using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class WhileStmt
    {
        static void Main()
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(i++);  //実行後：0,1,2と出力された
            }
        }
    }
}
