using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob6
    {
        //Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            bool crescatoare = true;
            for (int i = 1; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr < a)
                    crescatoare = false;
                a = nr;
            }
            if (crescatoare)
            Console.WriteLine($"Secventa este crescatoare");
            else
                Console.WriteLine($"Secventa nu este crescatoare");
        }
    }
}
