using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ジェネリック型の型スイッチ

namespace chap8
{
    internal class ClsCaseWhen2
    {
        static void Main(string[] args)
        {
            string testString<T>(T prm)
            {
                switch (prm)
                {
                    // 変数prmがstring型なら、変数tmpを定義してそれを返す
                    case string tmp:
                        return tmp;

                    default:
                        return "Number";
                }
            }
            Console.WriteLine(testString(123));   // 出力値：Number
            Console.WriteLine(testString("123")); // 出力値：123
        }
    }
}
