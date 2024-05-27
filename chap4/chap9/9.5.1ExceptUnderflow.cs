using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//オーバーフローの扱い

namespace chap9
{
    internal class ExceptUnderflow
    {
        static void Main()
        {
            checked
            {
                float x = 1e35f;
                float y = 1e-35f;

                //例外とはならない
                Console.WriteLine(x * x);  //出力：+∞
                Console.WriteLine(y * y);  //出力：0
            }
        }
    }
}
