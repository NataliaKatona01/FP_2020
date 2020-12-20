using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob7
    {
        //Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int min = int.Parse(Console.ReadLine());
            int max = min;
            for (int i = 1; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr < min)
                    min = nr;
                else
                    if(max < nr)
                    max = nr;
            }
            Console.WriteLine($"Cea mai mare valoare este {max}, iar cea mai mica valoare este {min}");

        }
    }
}
