using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class Car2
    {
        //フィールド
        public string name = "";
        public int seats = 4;
    }

    internal class CarTestInstance
    {
        static void Main()
        {
            Car2 mycar1 = new Car2();
            Car2 mycar2 = new Car2();

            // インスタンスを比較すると
            Console.WriteLine(mycar1 == mycar2); // 出力値：False

            mycar1.name = "メイン";
            mycar2.name = "サブ";

            Console.WriteLine(mycar1.name);      // 出力値：メイン
            Console.WriteLine(mycar2.name);      // 出力値：サブ
        }
    }
}
