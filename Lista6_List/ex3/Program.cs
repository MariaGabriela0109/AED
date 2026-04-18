using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> decolagem = new Queue<string>();
            int opcao = 0;

            while (opcao != 6)
            {
                Console.WriteLine("Op:");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine(decolagem.Count);
                }
                else if (opcao == 2)
                {
                    if (decolagem.Count > 0)
                    {
                        string aviao = decolagem.Dequeue();
                        Console.WriteLine(aviao);
                    }
                }
                else if (opcao == 3)
                {
                    string novoAviao = Console.ReadLine();
                    decolagem.Enqueue(novoAviao);
                }
                else if (opcao == 4)
                {
                    foreach (string aviao in decolagem)
                    {
                        Console.WriteLine(aviao);
                    }
                }
                else if (opcao == 5)
                {
                    if (decolagem.Count > 0)
                    {
                        Console.WriteLine(decolagem.Peek());
                    }
                }
            }
        }
    }
}
}
