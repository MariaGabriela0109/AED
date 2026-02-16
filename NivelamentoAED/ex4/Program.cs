using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static int LerVotos(int[] votos)
        {
            int nulos = 0;

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Voto do aluno " + (i + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero >= 0 && numero < votos.Length)
                {
                    votos[numero]++;
                }
                else
                {
                    nulos++;
                }
            }

            return nulos;
        }
        static void Main(string[] args)
        {
            Console.Write("Quantidade de candidatos: ");
            int qtd = int.Parse(Console.ReadLine());

            string[] nomes = new string[qtd];
            int[] votos = new int[qtd];

            for (int i = 0; i < qtd; i++)
            {
                Console.Write("Nome do candidato " + i + ": ");
                nomes[i] = Console.ReadLine();
            }

            int nulos = LerVotos(votos);

            int maior = votos[0];
            int menor = votos[0];
            int posMaior = 0;
            int posMenor = 0;

            for (int i = 1; i < qtd; i++)
            {
                if (votos[i] > maior)
                {
                    maior = votos[i];
                    posMaior = i;
                }

                if (votos[i] < menor)
                {
                    menor = votos[i];
                    posMenor = i;
                }
            }

            Console.WriteLine("Mais votado: " + nomes[posMaior] + " - " + maior + " votos");
            Console.WriteLine("Menos votado: numero " + posMenor + " - " + menor + " votos");
            Console.WriteLine("Votos nulos: " + nulos);
        }
    }
}
