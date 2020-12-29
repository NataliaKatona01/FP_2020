using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob8
    {
        //Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. 
        //Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[100];
            Random rnd = new Random();
            int x;
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(100);
                Console.Write($"{v[i]} ");
                
            }
            Console.WriteLine();
            x = v[0];
            for (int i = 1; i <= n; i++)
            {
                v[i - 1] = v[i];
                Console.Write($"{v[i]} ");
                v[n] = x;
            
            }

        }
    }
}
