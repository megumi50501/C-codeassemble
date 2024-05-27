using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class Scope1
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // 変数iは存在しないというコンパイルエラーになる
            // Console.WriteLine(i); //実行すると0，1，2，3，4となる
        }
    }
}
