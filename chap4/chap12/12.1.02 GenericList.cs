using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class GenericList
    {
        static void Main()
        {
            //string型のListとしてインスタンス化
            List<string> slist = new();

            slist.Add("Hello");
            slist.Add("World");

            //インデックスによる参照(キャスト不要)
            string s = slist[1];     //出力：World

            Console.WriteLine(s);
        }
    }
}
