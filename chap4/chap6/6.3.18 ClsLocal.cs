using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    internal class ClsLocal
    {
        static void Main()
        {
            // int型の値を返すメソッド
            int AddNums(int a, int b)
            {
                return a + b;
            }

            for (int i = 0; i < 3; i++)
            {
                int a = AddNums(i, 2);
                Console.Write(a);  // 出力値：234
            }
        }
    }
}
