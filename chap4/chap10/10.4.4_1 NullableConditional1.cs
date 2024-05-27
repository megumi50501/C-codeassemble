using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    // 名前と番号のクラス
    public class Person
    {
        public int No = 0;
        public string Name = "";
    }

    // Personクラスのフィールドを持つクラス
    public class Team2
    {
        public Person? Member;
    }

    internal class NullableConditional1
    {
        static void Main()
        {
            var t = new Team2();

            string? n = t.Member.Name;
            //NullReferenceExceptionがスローされる

            Console.WriteLine(n);
        }
    }
}
