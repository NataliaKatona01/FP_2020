using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob14
    {
        //O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa 
        //montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita.

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool crescator = true;
            bool rotita = true;

            int a = int.Parse(Console.ReadLine());
            int min = a;
            for (int i = 1; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());

                if (!crescator && (min < nr || a > nr))
                    rotita = false;
                if (a > nr)
                    crescator = false;
                a = nr;
            }
            if (crescator || rotita)
                Console.WriteLine($"Secventa este crescatoare rotita");
            else
                Console.WriteLine($"Secventa nu este crescatoare rotita");
        }
    }
}
