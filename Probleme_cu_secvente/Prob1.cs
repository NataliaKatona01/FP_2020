using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob1
    {
        //Se da o secventa de n numere. Sa se determine cate din ele sunt pare.

        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

           
            Console.WriteLine("Introduceti elementele secventei: ");
            int a, contor = 0;
            while (n != 0)
            {
                a = int.Parse(Console.ReadLine());
                n--;
                if (a % 2 == 0)
                    contor++;
            }
            Console.WriteLine($"{contor} numere sunt pare");
           

        }
    }
}
