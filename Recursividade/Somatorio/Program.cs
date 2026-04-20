using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somatorio
{
    internal class Program
    {
        static int Somatorio(int n)
        {
            if(n == 1)
                return 1;
            return Somatorio(n - 1) + n;
        }
        static void Main(string[] args)
        {
            int aux = Somatorio(2);
            Console.WriteLine(aux);
        }
    }
}
