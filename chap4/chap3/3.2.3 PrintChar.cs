namespace Chap3_PrintChar;
class PrintChar
{
    static void Main()
    {
        char a = '\u6F22'; //'漢'の文字コード(6F22)を代入。変数aには文字「漢」の文字コードが代入される
        char b = '漢';     //変数bには文字「a」の文字コードが代入される

        Console.WriteLine(a); //出力値：漢
        Console.WriteLine(b); //出力値：漢
    }
}
