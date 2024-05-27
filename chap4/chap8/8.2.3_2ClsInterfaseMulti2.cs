using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap8
{
    //インターフェイス1
    interface IBaseInterface3
    {
        void Method2(int a);
    }

    //インターフェイス2
    interface IBaseInterface4
    {
        void Method3(string s);
    }

    internal class SampleClass2: IBaseInterface3, IBaseInterface4
    {
        public void Method2(int a)
        {
            Console.WriteLine(a);
        }
        
        public void Method3(string s)
        {
            Console.WriteLine(s);
        }
    }
}
