using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap9
{
    internal class ExceptOverflow
    {
        static void Main()
        {
            try
            {
                short a = short.MaxValue; //short型の最大値を入力
                Console.WriteLine(a);

                a++;
                Console.WriteLine(a);  //オーバーフロー
            }
            catch (Exception e)        //すべての例外を捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
