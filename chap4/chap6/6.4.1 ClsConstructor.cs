using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class Car4
    {
        // データメンバー
        public string name = "";
        public int seats;

        // 既定のコンストラクター
        public Car4()
        {
            seats = 4; // 4で初期化
        }

        // string型のパラメータを受け取るコンストラクター
        public Car4(string str)
        {
            seats = 4;
            name = str;
        }

    }

    internal class ClsConstructor
    {
        static void Main()
        {
            var test = new Car4();
            Console.WriteLine(test.name);   // 何も出力されない

            var test2 = new Car4("マイカー");
            Console.WriteLine(test2.name);  // 出力値：マイカー
        }
    }
}
