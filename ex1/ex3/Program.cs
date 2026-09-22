using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static int Soma(int m, int n)
        {
            if (m == n)
                return n;
            else
                return n + Soma(m, n - 1);
        }
        static void Main(string[] args)
        {
            int m = 0;
            int n = 0;
            Console.WriteLine("Digite o valor de 'm' e 'n' consecutivamente");
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            int result = 0;
            result = Soma(m, n);

            Console.WriteLine($"resultado: {result}");
        }
    }
}
