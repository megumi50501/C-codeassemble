using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap9
{
    internal class ExceptNestChecked
    {
        static void Main()
        {
            try
            {
                ushort x = 300;   //300 = 256 + 44
                byte y;

                unchecked
                {
                    y = (byte)x;     //byte型に変更するとオーバーフローする
                    Console.WriteLine(y);  //出力：44

                    checked
                    {
                        y = (byte)x;    //オーバーフローの例外のスロー
                        Console.WriteLine(y);
                    }
                }
            }
            catch(OverflowException e)   //オーバーフロー例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
