using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob12
    {
        //Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. 
        //Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. 
        //De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n - 1; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr == 0 && a!= 0)
                    count++;
                a = nr;
            }
            int m = int.Parse(Console.ReadLine());
            if (m != 0)
                count++;
            else
                if (a != 0)
                count++;

            Console.WriteLine($"{count} grupuri de numere consecutive diferite de zero.");
        }
    }
}
