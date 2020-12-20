using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob14
    {
        //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nr = n;
            int inv = 0;
            int cifra;

            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                inv = inv * 10 + cifra;
            }
            if(nr == inv)
            Console.WriteLine($"Numarul {nr} este palindrom.");
            else
                Console.WriteLine($"Numarul {nr} nu este palindrom");
        }
    }
}
