using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob7
    {
        //Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. 
        //Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(100);
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{v[i]} ");
            }
        }
    }
}
