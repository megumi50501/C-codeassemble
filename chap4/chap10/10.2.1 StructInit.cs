using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//構造体とは

namespace chap10 
{ 

    struct Simple
    {
       public int Number;
       public string Name;
    }

    internal class StructInit
    {
            static void Main()
            {
                Simple ss;         //newは不要

                ss.Number = 0;     //int型のフィールドに値を設定
                ss.Name = "test";  //string型のフィールドに値を設定

                Console.WriteLine(ss.Number);
                Console.WriteLine(ss.Name);
            }
    }
}

