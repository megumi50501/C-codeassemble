﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap10
{
    readonly struct ReadonlyStrct
    {
        public readonly int A;
        public readonly string B;
        public double C { get; } // readonlyキーワードは不要

        // コンストラクター内は初期化可能
        public ReadonlyStrct(int a, string b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }

    struct ReadonlyStrctC8
    {
        public int A = 0;

        public ReadonlyStrctC8()
        {
        }

        public readonly int Calc() => A * 2;

        // Aを書き換えているので定義できない
        //public readonly void Calc() => A *= 2;
    }

    internal class StructReadonly
    {
        static void Main()
        {
            var s = new ReadonlyStrct(1, "a", 2);

            //エラーとなる
            //s.A = 3;
        }
    }
}
