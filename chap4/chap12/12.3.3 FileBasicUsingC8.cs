using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class FileBasicUsingC8
    {
        static void Main()
        {
            try
            {
                //using変数宣言
                using StreamReader sr = new("sample.txt", System.Text.Encoding.Default);

                string text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            catch (Exception e)
            {
                // 例外の内容の出力
                Console.WriteLine(e.Message);
            }
        }
    }
}
