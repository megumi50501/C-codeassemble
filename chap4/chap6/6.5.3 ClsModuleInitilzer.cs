using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap6 //モジュール初期化子
{
    using System.Runtime.CompilerServices;

    class ClsModuleInitilizer
    {
        [ModuleInitializer]
        public static void InitMethod()
        {
            // Console.WriteLine("最初の1回だけ実行");
            // 明示的に呼び出さなくても表示される
        }
    }
}
