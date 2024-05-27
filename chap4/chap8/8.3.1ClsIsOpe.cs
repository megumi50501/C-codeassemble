using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//is演算子の拡張

namespace chap8
{
    // 基本クラス
    class Music7
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music7");
        }
    }

    // 派生クラス
    class Song4 : Music7
    {
        public override void BaseInfo() // メソッドをオーバーライド
        {
            Console.WriteLine("Song4");
        }
    }

    // 派生クラス
    class Music8 : Music7
    {
        new public void BaseInfo() // メソッドを隠蔽
        {
            Console.WriteLine("Music8");
        }
    }

    internal class ClsIsOpe
    {
        static void Main()
        {
            var m = new Song4();

            Song4 s = m as Song4;
            if (s != null)
            {
                s.BaseInfo();  // 出力値：Song4
            }
            // ダウンキャストできる場合はs2が定義される
            if (m is Song4 s2)
            {
                s2.BaseInfo();  // 出力値：Song4
            }
        }
    }
}
