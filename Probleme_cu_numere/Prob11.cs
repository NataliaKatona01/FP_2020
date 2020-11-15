using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob11
    {
        // Afisati in ordine inversa cifrele unui numar n. 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nr;
            while (n != 0 && n > 0)
            {
                nr = n % 10;
                Console.WriteLine($"{nr}");
                n = n / 10;
            }
        }
    }
}
