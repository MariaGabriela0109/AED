using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        class Produto
        {
            private string nome;
            private int quant;
            private double preco;

            public Produto(string nome, int quant, double preco)
            {
                this.nome = nome;
                this.quant = quant;
                this.preco = preco;
            }

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public int Quant
            {
                get { return quant; }
                set { quant = value; }
            }

            public double Preco
            {
                get { return preco; }
                set { preco = value; }
            }

            public override string ToString()
            {
                return nome + " " + quant + " " + preco;
            }
        }

        class Lista
        {
            private Produto[] array;
            private int n;

            public Lista()
            {
                array = new Produto[100];
                n = 0;
            }

            public void InserirFim(Produto p)
            {
                if (n >= array.Length)
                {
                    throw new Exception("Erro!");
                }
                array[n] = p;
                n++;
            }

            public Produto RemoverItem(string nome)
            {
                Produto resp = null;
                bool achou = false;

                for (int i = 0; i < n && !achou; i++)
                {
                    if (array[i].Nome == nome)
                    {
                        resp = array[i];
                        n--;

                        for (int j = i; j < n; j++)
                        {
                            array[j] = array[j + 1];
                        }

                        achou = true;
                    }
                }

                return resp;
            }

            public void Mostrar()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            public bool Pesquisar(string nome)
            {
                bool achou = false;

                for (int i = 0; i < n && !achou; i++)
                {
                    if (array[i].Nome == nome)
                    {
                        achou = true;
                    }
                }

                return achou;
            }
        }

        static void Main(string[] args)
        {
            Lista lista = new Lista();
            string linha = Console.ReadLine();

            while (linha != null && linha != "")
            {
                int op = int.Parse(linha);
                Console.WriteLine("Op:");

                if (op == 1)
                {
                    string nome = Console.ReadLine();
                    int quant = int.Parse(Console.ReadLine());
                    double preco = double.Parse(Console.ReadLine());

                    Produto p = new Produto(nome, quant, preco);
                    lista.InserirFim(p);
                }
                else if (op == 2)
                {
                    string nome = Console.ReadLine();
                    Produto p = lista.RemoverItem(nome);

                    if (p != null)
                    {
                        Console.WriteLine(p.ToString());
                    }
                    else
                    {
                        Console.WriteLine("produto não encontrado");
                    }
                }
                else if (op == 3)
                {
                    lista.Mostrar();
                }
                else if (op == 4)
                {
                    string nome = Console.ReadLine();
                    bool resp = lista.Pesquisar(nome);

                    if (resp)
                    {
                        Console.WriteLine("produto cadastrado");
                    }
                    else
                    {
                        Console.WriteLine("produto não cadastrado");
                    }
                }
                else if (op == 5)
                {
                    break;
                }

                linha = Console.ReadLine();
            }

        }
    }

}
