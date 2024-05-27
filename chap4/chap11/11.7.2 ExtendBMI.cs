using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    //拡張メソッドを定義したクラス
    static class ExtendTestClass
    {
        //拡張メソッド(肥満度判定)
        public static void CheckJ(this TestClass7 t)
        {
            // BMIが25以上を肥満、18未満をやせすぎ、それ以外を標準とする。
            if (25 <= t.BMI())
            {
                Console.WriteLine("肥満です");
            }
            else if (t.BMI() < 18)
            {
                Console.WriteLine("やせすぎです");
            }
            else
            {
                Console.WriteLine("標準です");
            }
        }
    }

    // 体重、身長を保持してBMI値を出力するクラス
    class TestClass7
    {
        // 体重のプロパティ
        public double Weight { get; }

        // 身長のプロパティ
        public double Height { get; set; }


        // 体重、身長を指定して初期化
        public TestClass7(double w, double h)
        {
            this.Weight = w;        // キログラム
            this.Height = h / 100;  // センチメートルをメートルに変換して格納
        }

        // BMI値を求める
        public double BMI()
        {
            return this.Weight / (this.Height * this.Height);
        }
    }


    internal class ExtendBMI
    {
        public static void Main()
        {
            // 身長と体重を指定（キログラム、センチメートル）
            var a = new TestClass7(80, 170);

            // 肥満度の判定（拡張メソッド）
            a.CheckJ();    // 出力値：肥満です

            var b = new TestClass7(40, 160);
            b.CheckJ();    // 出力値：やせすぎです
        }
    }
}    