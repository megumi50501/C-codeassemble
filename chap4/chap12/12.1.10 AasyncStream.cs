using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class AasyncStream
    {
        static async Task Main()
        {

            // 非同期で1～numberまでを列挙する関数
            async IAsyncEnumerable<int> factorial(int number)
            {
                for (int i = number; 0 < i; i--)
                {
                    await Task.Delay(100); // 100ミリ秒待機
                    yield return i;
                }
            }

            await foreach (var d in factorial(50))
            {
                Console.WriteLine(d);
            }

            Console.ReadLine();
        }
    }
}
