using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class Forever
    {
        static void Main()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);

                //このようにカウンター変数を変更してしまうと…
                i--;
                //０がずっとカウントされて行ってしまう。所謂無限ループというもの
            }
        }
    }
}
