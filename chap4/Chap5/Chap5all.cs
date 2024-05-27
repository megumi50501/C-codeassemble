using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap5_Chap5all
{
    internal class Chap5all
    {
        static void Main() {
            /*-----------if文-------------------
            int x = 5;

            if(x < 10) //xが10より小さい場合
            {
                x *= 10;　//xを10倍する
            }
            Console.WriteLine(x); //出力値：50 */

            /*-----------if...else文①-----------
            int x = 15;

            if (x < 10)
            {
                x *= 10;
            }else
            {
                x = -x;
            }
            Console.WriteLine(x); //出力値：-15 */

            /*----------if...else文②------------- 
            int x = 15;

            if (x < 10) //xが10より小さい場合
            {
                x *= 10;　//xを10倍する
            }
            else if (x == 15) //xが15の場合
            {
                x *= 3; //xを3倍する
            }
            else  //その他の場合
            {
                x = -x; //xの符号を反転する
            }
            Console.WriteLine(x);  //出力値：45*/

            /*---------switch文------------------
            int month = DateTime.Now.Month; //現在の月を取得

            switch (month)
            {
                case 1:
                    Console.WriteLine("睦月"); //むつき：一月。
                    break;
                case 2:
                    Console.WriteLine("如月"); //きさらぎ：二月。
                    break;
                case 3:
                    Console.WriteLine("弥生"); //やよい：三月。
                    break;
                case 7:
                case 8:
                    Console.WriteLine("夏休み");
                    break;
                default:
                    Console.WriteLine(month + "月"); 
                    break;
                    //4月：卯月(うづき)。5月：皐月(さつき)。6月：水無月(みなづき)。7月：文月(ふみづき)。8月：葉月(はづき)。
            }       //9月：長月(ながつき)。10月：神無月(かんなづき)。11月：霜月(しもつき)。12月：師走(しわす)。*/

            /*-----------forループ文①-------------------
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i); //出力：0,1,2
            } */

            /*-----------forループ文②-------------------
            for (int i = 0, j = 0; i + j < 10; i++, j += 2)
            {
                Console.WriteLine("{0},{1}", i, j);
            } */ //出力値：0,0、1,2、2,4、3,6になる

            /*-----------forループ文無限ループ-------------------
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);

                //このようにカウンター変数を変更してしまうと…
                i--;
                //０がずっとカウントされて行ってしまう。所謂無限ループというもの
            }　*/

            /*-----------for文エラー-------------------
            string[] j = { "グー", "チョキ", "パー" };

            // 配列の範囲を超えているので、実行時にエラーとなる。
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine(j[i]);
            } */

            /*-----------while文-------------------
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(i++);
            }*/ //実行後：0,1,2と出力された

            /*-----------doループ-------------------
            int i = 10;
            do {
                Console.WriteLine(++i); //出力結果は11
            }
            while (i < 5);*/

            /*-----------foreach文-------------------
            string[] j = { "グー", "チョキ", "パー" };

            // 配列のデータを1つずつ取得
            foreach (string str in j)
            {
                System.Console.WriteLine(str);
            }*  //出力はグー、チョキ、パーとなる。

            /*-----------スコープ文①-------------------
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // 変数iは存在しないというコンパイルエラーになる
            // Console.WriteLine(i);　*/　//実行すると0，1，2，3，4となる

            /*-----------スコープ文②-------------------
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }*/　//実行すると0，1，2，3，4,0,1,2となる

            /*-----------for文入れ子-------------------
            //2重ループの例
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(i + j);
                }
            }*/

            /*-----------break文-------------------
            for (int i = 0; true; i++)
            {
                if (i == 3) //変数iが3の場合
                {
                    break; //ループを中断する
                }
                Console.WriteLine(i);
            } //出力値：0,1,2

            //-----------continue文-------------------
            for (int i = 0; true; i++)
            {
                if (i < 8)
                {
                    continue; //カウンター変数を更新してループの先頭に戻る
                }
                else if (i == 10)
                {
                    break; //ループを中断する
                }
                Console.WriteLine(i);
            } //出力値：8、9
        }
    }
}
*/