using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class Break
    {
        static void Main()
        {
            for (int i = 0; true; i++)
            {
                if (i == 3) //変数iが3の場合
                {
                    break; //ループを中断する
                }
                Console.WriteLine(i);
            }
        }
    }
}
