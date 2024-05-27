using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap12
{
    class TestMethod
    {
        //ジェネリックを用いたメソッド
        public void Info<T>(in T p)
        {
            Console.WriteLine("データ型は{0}です", p?.GetType());
        }
    }

    //ジェネリックを用いたクラス
    class TestClass<Type>
    {
        //ジェネリックなフィールド
        private Type[] ary = new Type[2];

        public Type? Add(int idx, Type p)
        {
            if(0 <= idx && idx < ary.Count())
            {
                ary[idx] = p;
                return ary[idx];
            }
            return default;
        }
    }

    internal class GenericMethod
    {
        static void Main()
        {
            var m = new TestMethod();
            m.Info("123");   //出力：データ型はSystem.Stringです。
            m.Info(m);       //出力：データ型はchap12

            var t = new TestClass<string>();
            Console.WriteLine(t.Add(1, "test"));    //出力：test
        }
    }
}
