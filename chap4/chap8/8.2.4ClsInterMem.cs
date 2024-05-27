using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//明示的なインターフェイスメンバの宣言
namespace chap8
{
    interface IBaseInterface5
    {
        void PrintOut(string s);
    }

    interface IBaseInterface6
    {
        void PrintOut(string t);   // INterface1と同じメソッド
    }

    // インターフェイスの実装
    class SampleClass3 : IBaseInterface5, IBaseInterface6
    {
        public void PrintOut(string s)
        {
            Console.WriteLine("Interface0 : " + s);
        }

        // 明示的なインターフェイスの宣言
        void IBaseInterface5.PrintOut(string s)
        {
            Console.WriteLine("Interface1 : " + s);
        }

        // 明示的なインターフェイスの宣言
        void IBaseInterface6.PrintOut(string s)
        {
            Console.WriteLine("Interface2 : " + s);
        }
    }

    internal class ClsInterMem
    {
        static void Main()
        {
            var sc = new SampleClass3();

            sc.PrintOut("4");                   // 出力値："Interface4 : 4"

            IBaseInterface5 ifc1 = (IBaseInterface5)sc;   // インターフェイスに変換
            ifc1.PrintOut("5");                 // 出力値："Interface5 : 5"

            IBaseInterface6 ifc2 = (IBaseInterface6)sc;   // インターフェイスに変換
            ifc2.PrintOut("6");                 // 出力値："Interface6 : 6"
        }
    }
}
