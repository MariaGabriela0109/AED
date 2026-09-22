using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static double Serie(int n)
        {
            if (n == 1)
                return 2;
            else
                return (Math.Pow(n, 2) + 1) / n + Serie(n - 1);
        }
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Digite o valor de n:");
            n = int.Parse(Console.ReadLine());

            double result = 0;
            result = Serie(n);

            Console.WriteLine($"resultado: {result}");
        }
    }
}
