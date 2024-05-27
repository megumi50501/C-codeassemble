using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap5
{
    internal class SwitchStmt
    {
        static void Main()
        {
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
            }  //4月：卯月(うづき)。5月：皐月(さつき)。6月：水無月(みなづき)。7月：文月(ふみづき)。8月：葉月(はづき)。9月：長月(ながつき)。10月：神無月(かんなづき)。11月：霜月(しもつき)。12月：師走(しわす)
        }
    }
}
