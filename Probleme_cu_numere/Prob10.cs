using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob10
    {
        //Test de primalitate: determinati daca un numar n este prim.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n))
                Console.WriteLine("Numarul este prim");
            else
                Console.WriteLine("Numarul nu este prim");

        }

        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
          
            for (int d = 3; d * d <= n; d += 2)
            {
                if (n % d == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
