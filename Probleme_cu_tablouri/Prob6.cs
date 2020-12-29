using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob6
    {
        //Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe
        //pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int[] v = new int[100];
            Random rnd = new Random();

            if(k > n)
                Console.WriteLine("Eroare");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    v[i] = rnd.Next(100);
              
                   Console.WriteLine($"{v[i]} ");
                }
              
                Console.WriteLine($"Stergerea elementului de pe pozitia {k}");
                for (int i = 0; i < n; i++)
                {
                    if (i == k)
                    {
                        v[i] = v[i + 1];
                        i++;
                    }
                    Console.WriteLine($"{v[i]} ");
                    
                }
            }
        }
    }
}