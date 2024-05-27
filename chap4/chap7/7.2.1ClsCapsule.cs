using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7 //カプセル化
{
    // 基本クラス
    class Music6
    {
        int type = 0;   // 既定はprivateになる
        protected string name = "Music6";

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
    class Song3 : Music6
    {
        public override void PrintName()
        {
            // this.type = 1;
            this.name = "Song3";  // nameフィールドに”song”を代入
            base.PrintName();    // 基本クラスのメソッドを呼び出す
        }
    }

    class ClsCapsule
    {
        static void Main()
        {
            Song s = new Song3();   // 派生クラスのインスタンスを作成
            s.SetType(1);    // typeフィールドに1を設定
                             // s.name = "test";
            s.PrintName();   // 出力値：1　Song
        }
    }
}
