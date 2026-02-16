using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void LerVetor(int[] vetor, string nome)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(nome + "[" + i + "]: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int N = int.Parse(Console.ReadLine());

            int[] x = new int[N];
            int[] y = new int[N];

            LerVetor(x, "X");
            LerVetor(y, "Y");

            Console.WriteLine("Soma:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(x[i] + y[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Produto:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(x[i] * y[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Diferenca (X - Y):");
            for (int i = 0; i < N; i++)
            {
                bool existe = false;

                for (int j = 0; j < N; j++)
                {
                    if (x[i] == y[j])
                    {
                        existe = true;
                    }
                }

                if (!existe)
                {
                    Console.Write(x[i] + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Intersecao:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (x[i] == y[j])
                    {
                        Console.Write(x[i] + " ");
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Uniao:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(x[i] + " ");
            }

            for (int i = 0; i < N; i++)
            {
                bool existe = false;

                for (int j = 0; j < N; j++)
                {
                    if (y[i] == x[j])
                    {
                        existe = true;
                    }
                }

                if (!existe)
                {
                    Console.Write(y[i] + " ");
                }
            }
        }
    }
}
