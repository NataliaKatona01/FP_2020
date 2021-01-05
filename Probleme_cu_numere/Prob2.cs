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

            float a, b, c, d, x1, x2, i;

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            Console.WriteLine($"ecuatia {a}x^2 + {b}x + {c} = 0");

            if (a != 0)
            {
                d = b * b - 4 * a * c;

                if (d < 0)
                    Console.WriteLine("Ecuatia nu are solutii reale.");
                else
                {
                    x1 = (float)(-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (float)(-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine($"x1 = {x1} {Environment.NewLine}x2 = {x2} ");
                }
            }
            else
            {

                if (b != 0)
                {
                    x1 = -c / b;
                    Console.WriteLine($"Ecuatie de gradul 1: X1={x1}");
                }
                else
                {
                    if (c == 0)
                        Console.WriteLine("Solutie nedeterminata");
                    else
                        Console.WriteLine("Ecuatie imposibila");
                }
            }
        }
    }
}