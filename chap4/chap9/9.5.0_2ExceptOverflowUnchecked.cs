using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap9
{
    internal class ExceptOverflowUnchecked
    {
        static void Main()
        {
            try
            {
                ushort x = 300;   //300 = 256 + 44
                byte y;

                y = unchecked((byte)x);  //byte型に変換するとオーバーフローする
                Console.WriteLine(y);  //出力：44

                y = checked((byte)x);  //オーバーフロー例外のスロー
                Console.WriteLine(y);
            }
            catch(OverflowException e)  //オーバーフロー例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}