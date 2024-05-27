using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap8
{
    internal class ClsInterfaseDef2
    {
        static void Main()
        {
            var c2 = new B();
            c2.MethodA();               // 出力値：B MethodA

            // キャストしてもclass Bのメソッドが優先される
            ((ISample1)c2).MethodA();   // 出力値：B MethodA
        }
    }
}
