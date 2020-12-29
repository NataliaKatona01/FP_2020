using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob5
    {
        //Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e 
        //in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            int[] v = new int[100];
            Random rnd = new Random();
            if (k > n)
                Console.WriteLine("Eroare");
            else
            {
                for (int i = 0; i < n; i++)
                {
                    v[i] = rnd.Next(100);
                    if (i == k)
                        v[i] = e;
                    Console.WriteLine($"{v[i]} ");


                }
                Console.WriteLine();
            }
        }
    }
}
