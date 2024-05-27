using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    // SampleDelという名前のデリゲートを定義
    delegate void SampleDel3(int x);

    internal class DelegateAnon
    {
        public static void Main()
        {
            //匿名メソッドを使ったデリゲート型の変数の定義
            SampleDel delVar = delegate (int n) { Console.WriteLine(n); };
            delVar(123);        // 出力値：123
        }
    }
}
