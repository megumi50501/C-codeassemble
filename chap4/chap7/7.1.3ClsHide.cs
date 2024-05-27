using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7 //隠蔽
{
    // 基本クラス
    class Music2
    {
        public int Type = 0;
        public string Name = "Music";

        public void BaseInfo()
        {
            Console.WriteLine("Music");
        }
    }

    // 派生クラス
    class Music3 : Music2
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
            var m2 = new Music3();

            m2.BaseInfo();              // 出力値：Music2
            Console.WriteLine(m2.Type); // 出力値：1
        }
    }
}
