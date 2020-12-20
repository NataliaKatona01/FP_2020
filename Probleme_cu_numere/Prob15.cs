using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob15
    {
        //Se dau 3 numere. Sa se afiseze in ordine crescatoare.

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int[] numere = { a, b, c };

            Array.Sort(numere);

            foreach (int i in numere)
                Console.WriteLine(i);

            /*
            if (a < b)
            {
                if (a < c)
                {
                    if (b < c)
                        Console.WriteLine($"{a}, {b}, {c}");
                    else
                        Console.WriteLine($"{a}, {c}, {b}");

                }
                else
                    Console.WriteLine($"{c}, {a}, {b}");
            }
            else
            { 
            if (a < c)
                Console.WriteLine($"{b}, {a}, {c}");
            else
                Console.WriteLine($"{b}, {c}, {a}");
            if (c < b)
                Console.WriteLine($"{c}, {b}, {a}");
            }    */
        }
    }
}
