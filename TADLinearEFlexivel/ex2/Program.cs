using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Pilha
    {
        public double[] array;
        public int topo;
        

        public Pilha(int tam)
        {
            array = new double[tam];
            topo = 0;
        }

        public void Empilhar(double elemento)
        {
            if(topo != array.Length)
            {
                array[topo] = elemento;
                topo++;
            }
            else
            {
                throw new Exception("Pilha cheia");
            }
        }
        public double Desempilhar()
        {
            if (topo != 0)
            {
                topo--;
                double temp = array[topo];
                return temp;
            }
            else
            {
                throw new Exception("Pilha vazia");
            }
            
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Digite o tamanho da pilha: ");
            int tam = int.Parse(Console.ReadLine());
            Pilha pilha = new Pilha(tam);

            string notacao = " ";

            Console.WriteLine("Digite a notação polonesa: ");
            notacao = Console.ReadLine();

            for(int i = 0; i < notacao.Length; i++)
            {
                if (notacao[i] != '-' && notacao[i] != '*' && notacao[i] != '/' && notacao[i] != '+')
                {
                    double num = (double)Char.GetNumericValue(notacao[i]);
                    pilha.Empilhar(num);
                }
                else
                {
                    char temp = notacao[i];
                    
                    double letra1;
                    double letra2;

                    letra1 = pilha.Desempilhar();
                    letra2 = pilha.Desempilhar();

                    if(temp == '-')
                    {
                        double result = letra2 - letra1;
                        pilha.Empilhar(result);
                    }
                    else if(temp == '*')
                    {
                        double result = letra2 * letra1;
                        pilha.Empilhar(result);
                    }
                    else if (temp == '/')
                    {
                        double result = letra2 / letra1;
                        pilha.Empilhar(result);
                    }
                    else if (temp == '+')
                    {
                        double result = letra2 + letra1;
                        pilha.Empilhar(result);
                    }
                }
               
            }

            double resultadoFinal = pilha.Desempilhar();
            Console.WriteLine($"O resultado da expressão é: {resultadoFinal}");

        }
    }
}
