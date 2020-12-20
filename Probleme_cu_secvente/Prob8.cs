using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob8
    {
        //Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel:
        //f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            int a = 0, b = 1;
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este {c}");
        }
    }
}
