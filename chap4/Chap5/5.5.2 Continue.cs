using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class Continue
    {
        static void Main()
        {
            for (int i = 0; true; i++)
            {
                if (i < 8)
                {
                    continue; //カウンター変数を更新してループの先頭に戻る
                }
                else if (i == 10)
                {
                    break; //ループを中断する
                }
                Console.WriteLine(i);
            }
        }
    }
}
