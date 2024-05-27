using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap8
{
    internal class ClsCastls
    {
        static void Main()
        {
            Music m = new Song();
            Song s = (Song)m;

            Console.WriteLine(m is Song); //出力値：True
            Console.WriteLine(m is Music2); //出力値：False
        }
    }
}
