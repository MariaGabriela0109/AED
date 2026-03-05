using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static double CalcularSerie(int n)
        {
            double resp;
            if (n == 1)
                resp = 2;
            else
                resp = CalcularSerie(n-1) + (1.0 + n * n) / n ;
            return resp;
        }
        static void Main(string[] args)
        {
            double r = CalcularSerie(4);
            Console.WriteLine(r);
        }
    }
}
