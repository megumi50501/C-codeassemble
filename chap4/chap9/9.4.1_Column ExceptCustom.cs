using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//コラム・System.ApplicationException

namespace chap9
{
    // 独自の基本例外クラスの定義
    class BaseCustomException : Exception
    {
        public BaseCustomException(string msg) : base(msg)
        {
        }
    }

    // 独自の例外クラスの定義
    class CustomException2 : BaseCustomException
    {
        public CustomException2 (string msg) : base(msg)
        {
        }
    }

    internal class ExceptCustom
    {
        static void Main()
        {
            try
            {
                // ユーザー定義の例外をスロー
                throw new CustomException2("例外をスロー");
            }
            catch (BaseCustomException e)      // ユーザー定義の例外の捕捉
            {
                Console.WriteLine("ユーザー定義");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)                // すべての例外の捕捉
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
