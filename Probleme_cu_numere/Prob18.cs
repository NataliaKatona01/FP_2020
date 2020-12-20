using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob18
    {
        //Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divizor, putere;

            divizor = 2;

            while (n > 1)
            {
                putere = 0;
                
                while (n % divizor == 0)
                {
                    putere++;
                    n = n / divizor;
                }
                if (putere > 0)
                    Console.Write($"{divizor}^{putere} x ");
                divizor++;
            }

        }
    }
}
