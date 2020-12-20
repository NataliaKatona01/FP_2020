using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob2
    {
        //Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a, contorNeg = 0, contorPoz = 0, contorZero = 0; 
            for (int i= 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                    contorNeg++;
                if (a > 0)
                    contorPoz++;
                if (a == 0)
                    contorZero++;
            }
            Console.WriteLine($"{contorNeg} numere negative, {contorPoz} numere pozitive si {contorZero} numere = zero");
            
        }
    }
}
