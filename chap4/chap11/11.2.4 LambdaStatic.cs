using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class LambdaStatic
    {
        public static void Main()
        {
            int b = 2;

            // 外部変数をキャプチャしているので、staticを付けられない
            void LocalFunction(int n)
            {
                Console.WriteLine(n * b); // bをキャプチャしている
                b++;
            }

            // 静的ローカル関数（外部の変数をキャプチャしていない）
            static void LocalFunctionStatic(int n)
            {
                Console.WriteLine(n);
            }

            // 静的なラムダ式（外部の変数をキャプチャしていない）
            Action<int> action = static x => Console.WriteLine(x * 2);

            // 静的匿名メソッド（外部の変数をキャプチャしていない）
            Action<int> actiondele = static delegate (int x)
            {
                Console.WriteLine(x * 2);
            };

            LocalFunction(3);        //出力：6
            Console.WriteLine(b);    //出力：3
            LocalFunctionStatic(3);  //出力：3
            action(5);               //出力：10
        }
    }
}
