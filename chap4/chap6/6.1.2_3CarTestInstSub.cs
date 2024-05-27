using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class Car3
    {
        //フィールド
        public string name = "";
        public int seats = 4;
    }

    internal class CarTestInstSub
    {
        static void Main()
        {
            Car3 mycar1 = new Car3();
            Car3 mycar2 = new Car3);
            Car3 mycar3 = mycar2; // インスタンスの代入

            mycar3.name = "サブカー"; // mycar3のメンバーを変更

            Console.WriteLine(mycar3.name);      // 出力値：サブカー
            Console.WriteLine(mycar2.name);      // 出力値：サブカー

            // インスタンスを比較すると
            Console.WriteLine(mycar2 == mycar3); // 出力値：True
        }
    }
}
