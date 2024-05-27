using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class BaseClass
    {
        public BaseClass(out string s)
        {
            s = "base";
        }
    }

    class DerivedClass : BaseClass
    {

        public DerivedClass(string s1) : base(out var s2)
        {
            // 初期化子で定義したs1は、コンストラクター内だけで有効
            Console.WriteLine(s1 + s2);
        }
    }

    internal class ClsOutBase
    {
        static void Main()
        {
            var c = new DerivedClass("test");   // 出力値：testbase
        }
    }
}
