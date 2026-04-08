using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sequência de parênteses e colchetes:");
            string expressao = Console.ReadLine();

            Stack<char> sequencia = new Stack<char>();

            bool isEqual = true;

            for (int i = 0; i < expressao.Length; i++)
            {
                if (expressao[i] == '(' || expressao[i] == '[')
                    sequencia.Push(expressao[i]);

                else if (expressao[i] == ')' || expressao[i] == ']')
                {

                    if (sequencia.Count == 0)
                    {
                        isEqual = false;
                        break; 
                    }

                    char topo = sequencia.Pop();

                    if (topo == '(' && expressao[i] != ')' || topo == '[' && expressao[i] != ']')
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            if (sequencia.Count > 0)
                isEqual = false;

            if (isEqual)
                Console.WriteLine("Correta");

            else
                Console.WriteLine("Incorreta");

        }
    }
}
