//名前を入力して表示するプログラム#1※コメント行
/* これも
 　コメントになる */

class First
{
    static string program_var = "sample #1";

    static void Main()
    {
        System.Console.WriteLine(program_var);
        System.Console.Write("お名前は？>>");
        string? name = System.Console.ReadLine();
        System.Console.WriteLine($"ようこそ、{name}さん！");
    }
}