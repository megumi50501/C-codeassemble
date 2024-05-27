using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7
{
    internal class ClsPatial
    {
        partial class Sample
        {
            int a = 1;
        }

        partial class Sample
        {
            public void Test()
            {
                Console.WriteLine(a);
            }
        }

        class ClsPartial
        {
            static void Main()
            {
                var testClass = new Sample();

                testClass.Test();  // 出力値：1
            }
        }
    }
}
