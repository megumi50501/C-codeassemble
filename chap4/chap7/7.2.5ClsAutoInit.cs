using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7 //自動プロパティの初期化子
{
    class SampleClass3
    {
        public string Type { get; set; } = "nothing";
        public string Name { get; set; } = "abc";
    }

    class ClsAutoInit
    {
        static void Main()
        {
            var test = new SampleClass3();
            Console.WriteLine(test.Type); //出力値：nothing
            Console.WriteLine(test.Name); //出力値：abc
        }
    }
}
