using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class Car5
    {
        // フィールド
        public string name = "マイカー"; // インスタンスメンバーを初期化
        public int seats;
    }

    internal class ClsInstMem
    {
        static void Main()
        {
            var test = new Car5();
            var test2 = new Car5();

            test2.name = "サブ";     // インスタンスメンバーに代入

            Console.WriteLine(test.name);  // 出力値："マイカー"
            Console.WriteLine(test2.name); // 出力値："サブ"
        }
    }
}
