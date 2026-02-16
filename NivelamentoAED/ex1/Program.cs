using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nivelamento01AED
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int aux = 1;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write((aux) + " ");
                    aux++;
                }
                Console.WriteLine();
            }
        }
    }
}
