using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap11
{
    internal class AwaitMain
    {
        const string Url = "http://www.yahoo.co.jp/";
        static readonly HttpClient Client = new();

        static async Task Main()
        {
            // await演算子の利用
            var c = await Client.GetStringAsync(Url);
            Console.WriteLine($"{Url} : {c.Length}");
        }
    }
}
