using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class CelulaDupla
    {
        public string elemento;
        public CelulaDupla prox;
        public CelulaDupla ant;

        public CelulaDupla(string elemento)
        {
            this.elemento = elemento;
            this.ant = null;
            this.prox = null;
        }
        public CelulaDupla()
        {
            this.elemento = " ";
            this.ant = null;
            this.prox = null;
        }
    }

    class ListaDupla
    {
        public CelulaDupla primeiro, ultimo;
        public ListaDupla()
        {
            primeiro = new CelulaDupla();
            ultimo = primeiro;
        }

        public string[] PesquisarVisinho(string x)
        {
            string[] vet = new string[2];

            CelulaDupla i;
            for(i = primeiro.prox; i != null; i = i.prox)
            {
                if(i.elemento == x)
                {
                    if (i.ant == primeiro)
                    {
                        vet[0] = null; 
                    }
                    else
                    {
                        vet[0] = i.ant.elemento;
                    }

                    if (i.prox == null)
                    {
                        vet[1] = null; 
                    }
                    else
                    {
                        vet[1] = i.prox.elemento;
                    }
                    break;
                }
            }

            return vet;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
