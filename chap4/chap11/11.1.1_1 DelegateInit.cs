using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    //SampleDelという名前のデリゲートを定義
    delegate void SampleDel(int x);

    internal class DelegateInit
    {
        //実際に呼ばれるメソッド
        static void TestMethod(int n)
        {
            Console.WriteLine(n);
        }

        public static void Main()
        {
            //SampleDel型の変数を宣言
            SampleDel delVar;

            //デリゲート型の変数のインスタンス化(メソッド本体を登録)
            delVar = new SampleDel(TestMethod);

            //デリゲートを介してメソッドが呼び出される
            delVar(123);   //出力：123

            /* こういう書き方もある
             //SampleDel型の変数の宣言とメソッドの代入
             SampleDel delVar = new SampleDel(TestMethod);

            //省略型
            SampleDel delVar = TestMethod;
             */
        }
    }
}
