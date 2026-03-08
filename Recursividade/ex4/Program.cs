using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void ToBinari(int n)
        {
            if (n == 0)
                return;
            ToBinari(n / 2);
            Console.Write(n % 2);
        }
        static void Main(string[] args)
        {
            ToBinari(12);
        }
    }
}
