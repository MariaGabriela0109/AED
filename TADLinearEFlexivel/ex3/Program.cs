using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Fila
    {
        public string[] array;
        public int primeiro;
        public int ultimo;

        public Fila(int tamanho)
        {
            array = new string[tamanho + 1];
            primeiro = ultimo = 0;
        }

        public int ContarSucessores(string nome)
        {
            int cont = 0,  i = primeiro;
            int j = 0;
            while (i != ultimo)
            {
                if (array[i] == nome)
                {
                    j = (i + 1) % array.Length;
                    while (j != ultimo)
                    {
                        cont++;
                        j = (j + 1) % array.Length;
                    }
                }
                else
                {
                    throw new Exception("Nome não se encontra na fila.");
                }
                
                i = (i + 1) % array.Length;
            }
            return cont;

        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {

        }
    }
}
