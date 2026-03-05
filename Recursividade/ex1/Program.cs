using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static int Poten(int a, int n)
        {
            int resp;
            if (n == 0)
                resp = 1;
            else
                resp = Poten(a, n - 1) * a;
            return resp;


        }
        static void Main(string[] args)
        {
            int r = Poten(4, 3);
            Console.WriteLine(r);
        }
    }
}
