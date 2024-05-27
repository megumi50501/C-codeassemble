using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    internal class SocketClient
    {
        static void Main()
        {
            using TcpClient client = new();

            // ③接続要求
            Console.WriteLine("③接続を要求します");
            client.Connect("localhost", 30000);

            // NetworkStreamの取得
            using var ns = client.GetStream();

            // ④データ送信
            byte[] sb = { 0, 1, 2 };
            ns.Write(sb, 0, sb.Length);
            Console.WriteLine($"④送信 → {BitConverter.ToString(sb)}");

            // ④データ受信
            byte[] rb = new byte[3];
            ns.Read(rb, 0, rb.Length);
            Console.WriteLine($"④受信 ← {BitConverter.ToString(rb)}");

            // ⑤切断
            Console.WriteLine("⑤切断しました");
        }
    }
}
