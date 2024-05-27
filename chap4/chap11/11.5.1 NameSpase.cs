using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class NameSpase;
    namespace Space1
    {
        class Class1
        {
            public static void Output()
            {
                Console.WriteLine("Space1.Class1");
            }
        }
    }

    namespace Space2
    {
        class Class2
        {
            public static void Output()
            {
                Console.WriteLine("Space2.Class2");
            }
        }
    }

    namespace Space1
    {
        class Class3
        {
            public static void Output()
            {
                Console.WriteLine("Space1.Class3");
            }
        }
    }

    namespace SampleSpace
    {
        class Class1
        {
            static void Main()
            {
                Space1.Class1.Output(); // 出力値：Space1.Class1
                Space2.Class2.Output(); // 出力値：Space2.Class2
                Space1.Class3.Output(); // 出力値：Space1.Class3
            }
        }
    }
}
