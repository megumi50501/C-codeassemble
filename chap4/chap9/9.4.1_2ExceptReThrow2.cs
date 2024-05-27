using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap9
{
    internal class ExceptReThrow2
    {
        static void Main()
        {
            //tryブロックのネスト
            try
            {
                try
                {
                    int[] a = new int[3];

                    a[0] = 1;
                    a[5] = 2;  //例外(範囲外にアクセス)
                }
                catch (Exception)
                {
                    Console.WriteLine("最初の補足");
                    throw;
                }
            }
            catch(Exception e) //すべての例外の補足
            {
                Console.WriteLine("外側の補足");
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
