using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static int Fatorial(int n)
        {
            if(n == 0)
                return 1;
            return Fatorial(n - 1) * n;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Fatorial(5));
        }
    }
}

/*Entrada,Retorno (Chamadas),Retorno (Resoluções)
Fatorial(5) - 5 * Fatorial(4) ➡️ 5 * (24) = 120
Fatorial(4) - 4 * Fatorial(3) ➡️ 4 * (6) = 24
Fatorial(3) - 3 * Fatorial(2) ➡️ 3 * (2) = 6
Fatorial(2) - 2 * Fatorial(1) ➡️ 2 * (1) = 2
Fatorial(1) - 1 * Fatorial(0) ➡️ 1 * (1) = 1
Fatorial(0) - 1 ➡️ 1
*/