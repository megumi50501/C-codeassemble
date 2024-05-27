using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6 //静的メソッド
{
    class Car7
    {
        public string name;       // インスタンスメンバー
        public static int seats;  // 静的メンバー

        public Car7()
        {
            name = "マイカー";
        }

        // 静的メソッド
        public static void SetSeat(int n)
        {
            seats = n; // 静的メンバーのみアクセス可能
        }

        public void Display()
        {
            Console.WriteLine(seats); // 静的メソッドの呼び出し
        }
    }

    class ClsStaticMethod
    {
        static void Main()
        {
            Car7.SetSeat(5); // 静的メンバーに5を設定

            var test = new Car7();
            test.Display();  // 出力値：5

            var test2 = new Car7();
            test2.Display(); // 出力値：5
        }
    }
}
