using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob20
    {
        //Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). 

        static void Main(string[] args)
        {
            fractie();
            fractie2();
        }
        private static void fractie()
        {
            int m = 13;
            int n = 30;
            double d;

            d = (double)m / n;
            Console.WriteLine(d);

            double fract = d - Math.Truncate(d);

            int maxDecimal = 6;
            while (maxDecimal > 0 && fract != 0)
            {
                // fract = 0.43
                int cifraZecimala;
                cifraZecimala = (int)Math.Truncate(fract * 10);
                Console.WriteLine($"{cifraZecimala} ");


                fract = fract * 10 - Math.Truncate(fract * 10);


                maxDecimal--;
            }
        }
   

        /// <summary>
        /// Afisati fractia m/n in format zecimal, 
        /// cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)
        /// </summary>
        // 13 : 30
        //13 * 10 / 30 = 4 r 10
        //10 * 10 / 30 = 3 r 10
        private static void fractie2()
        {
            int m = 1, n = 3;

            int parteInt, parteFract;
            parteInt = m / n; // 0
            parteFract = m % n; // 13
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                //Console.Write($"{cifra}");
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
    }
}
