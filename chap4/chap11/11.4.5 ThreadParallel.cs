using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class ThreadParallel
    {
        // スレッドで実行したい処理
        static public void ThreadMethod()
        {
            // 3秒間停止する
            Thread.Sleep(3000);
            Console.WriteLine("finish");
        }

        public static void Main()
        {
            Console.WriteLine("start");

            //InvokeメソッドにActionデリゲートを渡す
            Parallel.Invoke(new Action(ThreadMethod),
                //ラムダ式でも可能
                () =>
                {
                    //5秒間停止する
                    Thread.Sleep(5000);
                    Console.WriteLine("finish");
                });
        }
    }
}
