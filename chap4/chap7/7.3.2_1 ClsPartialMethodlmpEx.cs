using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7
{
    internal class ClsPartialMethodlmpEx
    {
        partial class SampleEx
        {
            //実装
            public partial DateTime DateInfo()
            {
                return DateTime.Now;
            }
        }
    }
}
