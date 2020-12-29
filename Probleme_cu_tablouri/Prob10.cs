using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob10
    {
        //Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. 
        //Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            int position = -1;
            Console.WriteLine("Introduceti elementele vectorului in ordine crescatoare:");
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr == k)
                    position = i;
            }
            Console.WriteLine($"Elementul {k} se gaseste pe pozitia {position}");
        }
    }
}
