using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob10
    {
        //Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 1, maxCount = 0;
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (a == nr)
                    count++;
                else
                if (count > maxCount)
                {
                    maxCount = count;
                    count = 1;
                }   
                a = nr;
            }
            if (count > maxCount)
                maxCount = count;
                Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {maxCount}");
        }
    }
}
