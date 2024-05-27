using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap9
{
    internal class ExceptWhen1
    {
        static void Main()
        {
            try
            {
                throw new Exception("error");
            }
            catch(Exception e) when (e.Message == "error")
            {
                Console.WriteLine("エラー発生");
            }
            //Messageプロパティが"error"以外の時
            catch(Exception e)
            {
                Console.WriteLine("その他の例外");
            }
        }
    }
}
