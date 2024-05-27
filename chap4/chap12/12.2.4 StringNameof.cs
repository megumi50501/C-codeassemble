using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class StringNameof
    {
        static void Main()
        {
            void test (string? chk_str)
            {
                if (chk_str == null)
                {
                    throw new ArgumentNullException(nameof(chk_str));
                }
            }
            try
            {
                test(null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //出力：Value cannot be null. (Parameter 'chk_str)
                //意味：値をnullにすることはできない(パラメータ名：chk_str)
            }
        }
    }
}
