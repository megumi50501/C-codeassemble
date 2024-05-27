using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7 //オーバーライド
{
    // 基本クラス
    class Music4
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    // 派生クラス
    class Song2 : Music4
    {
        public override void BaseInfo() // 基本クラスのメソッドをオーバーライド
        {
            Console.WriteLine("Song");
        }
    }

    // 派生クラス
    class Music5 : Music4
    {
        new public void BaseInfo() // 基本クラスのメソッドを隠蔽
        {
            Console.WriteLine("Music5");
        }
    }

    class ClsOverride
    {
        static void Main()
        {
            var s = new Song2();
            s.BaseInfo();   // 出力値："Song2"

            var m2 = new Music5();
            m2.BaseInfo();  // 出力値："Music5"

            var m = new Music4();
            m.BaseInfo();  // 出力値："Music4"
        }
    }
}
