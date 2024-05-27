using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7
{
    internal class ClsPartialMethodlmp
    {
        partial class Sample
        {
            static partial void LogInfo()
            {
                Console.WriteLine("debug");
            }
        }
    }
}
