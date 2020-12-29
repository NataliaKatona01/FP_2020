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
            min = m; max = m;
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr < min)
                    min = nr;
                if (nr > max)
                    max = nr;
            }
            Console.WriteLine($"Cea mai mica valoare din vector este {min}, iar cea mai mare este {max}");
        }
    }
}
