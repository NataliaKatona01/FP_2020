using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob9
    {
        //Afisati toti divizorii numarului n. 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Divizorii numarului {n} sunt :");
            for (int i = 2; i <= n ; i++)
            {
                if (n % i == 0)
                     Console.WriteLine($"{i} ");
            }
        }

    }
}
