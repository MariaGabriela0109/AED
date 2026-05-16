using System;
namespace ex1
{
    class Pilha
    {
        public int[] pilha;
        public int topo;
        
        public Pilha(int tam)
        {
            this.pilha = new int[tam];
            this.topo = 0;
        }
        public void Empilhar(int valor)
        {
            if(topo == pilha.Length)
                Console.WriteLine("Pilha cheia");
            else
            {
                pilha[topo] = valor;
                topo++;
            }            
        }
        public int Desempilhar()
        {
            if (topo == 0)
            {
                Console.WriteLine("Pilha vazia");
                return -1;
            }
            else
            {
                topo--;
                return pilha[topo];
            }            
        }      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um tamanho para a pilha: ");
            int tam = int.Parse(Console.ReadLine());

            Pilha pilha = new Pilha(tam);

            Console.WriteLine("Digite um número na base decimal para converter para octal: ");
            int num = int.Parse(Console.ReadLine());

            int result = - 1;

            while(result != 0)
            {
                result = num / 8;
                pilha.Empilhar(num % 8);
                num = result;
            }

            while (pilha.topo != 0)
            {
                int temp = pilha.Desempilhar();
                Console.Write(temp);
            }

        }
    }
}
