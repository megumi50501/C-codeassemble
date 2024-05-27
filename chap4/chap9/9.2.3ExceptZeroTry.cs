using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//try-finally

namespace chap9
{
    internal class ExceptZeroTry
    {
        static void Main()
        {
            try { 
              Console.WriteLine("try");
            }
            finally
            {
              Console.WriteLine("try");
            }
        }
    }
}


