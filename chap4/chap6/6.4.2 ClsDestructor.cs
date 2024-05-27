using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6
{
    internal class ClsDestructor
    {
        
            class Car
           {
                // データメンバー
                public string name = "";
                public int seats; 
                // コンストラクター
                public Car()
                {
                  // コンストラクターの処理
                }
               // デストラクター
               ~Car()
               {
                // デストラクターの処理
               }
            }
    }
}

