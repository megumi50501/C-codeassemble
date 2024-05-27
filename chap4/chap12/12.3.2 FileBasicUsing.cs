using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class FileBasicUsing
    {
        static void Main()
        {
            try
            {
                // ファイルのオープン
                using (StreamReader sr = new("sample.txt", System.Text.Encoding.Default)) 
                {
                    // ファイルの内容すべてを、1つの文字列に読み込む
                    string text = sr.ReadToEnd();

                   // 読み込んだファイルの内容の出力
                   Console.Write(text);
                }
            }
            catch (Exception e)
            {
                // 例外の内容の出力
                Console.WriteLine(e.Message);
            }
        }
    }
}
