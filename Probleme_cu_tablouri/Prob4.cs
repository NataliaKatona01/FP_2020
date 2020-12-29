using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob4
    {
        //Determinati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 


        static void Main(string[] args)
        {
            Console.Write("Lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            int min, max;
            int m = int.Parse(Console.ReadLine());
            min = m ; max = m;
            Random rnd = new Random(100);
            int[] v = new int[100];
            for (int i = 1; i < n; i++)
            {
                v[i] = rnd.Next(100);
                if (v[i] < min)
                    min = v[i];
                if (v[i] > max)
                    max = v[i];
                Console.Write($"{v[i]} ");

            }
            Console.WriteLine();
            Console.WriteLine($"Cea mai mica valoare din vector este {min}, iar cea mai mare este {max}");
        }
    }
}
