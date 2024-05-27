using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//throw文

namespace chap9
{
    class CustomException : Exception
    {
        public CustomException(string msg) : base(msg)
        {
        }
    }

    internal class ExceptThrow
    {
        static void Main()
        {
            try
            {
                //ユーザ定義の例外をスロー
                throw new CustomException("例外をスロー");
            }
            catch(CustomException e)   //ユーザ定義の例外の補足
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
