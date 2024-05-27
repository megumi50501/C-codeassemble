using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class HttpSimple
    {
        static readonly HttpClient Client = new();

        static void Main()
        {
            // 非同期メソッド
            async Task GetWebLengthAsync(string url)
            {
                // Webページの内容を文字列で取得する
                var c = await Client.GetStringAsync(url);

                // 取得した文字列のサイズを表示する
                Console.WriteLine($"{url} : {c.Length}");
            }
            GetWebLengthAsync("http://www.yahoo.co.jp/").Wait();
            GetWebLengthAsync("http://www.msn.com/").Wait();
        //出力：http://www.yahoo.co.jp/ : 32534
        //出力：http://www.msn.com/ : 45938
        }
    }
}
