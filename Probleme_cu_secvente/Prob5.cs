using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob5
    {
        //Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. 
        //Se considera ca primul element din secventa este pe pozitia 0. 

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int contor = 0;
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());

                if (nr == i)
                    contor++;
            }
            Console.WriteLine($"{contor} elemente sunt egale cu pozitia pe care apar.");

        }
    }
}
