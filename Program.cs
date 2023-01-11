using System;
using System.Linq;
using System.Collections.Generic;

namespace Kata
{
    class Program
    {
        public static string NextNarajana(string seq)
        {
            int j = -1, l = -1;
            for (int i = seq.Length - 1; i > 0; i--)
                if (seq[i] > seq[i - 1]) { j = i - 1; break; }
            if (j == -1) return seq;
            for (int i = seq.Length - 1; i > j; i--)
                if (seq[i] > seq[j]) { l = i; break; }
            char bufJ = seq[j], bufL = seq[l];
            seq = seq.Remove(j, 1).Insert(j, bufL.ToString()).Remove(l, 1).Insert(l, bufJ.ToString());
            seq = seq.Remove(j+1) + String.Join("", seq.Substring(j+1).Reverse());
            return seq;
        }
        static void Main(string[] args)
        {
            string cur = "abcdefg";
            Console.WriteLine(cur);
            while(cur != NextNarajana(cur))
                Console.WriteLine(cur = NextNarajana(cur));
        }
    }
}
