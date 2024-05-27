using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap9
{
    internal class ExceptWhen2
    {
        static void Main()
        {
            int x = 10;
            int y = 0;

            try
            {
                int z = x / y;
            }
            catch (Exception e)    // 2つの例外クラスの指定
                when (e is DivideByZeroException || e is ArithmeticException)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)   // すべての例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
