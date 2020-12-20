using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob19
    {
        //Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, 
        //pe cand 593 si 4022 nu sunt. 

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int nr = n;
            cifre(n);
            Console.WriteLine();
            egalitate();

        }

        private static void egalitate(int []v)
        {
            for (int i = 0; i <= 9; i++)
            {

            }
        }

        private static void cifre(int n)
        {
            int cifra; ;
            while (n > 0)
            {
                cifra = n % 10;
                n = n / 10;
                Console.WriteLine(cifra);
            }
        }
    }
}
