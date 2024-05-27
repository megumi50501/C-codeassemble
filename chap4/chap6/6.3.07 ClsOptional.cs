using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    class TestClass4
    {
        // 省略可能なパラメーターを持つメソッド
        public void PrintName(int no, string name = "nanashi")
        {
            Console.WriteLine(no + "→" + name);
        }
    }

    internal class ClsOptional
    {
        static void Main()
        {
            var test = new TestClass4();

            test.PrintName(10); // test.SampleMethod( 10, "nanashi" );と同じ意味
                                // 出力値：10→nanashi
        }
    }
}
