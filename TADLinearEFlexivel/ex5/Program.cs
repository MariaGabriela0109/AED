using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Produto
    {
        public string nome;
        public int quant;
        public double preco;

        public Produto(string nome, int quant, double preco)
        {
            this.nome = nome;
            this.quant = quant;
            this.preco = preco;
        }
    }
    class Lista
    {
        public Produto[] array;
        public int n;

        public Lista(int tam)
        {
            array = new Produto[tam];
            n = 0;
        }

        public void InserirInicio(Produto elemento)
        {
            if (n >= array.Length)
            {
                throw new Exception("Erro!");
            }//n sempre vai apontar a ultima pos vazia
            else
            {
                for(int i = n; i > 0; i--)
                {
                    array[i] = array[i - 1];
                }
            }
            array[0] = elemento;
            n++;
        }
        public void InserirFim(Produto elemento)
        {
            if (n <= array.Length - 1)
            {
                array[n] = elemento;
                n++;
            }
            else
            {
                throw new Exception("Erro!");
            }
        }

        public void Inserir(int pos, Produto elemento)
        {
            if(pos >= 0 && pos > array.Length)
            {
                if (pos == 0)
                {
                    InserirInicio(elemento);
                }
                else if (pos == n)
                {
                    InserirFim(elemento);
                }
                else
                {
                    for (int i = n; i >= pos; i--)
                    {
                        array[i] = array[i - 1];
                    }
                    array[pos] = elemento;
                    n++;
                }
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
