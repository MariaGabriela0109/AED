using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Estacionamento
    {
        private string nome;
        private int numVagasLivres;
        private string[] vagas;

        public int NumVagasLivres
        {
            get { return numVagasLivres; }
        }
        public Estacionamento(string nome, int numTotalVagas)
        {
            this.nome = nome;
            this.numVagasLivres = numTotalVagas;
            vagas = new string[numTotalVagas];
        }
        public int Estacionar(string placa)
        {
            for(int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == null)
                {
                    vagas[i] = placa;
                    numVagasLivres--;
                    return i;

                }
            }
            return -1;
        }
        public int BuscarNumVaga(string placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == placa)
                {
                    return i;
                }
            }
            return -1;
        }
        public void Retirar(string placa)
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] == placa)
                {
                    vagas[i] = null;
                    numVagasLivres++;
                }
           
            }
        }

        public void ExibirOcupacao()
        {
            for (int i = 0; i < vagas.Length; i++)
            {
                if (vagas[i] != null)
                {
                    Console.WriteLine($"Vaga {i} ocupada por placa: {vagas[i]}");
                }
                Console.WriteLine($"A vaga {i} está vazia");
            }
        }
        

    }
}
