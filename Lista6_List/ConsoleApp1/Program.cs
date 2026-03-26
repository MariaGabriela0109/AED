using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> corrida = new List<double>();

            double tempo = 0;
            int pos = -1;
            int op = -1;

            do
            {
                Console.WriteLine("Op:");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        tempo = double.Parse(Console.ReadLine());
                        corrida.Insert(0, tempo);
                        break;
                    case 2:
                        tempo = double.Parse(Console.ReadLine());
                        corrida.Add(tempo);
                        break;
                    case 3:
                        tempo = double.Parse(Console.ReadLine());
                        pos = int.Parse(Console.ReadLine());
                        corrida.Insert(pos, tempo);
                        break;
                    case 4:
                        Console.WriteLine(corrida[0]);
                        corrida.RemoveAt(0);
                        break;
                    case 5:
                        Console.WriteLine(corrida[corrida.Count - 1]);
                        corrida.RemoveAt(corrida.Count - 1);
                        break;
                    case 6:
                        pos = int.Parse(Console.ReadLine());
                        Console.WriteLine(corrida[pos]);
                        corrida.RemoveAt(pos);
                        break;
                    case 7:
                        tempo = double.Parse(Console.ReadLine());
                        corrida.Remove(tempo);
                        break;
                    case 8:
                        int aux = 0;
                        tempo = double.Parse(Console.ReadLine());
                        for (int i = 0; i < corrida.Count; i++)
                        {
                            if (corrida[i] == tempo)
                            {
                                aux++;
                            }
                        }
                        Console.WriteLine(aux);
                        break;
                    case 9:
                        for (int i = 0; i < corrida.Count; i++)
                        {
                            Console.WriteLine(corrida[i]);
                        }
                        break;
                    case 10:
                        corrida.Sort();
                        for (int i = 0; i < corrida.Count; i++)
                        {
                            Console.WriteLine(corrida[i]);
                        }
                        break;
                    case 11:
                        corrida.Sort();
                        corrida.Reverse();
                        for (int i = 0; i < corrida.Count; i++)
                        {
                            Console.WriteLine(corrida[i]);
                        }
                        break;
                    case 12:
                        break;

                    default:
                        break;
                }

            } while (op != 12);
        }
    }
}
/* Aviso de estrutura:
 A interface de texto e as saídas deste programa foram minimizadas 
 propositalmente para corresponder ao output exigido 
 pelo sistema de correção automática Verde. Menus interativos 
 foram omitidos para evitar erros de validação
 */
