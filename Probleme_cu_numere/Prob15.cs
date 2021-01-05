using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob15
    {
        //Se dau 3 numere. Sa se afiseze in ordine crescatoare.

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b)
                interschimbare(ref a, ref b);
            if (a > c)
                interschimbare(ref a, ref c);
            if (b > c)
                interschimbare(ref b, ref c);
            Console.WriteLine($"{a} {b} {c}");

        }
        private static void interschimbare(ref int x, ref int y)
        {
            int aux = x;
            x = y;
            y = aux;
        }
    }
}
