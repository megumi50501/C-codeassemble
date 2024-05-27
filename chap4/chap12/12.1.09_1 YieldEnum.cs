using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class YieldEnum
    {
        static void Main()
        {
            //1～Numberまでを列挙する関数
            IEnumerable<int> factorial(int number)
            {
                for(int i = number; 0 < i; i--)
                {
                    yield return i;
                }
            }
            foreach (int v in factorial(3))
            {
                Console.WriteLine(v);
            }
        }
    }
}
