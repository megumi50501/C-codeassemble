using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7
{
    internal class Chap7all
    {
        /*-----------継承ClsMusicクラス-------------------
        //基本クラス
        class Music
        {
            public int Type = 0;
            public string Name = "Music";

            public void BaseInfo()
            {
                Console.WriteLine("Music");
            }
        }
        //派生クラス
        class Song : Music
        {
            public string Key = "C#";

            public void DrvInfo()
            {
                Console.WriteLine("Song");
            }
        }
        class ClsMusic
        {
            static void Main()
            {
                var s = new Song(); //派生クラスのインスタンス

                Console.WriteLine(s.Key); //出力値：C#
                s.DrvInfo(); //出力値：Song

                //基本クラスのメンバーにアクセスできる
                Console.WriteLine(s.Type); //出力値：０
                s.BaseInfo(); //出力値：Music

                var m = new Music(); //基本クラスのインスタンス

                Console.WriteLine(m.Type); //出力値：0
                m.BaseInfo(); //出力値：Music
                
            }
        }*/

        /*-----------継承・コンストラクタClsConstructor-------------------
        // 基本クラス
        class Music
        {
            public Music()    // 2. 基本クラスのコンストラクター実行
            {
                Console.WriteLine("基本クラスのコンストラクター");
            }
        }

        //派生クラス
        class Song : Music
        {
            public string Key = "C#";       // 1. フィールドの初期化

            public Song()                   // 3. 派生クラスのコンストラクター実行
            {
                Console.WriteLine("派生クラスのコンストラクター");
            }
        }

        class ClsConstructor
        {
            static void Main()
            {
                var s = new Song();
            }
        }*/ //出力値：基本クラスのコンストラクター、派生クラスのコンストラクター

        /*-----------継承・コンストラクタ初期化子ClsBaseクラス-------------------
        //基本クラス
        class BaseClass
        {
            public BaseClass(string s)
            {
                Console.WriteLine(s);
            }
        }

        //派生クラス
        class DerivedClass : BaseClass
        {
            // baseキーワードで、パラメーターを指定
            public DerivedClass(string s1, string s2) : base(s2)
            {
                Console.WriteLine(s1);
            }
        }

        class ClsBase
        {
            static void Main()
            {
                var c = new DerivedClass("Derived", "Base");
            }
        }*/ //出力値：Derived、Base

        /*-----------継承・隠蔽ClsHideクラス-------------------
        // 基本クラス
        class Music
        {
            public int Type = 0;
            public string Name = "Music";

            public void BaseInfo()
            {
                Console.WriteLine("Music");
            }
        }

        // 派生クラス
        class Music2 : Music
        {
            new public int Type = 1;   // 同じフィールドを定義

            new public void BaseInfo() // 同じメソッドを定義
            {
                Console.WriteLine("Music2");
            }
        }

        class ClsHide
        {
            static void Main()
            {
                var m2 = new Music2();

                m2.BaseInfo();              // 出力値：Music2
                Console.WriteLine(m2.Type); // 出力値：1
            }
        } */

        /*-----------継承・隠蔽②ClsBaseHideクラス-------------------
        // 基本クラス
        class BaseClass
        {
            public int Type = 0;
        }

        class NewClass : BaseClass
        {
            new public int Type = 1;   // 同じフィールドを定義

            // typeフィールドの値の表示
            public void Print()
            {
                Console.WriteLine(this.Type); // 自身のメンバにアクセス
                Console.WriteLine(base.Type); // 基本クラスのメンバにアクセス
            }
        }

        class ClsBaseHide
        {
            static void Main()
            {
                var n = new NewClass();

                n.Print(); // 派生クラスと基本クラスのtypeフィールドの値を表示
            }
        }*/ //出力値：1、0

        /*-----------継承・オーバーライドClsOverrideクラス-------------------
        // 基本クラス
        class Music
        {
            public virtual void BaseInfo()
            {
                Console.WriteLine("Music");
            }
        }

        // 派生クラス
        class Song : Music
        {
            public override void BaseInfo() // 基本クラスのメソッドをオーバーライド
            {
                Console.WriteLine("Song");
            }
        }

        // 派生クラス
        class Music2 : Music
        {
            new public void BaseInfo() // 基本クラスのメソッドを隠蔽
            {
                Console.WriteLine("Music2");
            }
        }

        class ClsOverride
        {
            static void Main()
            {
                var s = new Song();
                s.BaseInfo();   // 出力値："Song"

                var m2 = new Music2();
                m2.BaseInfo();  // 出力値："Music2"

                var m = new Music();
                m.BaseInfo();  // 出力値："Music"
            }
        }*/

        /*-----------カプセル化・ClsCapsule-------------------
        // 基本クラス
        class Music
        {
            int type = 0;   // 既定はprivateになる
            protected string name = "Music";

            // typeフィールドに値を設定するpublicメソッド
            public void SetType(int type)
            {
                this.type = type;
            }

            // フィールドの値を出力する仮想メソッド
            public virtual void PrintName()
            {
                Console.WriteLine(type);
                Console.WriteLine(name);
            }
        }

        // 派生クラス
        class Song : Music
        {
            public override void PrintName()
            {
                // this.type = 1;
                this.name = "Song";  // nameフィールドに”song”を代入
                base.PrintName();    // 基本クラスのメソッドを呼び出す
            }
        }

        class ClsCapsule
        {
            static void Main()
            {
                Song s = new Song();   // 派生クラスのインスタンスを作成
                s.SetType(1);    // typeフィールドに1を設定
                                 // s.name = "test";
                s.PrintName();   // 出力値：1　Song
            }
        }*/

        /*-----------カプセル化・プロパティClsProperty-------------------
        // 基本クラス
        class Music
        {
            int type = 0;     // 既定はprivate
            protected string name = "Music";

            public int Type
            {
                set
                {
                    this.type = value;
                }
                get
                {
                    return this.type;
                }
            }
        }

        class ClsProperty
        {
            static void Main()
            {
                var m = new Music();
                m.Type = 1;  // setが呼ばれる
                Console.WriteLine(m.Type);  // getが呼ばれる
            }
        }*/ //出力値：1

        /*-----------カプセル化・自動プロパティClsAutoProp-------------------
        class SampleClass
        {
            //自動で内部的なint型のフィールドが形成される
            public int Type { get; set; }
        } 

        class ClsAutoProp
        {
            static void Main()
            {
                var test = new SampleClass();

                test.Type = 1;
                Console.WriteLine(test.Type);  //出力値：1
            }
        }*/

        /*-----------カプセル化・自動プロパティの初期化子7.2.5ClsAutoInit-------------------
        class SampleClass
        {
            public string Type { get; set; } = "nothing";
            public string Name { get; set; } = "abc";
        }

        class ClsAutoInit
        {
            static void Main()
            {
                var test = new SampleClass();
                Console.WriteLine(test.Type); //出力値：nothing
                Console.WriteLine(test.Name); //出力値：abc
            }
        }*/

        /*-----------カプセル化・オブジェクト初期化子7.2.6ClsInitializers-------------------
        class SampleClass
        {
            // フィールド
            public int v1 = 10;
            private int v2;

            // デフォルトコンストラクタ
            public SampleClass()
            {
                Console.WriteLine(this.v1);
            }

        }

        class ClsInitializers
        {
            static void Main()
            {
                var test = new SampleClass { v1 = 20 }; // 出力値：10
                Console.WriteLine(test.v1);             // 出力値：20

                // 以下のコメントをはずすとコンパイルエラーとなる
                // privateのメンバは設定できない
                // var test2 = new SampleClass { v2 = 20 };
            }
        }*/

        /*-----------カプセル化・initアクセサーClsInitProperty-------------------
        public class TestClass
        {
            public string GetProp { get; }        // getのみ
            public string InitProp { get; init; } // initアクセサー

            public TestClass()
            {
                this.GetProp = "";
                this.InitProp = "";
            }

            public TestClass(string gv, string iv)
            {
                this.GetProp = gv;
                this.InitProp = iv;
            }

            public void TestMethod(string gv, string iv)
            {
                // this.GetProp = gv; // エラーになる
                // this.InitProp = iv; // エラーになる
            }
        }

        public class ClsInitProperty
        {
            static void Main()
            {
                // コンストラクタはOK
                var t1 = new TestClass("p1", "p2");

                // 以下はエラーになる
                // t1.GetProp = "";
                // t1.InitProp = "";

                // オブジェクト初期化子
                var t2 = new TestClass
                {
                    InitProp = "a",
                    // GetProp = "b", // エラーになる
                };
            }
        } */ //出力値：なし

        /*-----------カプセル化・インデクサー7.2.8ClsIndexer-------------------
        class TestArray
        {
            // privateなので外部からはアクセスできない
            int[] array = new int[3];

            // インデクサーの定義
            public int this[int index]
            {
                set
                {
                    array[index] = value;
                }
                get
                {
                    return array[index];
                }
            }
        }

        class ClsIndexer
        {
            static void Main()
            {
                var t = new TestArray();

                // 配列のように代入できる
                t[0] = 5;
                t[1] = 10;
                t[2] = 15;

                // 配列のように参照できる
                Console.WriteLine(t[1]); // 出力値：10

                // オブジェクト初期化子でのインデクサー
                var t2 = new TestArray()
                {
                    [0] = 5,
                    [1] = 10,
                    [2] = 15
                };
                Console.WriteLine(t2[2]); // 出力値：15
            }
        }*/

        /*-----------カプセル化・インデクサー②ClsIIndexerStr-------------------
        class ClsIIndexerStr
        {
            static void Main()
            {
                var dict = new Dictionary<string, string>();

                dict["Mon"] = "月"; //インデックス"Mon"と要素"月"を追加
                dict["Tue"] = "火"; //インデックス"Tue"と要素"火"を追加

                Console.WriteLine(dict["Mon"]); //出力値：月
            }
        }*/

        /*-----------カプセル化・コラムインテクサーとメソッドの使い分けColumnClsMaile-------------------
        //メートルをマイルに変換するクラス
        class GetMile
        {
            public double this [double m]
            {
                get
                {
                    //インデックスのmをデータとして扱っている
                    return m * 1609.344;
                }
            }
        }

        class ClsMaile
        {
            static void Main()
            {
                var gm = new GetMile();

                Console.WriteLine(gm[2]); //出力値：3218.688
                Console.WriteLine(gm[3]); //出力値：4828.032
            }
        }*/

        /*-----------パーシャルクラス・7.3ClsPartial-------------------
        partial class Sample
        {
            int a = 1;
        }

        partial class Sample
        {
            public void Test()
            {
                Console.WriteLine(a);
            }
        }

        class ClsPartial
        {
            static void Main()
            {
                var testClass = new Sample();

                testClass.Test();  // 出力値：1
            }
        }*/

    }
}
