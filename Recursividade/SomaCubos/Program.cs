using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaCubos
{
    internal class Program
    {
        static int SomaCubos(int n)
        {
            if (n == 1)
                return 1;
            return SomaCubos(n-1) + (n * n * n);
        }

        static void Main(string[] args)
        {

        }
    }
}
