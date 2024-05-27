/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace chap6_chap6all
{
    internal class Chap6all
    {
       

        -----------省略可能パラメータ-------------------
        class TestClass
        {
            // 省略可能なパラメーターを持つメソッド
            public void PrintName(int no, string name = "nanashi")
            {
                Console.WriteLine(no + "→" + name);
            }
        }

        class ClsOptional
        {
            static void Main()
            {
                var test = new TestClass();

                test.PrintName(10); // test.SampleMethod( 10, "nanashi" );と同じ意味
                                    // 出力値：10→nanashi
            }
        }*/

        /*-----------可変パラメータ-------------------
        class TestClass
        {
            //int型の可変パラメータを合計する
            public int SumAll(params int[] numary)
            {
                int sum = 0;
                // numaryの要素をforeachで取り出して合計する
                foreach (int n in numary)
                {
                    sum += n;
                }

                return sum; //合計値を返す。
            }
        }
        class ClsVariable
        {
            static void Main()
            {
                var test = new TestClass();

                Console.WriteLine(test.SumAll(1, 2));　//出力値：3
                Console.WriteLine(test.SumAll(5, 10, 15)); //出力値：30
                Console.WriteLine(test.SumAll()); //出力値：0
            }
        }*/

        /*-----------値渡し(call by value)-------------------
        class TestClass
        {
            //aを3倍にして表示
            public void TestFunc(int a)
            {
                //パラメータの変数aを3倍
                a *= 3;

                Console.WriteLine(a);
            }
        }
        class ClsCallvalue
        {
            static void Main()
            {
                var test = new TestClass();
                int a = 5;

                test.TestFunc(a);  //出力値：15
                Console.WriteLine(a);  //出力値：5
            }
        }*/

        /*-----------参照渡し(call by reference)-------------------
        class TestClass7
        {
            // aを３倍して表示する
            public void TestFunc(ref int a)
            {
                a *= 3; // パラメーターの変数aを3倍

                Console.WriteLine(a);
            }
        }

        class ClsReference
        {
            static void Main()
            {
                var test = new TestClass7();
                int a = 5;               // 初期化が必要

                test.TestFunc(ref a);  // 出力値：15
                Console.WriteLine(a);  // 出力値：15
            }
        }*/

        /*-----------in パラメータ修飾子-------------------
        class ClsInParam
        {
            public static void Main()
            {
                void TestMethod(in int num, out string s)
                {
                    // 以下のように値を変更すると、エラーとなる
                    // num = 48;

                    if (num == 46)
                    {
                        s = "keyaki";
                    }
                    else
                    {
                        s = "abc";
                    }
                }

                var n = 46;
                var str = "none";

                TestMethod(n, out str); // inキーワードは省略できる

                Console.WriteLine(str); // 出力値：keyaki
            }
        }*/

        /*-----------参照による戻り値の定義-------------------
        class TestClass8
        {
            // aを３倍する
            public ref int TestFunc(ref int a)
            {
                a *= 3;
                return ref a; // 参照で返す
            }
        }

        class ClsRefParam
        {
            static void Main()
            {
                var test = new TestClass8();

                int a = 5;

                ref int b = ref test.TestFunc(ref a); // 戻り値は、変数aの参照
                Console.WriteLine(a);  // 出力値：15
                Console.WriteLine(b);  // 出力値：15

                b = 10;
                Console.WriteLine(a);  // 出力値：10
                Console.WriteLine(b);  // 出力値：10
            }
        }*/



        /*-----------参照による制限緩和③-------------------
        class TestClass9
        {
            // 2つのパラメーターを受け取ってint型の値を返すメソッド
            public int CalcAdd(int a, int b)
            {
                return a + b; // パラメーターのaとbを加算して返す
            }
            public int CalcAdd2(int a, int b, int c)
            {
                return a + b + c; // パラメーターのa、b、ｃを加算して返す
            }

            public int RefCalcAdd(in int a, in int b)
            {
                ref readonly int ra = ref a;
                ref readonly int rb = ref b;

                // NG 値を書き換えられない
                // ra++;

                return ra + rb; // パラメーターのaとbを加算して返す
            }

        }

        class ClsRefEase
        {
            static void Main()
            {
                var test = new TestClass9();

                int c = 1;
                int d = 2;

                ref int x = ref c < d ? ref c : ref d;

                x = 5;
                // cの値も書き換わる
                Console.WriteLine(c);               // 出力値：5
            }
        }*/

        /*-----------参照による再代入-------------------
        class ClsRefReSub
        {
            static void Main()
            {
                var test = new Chap6all();

                int e = 1;
                int f = 2;
                ref int g = ref e;

                g = 5;
                // eの値が書き換わる
                Console.WriteLine(e);               // 出力値：5

                // 再代入（参照先を変数fに変更）
                g = ref f;
                g = 10;

                // fの値が書き換わる
                Console.WriteLine(f);               // 出力値：10
                                                    // eの値はそのまま
                Console.WriteLine(e);               // 出力値：5
            }
        }*/

        /*-----------outキーワード-------------------
        class TestClass
        {
            // aの2乗と3乗を求める
            public void TestFunc(int a, out int b, out int c)
            {
                b = a * a;
                c = a * a * a;
            }
        }

        class ClsOutParam
        {
            static void Main()
            {
                var test = new TestClass9();

                int x, y;                   // パラメータ変数の初期化は不要

                // パラメータ変数xとyに3の2乗と3乗が代入される
                test.TestFunc(3, out x, out y);

                //test.TestFunc(3, out int x, out var y);


                Console.WriteLine(x);     // 出力値：9
                Console.WriteLine(y);     // 出力値：27
            }
        }*/

        /*-----------outキーワード②-------------------

    }
}
*/