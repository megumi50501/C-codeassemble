using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7
{
    internal class ClsPartialMethod
    {
        partial class Sample
        {
            static partial void LogInfo();

            static void Main()
            {
                LogInfo();

                Console.WriteLine("Hello"); // 出力値：Hello
            }
        }
    }
}
