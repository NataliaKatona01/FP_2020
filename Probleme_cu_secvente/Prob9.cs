using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob9
    {
        //Sa se determine daca o secventa de n numere este monotona. 
        //Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.

        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            bool crescatoare = true;
            bool descrescatoare = true;

            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (a > nr)
                    crescatoare = false;
                if (a < nr)
                    descrescatoare = false;
                a = nr;

            }
            if (crescatoare)
                Console.WriteLine("Secventa este monoton crescatoare.");
            else
            if(descrescatoare)
                Console.WriteLine("Secventa este monoton descrescatoare.");
            else
                Console.WriteLine("Secventa nu este monotona.");
        }
    }
}
