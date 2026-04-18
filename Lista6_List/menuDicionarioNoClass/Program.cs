using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuDicionarioNoClass
{
    internal class Program
    {
        public static Dictionary<string, string> Cadastrar(string palavra, string significado, Dictionary<string, string> dicionario)
        {
            if (dicionario.ContainsKey(palavra))
            {
            }
            else
            {
                dicionario.Add(palavra, significado);
            }
            return dicionario;
        }

        public static Dictionary<string, string> Traduzir(string palavra, Dictionary<string, string> dicionario)
        {
            if (dicionario.ContainsKey(palavra))
            {
                Console.WriteLine(dicionario[palavra]);
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }
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
