using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob17
    {
        //Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int a1, b1, cmmmc;
            a1 = a;
            b1 = b;

            int r = 0;
            while (b != 0)
            {
                r = a % b;
                a = b;
                b = r;

            }

            Console.WriteLine($"Cel mai mare divizor comun al numerelor {a1} si {b1} este: {a}");

            cmmmc = (a1 * b1) / a;
            Console.WriteLine($"Cel mai mic multiplu comun al numerelor {a1} si {b1} este: {cmmmc}");



        }
    
    }
}

