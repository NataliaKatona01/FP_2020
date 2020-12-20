using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob3
    {
        //Calculati suma si produsul numerelor de la 1 la n. 

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0, produs = 1;

            for (int i = 1; i <= n; i++)
            {
                suma += i;
                produs *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este: {suma}, iar produsul este: {produs}");
        }
    }
}
