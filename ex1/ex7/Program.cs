using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    internal class Program
    {
        static int Cont(int n)
        {
            if (n > -10 && n < 10)
                return 1;
            else
                return 1 + Cont(n / 10);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            int totalDigitos = Cont(numero);

            Console.WriteLine($"O número tem {totalDigitos} dígito(s).");
        }
    }
}
