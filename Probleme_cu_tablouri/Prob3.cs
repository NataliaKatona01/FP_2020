using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob3
    {
        //Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. 
        //Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            max()

            Random rnd = new Random(100);
            int[] v = new int[100];
            for (int i = 1; i <= n; i++)
            {
                v[i] = rnd.Next(100);
                Console.WriteLine($"{v[i]}");
            }
            //for (int i = 1; i <= n; i++)
            
                Max = Array.Max(v);
                Array.
            
            Console.WriteLine($"Max = {Max}");
        }

        private static void max()
        {
            
        }
    }
}
