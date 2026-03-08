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
            if (m == n)
                return m;
            return m + SomaIntervalo(m + 1, n);
        }
        static void Main(string[] args)
        {
            int r = SomaIntervalo(4, 7);
            Console.WriteLine(r);
        }
    }
}
