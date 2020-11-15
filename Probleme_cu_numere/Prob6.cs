using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob6
    {
        //Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        static void Main(string[] args)
        {
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
                Console.WriteLine($"{a}, {b} si {c} pot fi lungimile laturilor unui triunghi");
            else
                Console.WriteLine($"{a}, {b} si {c} nu pot fi lungimile laturilor unui triunghi");
        }
    }
}
