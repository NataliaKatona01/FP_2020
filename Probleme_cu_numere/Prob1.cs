using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Program
    {
        //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.
        static void Main(string[] args)
        {
            int a, b;
            double x;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ecuatia de gradul 1: {a}x + {b} = 0");
            if (a != 0)
            {
                x = -b / a;
                Console.WriteLine($"x = {x}");
            }
            else
                Console.WriteLine("x nedeterminat");
        }
    }
}
