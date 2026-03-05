using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static int SomaIntervalo(int m, int n)
        {
            int resp;
            if (m == n)
                resp = m;
            else
                resp = m + SomaIntervalo(m + 1, n);
            return resp;
        }
        static void Main(string[] args)
        {
            int r = SomaIntervalo(4, 7);
            Console.WriteLine(r);
        }
    }
}
