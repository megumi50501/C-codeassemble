using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class LambdaLocal
    {
        public static void Main()
        {
            //引数、戻り値がないラムダ式を返すローカル関数
            Action CreateLambda(int n)
            {
                int b = 2;
                return () => { Console.WriteLine(n * b); };
            }
            Action action = CreateLambda(3);

            //ラムダ式の実行
            action();       //出力：6
        }
    }
}
