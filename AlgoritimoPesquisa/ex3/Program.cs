using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class No
    {
        public string elemento;
        public No esq, dir;

        public No(string elemento)
        {
            this.elemento = elemento;
            this.esq = null;
            this.dir = null;
        }

        public No(string elemento, No esq, No dir)
        {
            this.elemento = elemento;
            this.esq = esq;
            this.dir = dir;
        }
    }

    class ArvoreBinaria
    {
        private No raiz;

        public ArvoreBinaria()
        {
            raiz = null;
        }

        public void Inserir(string x)
        {
            raiz = Inserir(x, raiz);
        }

        private No Inserir(string x, No i)
        {
            if (i == null)
            {
                i = new No(x);
            }
            else if (x.CompareTo(i.elemento) < 0)
            {
                i.esq = Inserir(x, i.esq);
            }
            else if (x.CompareTo(i.elemento) > 0)
            {
                i.dir = Inserir(x, i.dir);
            }
            return i;
        }

        public void Remover(string x)
        {
            raiz = Remover(x, raiz);
        }

        private No Remover(string x, No i)
        {
            if (i == null)
            {
                // Elemento não encontrado
            }
            else if (x.CompareTo(i.elemento) < 0)
            {
                i.esq = Remover(x, i.esq);
            }
            else if (x.CompareTo(i.elemento) > 0)
            {
                i.dir = Remover(x, i.dir);
            }
            else if (i.dir == null)
            {
                i = i.esq;
            }
            else if (i.esq == null)
            {
                i = i.dir;
            }
            else
            {
                i.esq = MaiorEsq(i, i.esq);
            }
            return i;
        }

        private No MaiorEsq(No i, No j)
        {
            if (j.dir == null)
            {
                i.elemento = j.elemento;
                j = j.esq;
            }
            else
            {
                j.dir = MaiorEsq(i, j.dir);
            }
            return j;
        }

        public bool Pesquisar(string x)
        {
            return Pesquisar(x, raiz);
        }

        private bool Pesquisar(string x, No i)
        {
            if (i == null)
            {
                return false;
            }
            else if (x.CompareTo(i.elemento) == 0)
            {
                return true;
            }
            else if (x.CompareTo(i.elemento) < 0)
            {
                return Pesquisar(x, i.esq);
            }
            else
            {
                return Pesquisar(x, i.dir);
            }
        }

        public void CaminharCentral()
        {
            CaminharCentral(raiz);
            Console.WriteLine();
        }

        private void CaminharCentral(No i)
        {
            if (i != null)
            {
                CaminharCentral(i.esq);
                Console.Write(i.elemento + " ");
                CaminharCentral(i.dir);
            }
        }

        public void CaminharPre()
        {
            CaminharPre(raiz);
            Console.WriteLine();
        }

        private void CaminharPre(No i)
        {
            if (i != null)
            {
                Console.Write(i.elemento + " ");
                CaminharPre(i.esq);
                CaminharPre(i.dir);
            }
        }

        public void CaminharPos()
        {
            CaminharPos(raiz);
            Console.WriteLine();
        }

        private void CaminharPos(No i)
        {
            if (i != null)
            {
                CaminharPos(i.esq);
                CaminharPos(i.dir);
                Console.Write(i.elemento + " ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();
            string linha;

            while (true)
            {
                Console.WriteLine("Op:");
                linha = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(linha)) break;

                int op = int.Parse(linha.Trim());
                string nome;

                switch (op)
                {
                    case 1:
                        nome = Console.ReadLine().Trim();
                        arvore.Inserir(nome);
                        break;
                    case 2:
                        nome = Console.ReadLine().Trim();
                        arvore.Remover(nome);
                        break;
                    case 3:
                        nome = Console.ReadLine().Trim();
                        if (arvore.Pesquisar(nome))
                        {
                            Console.WriteLine("sim");
                        }
                        else
                        {
                            Console.WriteLine("nao");
                        }
                        break;
                    case 4:
                        arvore.CaminharCentral();
                        break;
                    case 5:
                        arvore.CaminharPos();
                        break;
                    case 6:
                        arvore.CaminharPre();
                        break;
                    case 7:
                        return;
                }
            }
        }
    }
}