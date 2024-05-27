using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class YieldReturn
    {
        static void Main()
        {
            IEnumerable<int> factorial(int number)
            {
                if((number < 1) || (100 < number))
                {
                    Console.WriteLine("error");
                    yield break;
                }
                for (int i = number; 0 < i; i--)
                {
                    yield return i;
                }
            }
            foreach(int  v in factorial(101))
            {
                Console.WriteLine(v);   //出力：error
            }
        }
    }
}
