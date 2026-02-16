using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux = 0;
            Random r = new Random();
            int[] vet = new int[1000];

            for (int i = 0; i < vet.Length; i++)
            {
                vet[i] = r.Next(1, 1001);
            }

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + ", ");
            }

            for (int i = 1; i < vet.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (vet[i] < vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");

            for (int i = 0; i < vet.Length; i++)
            {
                Console.Write(vet[i] + ", ");
            }
        }
    }
}
