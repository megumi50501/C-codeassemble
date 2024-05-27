using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//抽象メソッドと抽象クラス
namespace chap8
{
    //抽象クラス(基本クラス)
    abstract class Music6
    {
        public abstract void GetInfo(); //抽象メソッド
    }

    //派生クラス
    class Song3 : Music6
    {
        public override void GetInfo() //overrideをつける
        {
            Console.WriteLine("Song3");
        }
    }

    internal class ClsAbstract
    {
        static void Main()
        {
            var s = new Song3();
            s.GetInfo();   //出力：Song3
        }
    }
}
