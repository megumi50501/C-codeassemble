using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    class SampleLambda
    {
        private int num;
        private string[] str_nums = new string[5];

        // ラムダ式によるプロパティー（getterと同じ）
        public string Name => "nothing";

        public string this[int key]
        {
            // インデクサーのgetter
            get => str_nums[key];

            // インデクサーのsetter
            set => str_nums[key] = value;
        }

        // ラムダ式によるコンストラクター
        public SampleLambda() => num = 3;

        // ラムダ式によるメソッド
        public int Multi(int a) => a * num;
        // 以下と同じ
        // public int Multi( int a )
        // {
        //    return a * num;
        // }
    }
    internal class LambdaMember
    {
        static void Main()
        {
            var c = new SampleLambda();

            Console.WriteLine(c.Name);      // 出力：nothing
            Console.WriteLine(c.Multi(5));  // 出力：15

            c[1] = "test";
            Console.WriteLine(c[1]);        // 出力：test
        }
    }
}
