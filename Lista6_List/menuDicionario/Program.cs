using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menuDicionario
{
    public class Dicionario
    {
        public string palavra;
        public string significado;

        public Dicionario(string palavra, string significado)
        {
            this.palavra = palavra;
            this.significado = significado;
        }

        Dictionary<string,string> dict = new Dictionary<string,string>();

        public void Cadastrar()
        {
            if (dict.ContainsKey(palavra))
            {

            }
            else
            {
                dict.Add(palavra, significado);
            }
              
        }
        public void Traduzir()
        {
            if (dict.ContainsKey(palavra))
            {
                Console.WriteLine(dict[palavra]);
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dicionario dict1 = new Dicionario("casa", "house");
            Dicionario dict2 = new Dicionario("carro", "car");

            dict1.Cadastrar();
            dict1.Traduzir();

            Console.WriteLine();

            dict2.Cadastrar(); 
            dict2.Traduzir();



        }
    }
}
