using System;
using System.Collections.Generic;


namespace menuDicionarioNoClass
{
    internal class Program
    {
        public static Dictionary<string, string> Cadastrar(string palavra, string significado, Dictionary<string, string> dicionario)
        {
            if (!dicionario.ContainsKey(palavra))
            {
                dicionario.Add(palavra, significado);
            }
            
            return dicionario;
        }

        public static Dictionary<string, string> Traduzir(string palavra, Dictionary<string, string> dicionario)
        {
            if (!dicionario.ContainsKey(palavra))
            {
                Console.WriteLine("Palavra não encontrada");
            }
            Console.WriteLine(dicionario[palavra]);
            return dicionario;
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> dicionario = new Dictionary<string, string>();

            Cadastrar("casa", "house", dicionario);
            Traduzir("casa", dicionario);
    
                Console.WriteLine();
    
            Cadastrar("carro", "car", dicionario);
            Traduzir("carro", dicionario);

        }
    }
}
