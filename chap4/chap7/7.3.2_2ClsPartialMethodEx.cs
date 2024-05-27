using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7
{
    internal class ClsPartialMethodEx
    {
        partial class SampleEx
        {
            public partial DateTime DateInfo(); //宣言のみ
        }

        class ClsPartialMethodImpEx
        {
            static void Main()
            {
                Console.WriteLine(new SampleEx().DateInfo()); //出力値：(現在日時)
            }
        }
    }
}
