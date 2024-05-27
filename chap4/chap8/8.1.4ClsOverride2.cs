using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//隠蔽との違い
namespace chap8
{
    //基本クラス
    class Music4
    {
        public virtual void BaseInfo()
        {
            Console.WriteLine("Music4");
        }
    }

    //派生クラス
    class Music5 : Music4
    {
        new public void BaseInfo()  //メソッドを隠蔽
        {
            Console.WriteLine("Music5");
        }
    }

    internal class ClsOverride2
    {
        static void Main()
        {
            Music4 m; //music4クラス型の変数

            m = new Music5(); //music5クラスのインスタンスを代入
            m.BaseInfo();     //出力：Music4
        }
    }
}
