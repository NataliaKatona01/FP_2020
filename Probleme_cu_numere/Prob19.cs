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
            int a, b = -1;
            bool ok = true;
            a = n % 10;
            n = n / 10;

            while (n != 0)
            {
                if (n % 10 != a && b == -1)
                    b = n % 10;
                if (n % 10 != a && n % 10 != b)
                    ok = false;
                n = n / 10;
            }
            if(ok)
                Console.WriteLine("Numarul este format doar cu 2 cifre");
            else
                Console.WriteLine("Numarul nu este format doar cu 2 cifre");

        }

    }
}
