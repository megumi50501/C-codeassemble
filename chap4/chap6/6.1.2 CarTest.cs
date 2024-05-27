using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class Car
    {
        //フィールド
        public string name = "";
        public int seats = 4;
    }

    internal class CarTest
    {
        static void Main()
        {
            Car mycar = new Car(); //Carクラスのインスタンス化を生成
            mycar.name = "マイカー"; //.でデータメンバーを指定
            Console.WriteLine(mycar.name); //出力値：マイカー
            Console.WriteLine(mycar.seats); //出力値：4
        }
    }
}
