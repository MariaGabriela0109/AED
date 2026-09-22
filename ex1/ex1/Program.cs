using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static int Calculo(int a, int n)
        {
            if (n == 1)
            {
                return a;
            }
            else
                return Calculo(a, n - 1) * a;
        }
        static void Main(string[] args)
        {
            int a = 0;
            int n = 0;
            Console.WriteLine("Digite o valor de 'a' e 'n' consecutivamente");
            a = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            int result = 0;
            result = Calculo(a, n);

            Console.WriteLine($"resultado: {result}");
        }
    }
}
