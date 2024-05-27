using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap7_ClsConstructor //継承とコンストラクタ
{ 
    // 基本クラス
    class Music
    {
        public Music()    // 2. 基本クラスのコンストラクター実行
        {
            Console.WriteLine("基本クラスのコンストラクター");
        }
    }

　　//派生クラス
　　class Song : Music
　　{
    　　public string Key = "C#";       // 1. フィールドの初期化

    　　public Song()                   // 3. 派生クラスのコンストラクター実行
    　　{
        　　Console.WriteLine("派生クラスのコンストラクター");
    　　}
　　}

　　class ClsConstructor
    {
       static void Main()
       {
          var s = new Song();
       }
    }
}