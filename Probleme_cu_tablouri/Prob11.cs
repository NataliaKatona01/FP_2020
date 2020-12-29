using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob11
    {
        //Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 

        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] sieve = new int[n + 1];
            for (int i = 2; i <= n; i++)
                sieve[i] = i;

            for (int i = 2; i <= n / 2; i++)
            {
                if (sieve[i] != 0)
                {
                    for (int j = 2 * i; j <= n; j += i)
                    {
                        if (sieve[j] != 0)
                            sieve[j] = 0;
                    }
                }

            }
            for (int i = 2; i <= n; i++)
                if (sieve[i] != 0)
                    Console.Write(sieve[i] + " ");
            Console.WriteLine();
        }
    }
}

