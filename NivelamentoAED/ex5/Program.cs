using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int numeroAnterior = int.MinValue;
            int sequencia = 1;
            int maiorSequencia= 0;

            Console.WriteLine("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero == -1)
                {
                    break;
                }
                if(numero > numeroAnterior)
                {
                    sequencia++;
                    numeroAnterior = numero;
                }
                else
                {
                    sequencia = 1;
                    numeroAnterior = numero;
                }
                if (sequencia > maiorSequencia)
                {
                    maiorSequencia = sequencia;
                }
            }
            Console.WriteLine("A maior sequencia de números foi: " + maiorSequencia);
        }
    }
}
