using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//特定の例外のキャッチ

namespace chap9
{
    internal class ExceptZeroCatch
    {
        static void Main()
        {
            int x = 10;
            int y = 0;

            try
            {
                int z = x / y;
            }
            catch (DivideByZeroException e)    // ゼロ除算例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
            catch (ArithmeticException e)      // 算術演算例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                // すべての例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
