using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7 //自動プロパティ
{
    class SampleClass2
    {
        //自動で内部的なint型のフィールドが形成される
        public int Type { get; set; }
    }

    class ClsAutoProp
    {
        static void Main()
        {
            var test = new SampleClass2();

            test.Type = 1;
            Console.WriteLine(test.Type);  //出力値：1
        }
    }
}
