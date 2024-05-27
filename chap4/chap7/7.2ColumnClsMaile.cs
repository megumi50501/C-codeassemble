using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7
{
    internal class ColumnClsMaile
    {
        //メートルをマイルに変換するクラス
        class GetMile
        {
            public double this[double m]
            {
                get
                {
                    //インデックスのmをデータとして扱っている
                    return m * 1609.344;
                }
            }
        }

        class ClsMaile
        {
            static void Main()
            {
                var gm = new GetMile();

                Console.WriteLine(gm[2]); //出力値：3218.688
                Console.WriteLine(gm[3]); //出力値：4828.032
            }
        }
    }
}
