using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Bin(int n)
        {
            if (n == 0)
                return;
            else
            {
                int resto;
                resto = n % 2;
                Bin(n / 2);
                Console.WriteLine($"Resto: {resto}");

            }

        }
        static void Main(string[] args)
        {

        }
    }
}
