using System;
using System.Collections.Generic;

namespace menuDicionario
{
    public class Dicionario
    {

        Dictionary<string,string> dict = new Dictionary<string,string>();

        public void Cadastrar(string palavra, string significado)
        {
            if (!dict.ContainsKey(palavra))
            {
                dict.Add(palavra, significado);
            }
              
        }
        public void Traduzir(string palavra)
        {
            if (!dict.ContainsKey(palavra))
            {
                Console.WriteLine("Palavra não encontrada");
                return;
            }
            Console.WriteLine(dict[palavra]);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dicionario dict1 = new Dicionario();

            dict1.Cadastrar("casa", "house");
            dict1.Traduzir("casa");

            Console.WriteLine();

           


        }
    }
}
