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
            Estacionamento est = new Estacionamento("stop", 30);

            if(est.Estacionar("1234") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("1234")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            if (est.Estacionar("8754") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("8754")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            if (est.Estacionar("9999") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("9999")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            if (est.Estacionar("8765") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("8765")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            if (est.Estacionar("9182") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("9182")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            est.ExibirOcupacao();

            if (est.BuscarNumVaga("1234") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.BuscarNumVaga("1234")}");
            }
            else
            {
                Console.WriteLine("Placa não encontrada.");
            }

            est.Retirar("9999");

            est.ExibirOcupacao();

            if (est.Estacionar("6655") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("6655")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            if (est.Estacionar("9000") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("9000")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            if (est.Estacionar("1111") != -1)
            {
                Console.WriteLine($"O carro foi estacionado na vaga {est.Estacionar("1111")}");
            }
            else
            {
                Console.WriteLine("Estacionamento cheio");
            }

            est.ExibirOcupacao();

            int vagasLivres = est.NumVagasLivres;
            Console.WriteLine($"Número de vagas livres: {vagasLivres}");

        }
    }
}
