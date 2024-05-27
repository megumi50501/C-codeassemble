using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//null許容参照型

namespace chap10
{
    internal class NullableEnable
    {
#nullable enable
        class Simple  //NG：警告
        {
            public string Name { get; set; }
        }
        static void Main()
        {
            string s1 = null;     //NG:警告
            string s2 = default;  //NG:警告

            string? str1 = null;  //OK

            var v = new Simple();
        }
    }
}
