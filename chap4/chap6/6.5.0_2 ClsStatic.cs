using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6　//静的メンバ
{
    class Car6
    {
        public string name;       // インスタンスメンバー
        public static int seats;  // 静的メンバー

        public Car6()
        {
            name = "マイカー";
        }

        public void Display()
        {
            Console.WriteLine(seats); // seats静的フィールドの値を出力
        }
    }

    internal class ClsStatic
    {
        static void Main()
        {
            Car6.seats = 5;   // seats静的フィールドに5を設定

            // インスタンスを作成
            var test = new Car6();
            test.Display();  // 出力値：5

            // 別のインスタンスでも静的フィールドの値は同じになる
            var test2 = new Car6();
            test2.Display(); // 出力値：5
        }
    }
}
