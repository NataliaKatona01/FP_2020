using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob12
    {
        //Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b]. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Intervalul: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int contor = 0; 
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    contor++;
            }
            Console.WriteLine($"{contor} numere intregi divizibile cu {n} in intervalul [{a}, {b}]");
        }
    }
}
