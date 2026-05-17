
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

        public void Mostrar()
        {
            int i = primeiro;
            while(i != ultimo)
            {
                Console.WriteLine($"Arquivo: {array[i].nome} - Páginas: {array[i].tam}");
                i = (i + 1) % array.Length;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila(100);
            int op;
            string nome;
            int tam;
            Console.WriteLine("Escolha: 1. Inserir - 2. Remover - 3. Mostrar - 4. Encerrar o programa:");
            op = int.Parse(Console.ReadLine());
            while(op != 4)
            {
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite nome e quantidade de paginas do arquivo: ");
                        nome = Console.ReadLine();
                        tam = int.Parse(Console.ReadLine());
                        Arquivo arq = new Arquivo(nome, tam);
                        fila.Inserir(arq);
                        break;
                    case 2:
                        Arquivo temp;
                        temp = fila.Remover();
                        Console.WriteLine($"O arquivo {temp.nome} foi removido");
                        break;
                    case 3:
                        fila.Mostrar();
                        break;
                    case 4:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
                Console.WriteLine("Escolha: 1. Inserir - 2. Remover - 3. Mostrar - 4. Encerrar o programa:");
                op = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
