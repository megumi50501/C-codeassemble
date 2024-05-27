using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6 //静的クラス
{
    static class TestClass2
    {
        // 静的メンバー
        public static int a;

        // 静的コンストラクター
        static TestClass2()
        {
            a = 5;
        }

        // 静的メソッド
        public static void Display()
        {
            Console.WriteLine(a); // 静的メソッドの呼び出し
        }
    }

    class ClsStaticClass
    {
        static void Main()
        {
            TestClass2.Display(); // 出力値：5
        }
    }
}
