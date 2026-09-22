using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static int Mdc(int x, int y)
        {
            if (x == y)
                return x;
            else
            {
                if (x > y)
                {
                    return Mdc(x - y, y);
                }
                else
                    return Mdc(y, x);
            }
        }
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            Console.WriteLine("Digite o valor de 'x' e 'y' consecutivamente");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            int result = 0;
            result = Mdc(x, y);

            Console.WriteLine($"resultado: {result}");
        }
    }
}
