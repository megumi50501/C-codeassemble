namespace Chap3_PrintBool;
class PrintBool
{
    static void Main ()
    {
        /*bool型(論理型)
     　　bool i = true;
         bool j = false;
         bool k = 1; //エラーとなる
        */
        int x = 10;
        int y = 5;
        bool b = (x == y); // xとyが等しいか。 〇〇==△△は〇〇と△△が等しいかを聞いている。

        Console.WriteLine(b); //出力値:False
    }
}
