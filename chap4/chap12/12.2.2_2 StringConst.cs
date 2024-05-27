using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class StringConst
    {
        static void Main()
        {
            const string C1 = "日経";
            const string C2 = $"{C1}{" "}太郎";
            const string C3 = $"私の名前は{C2}です。";

            Console.WriteLine(C3);  //出力：私の名前は日経　太郎です。
        }
    }
}
