using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace chap8
{
    interface IGetInfo
    {
        void GetInfo();
    }

    //派生クラス
    class SampleClass : IGetInfo
    {
        public void GetInfo()
        {
            Console.WriteLine("SampleClass");
        }
    }

    internal class ClsInteface1
    {
        static void Main()
        {
            var s = new SampleClass();
            s.GetInfo();    //出力：SampleClass
        }
    }
}
