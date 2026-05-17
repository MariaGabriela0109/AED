
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Arquivo
    {
        public string nome;
        public int tam;

        public Arquivo(string nome, int tam)
        {
            this.nome = nome;
            this.tam = tam;
        }
    }

    class Fila
    {
        public Arquivo[] array;
        public int primeiro, ultimo;

        public Fila(int tam)
        {
            array = new Arquivo[tam + 1];
            primeiro = ultimo = 0;
        }
        public void Inserir(Arquivo arq)
        {
            if((ultimo + 1) % array.Length != primeiro)
            {
                array[ultimo] = arq;
                ultimo = (ultimo + 1) % array.Length;
            }
            else
            {
                throw new Exception("fila cheia");
            }
        }

        public Arquivo Remover()
        {
            if(ultimo == primeiro)
            {
                throw new Exception("Lista vazia");
            }
            else
            {
                Arquivo temp = array[primeiro];
                primeiro = (primeiro + 1) % array.Length;
                return temp;
            }            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
