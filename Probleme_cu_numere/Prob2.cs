using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob1
    {
        static void Main(string[] args)
        {
            //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
            //Tratati toate cazurile posibile. 
            int a, b, c;
            float d, x1, x2;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            Console.WriteLine($"ecuatia {a}x^2 + {b}x + c = 0");

            d = b*b - 4 * a * c;

            if (d == 0)
            {
              //  x1 = ((-b) + (Math.Sqrt(d))) / 2 * a;

            }

        }
    }
}
