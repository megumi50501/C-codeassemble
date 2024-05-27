using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap8
{
    internal class ClsCastDown
    {
        static void Main()
        {
            Music m = new Song();

            Song s = m as Song;
            Music2 m2 = m as Music2; //ダウンキャストできないのでnullを返す

            Console.WriteLine(s == null); //出力：False
            Console.WriteLine(m2 == null); //出力：True
        }
    }
}