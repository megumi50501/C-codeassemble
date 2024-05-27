using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//オーバーライドの仕組み
namespace chap8
{
    internal class Music3
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music3");
        }
    }

    //派生クラス
    class Song2 : Music3
    {
        public override void BaseInfo() //同じメソッドを定義
        {
            Console.WriteLine("Song2");
        }
    }

    //派生クラス
    class Symphony : Music3
    {
        public override void BaseInfo() //同じメソッド
        {
            Console.WriteLine("Symphony");
        }
    }

    internal class ClsOverride1
    {
        static void Main()
    {
        Music3 m;            // Musicクラス型の変数

        m = new Song2();     // Songクラスのインスタンスを代入
        m.BaseInfo();       // 出力値：song

        m = new Symphony(); // Symphonyクラスのインスタンスを代入
        m.BaseInfo();       // 出力値：Symphony
    }
    }
}
