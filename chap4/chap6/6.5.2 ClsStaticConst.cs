using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6 //静的コンストラクタ
{
    class Car8
    {
        public string name;       // インスタンスメンバー
        public static int seats;  // 静的メンバー

        public Car8()
        {
            name = "マイカー";
            Console.WriteLine(name);
        }

        // 静的コンストラクター
        static Car8()
        {
            seats = 4;
            Console.WriteLine(seats);
        }

        // 静的メソッド
        public static void SetSeat(int n)
        {
            seats = n; // 静的メンバーに代入
        }

        public void Display()
        {
            Console.WriteLine(seats); // 静的メソッドの呼び出し
        }
    }

    class ClsStaticConst
    {
        static void Main()
        {
            var test = new Car8();  // 静的コンストラクターと既定のコンストラクターが呼び出される

            Car8.SetSeat(5);        // 静的メンバーに5を設定

            var test2 = new Car8(); // 既定のコンストラクターのみが呼び出される

            test2.Display();       // 静的メンバーの値は変更されていない
        }
    }
}
