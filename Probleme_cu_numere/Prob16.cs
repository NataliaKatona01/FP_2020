using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob16
    {
        //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if (a > b)
                interschimbare(ref a, ref b);
            if (a > c)
                interschimbare(ref a, ref c);
            if (a > d)
                interschimbare(ref a, ref d);
            if (a > e)
                interschimbare(ref a, ref e);
            if (b > c)
                interschimbare(ref b, ref c);
            if (b > d)
                interschimbare(ref b, ref d);
            if (b > e)
                interschimbare(ref b, ref e);
            if (c > d)
                interschimbare(ref c, ref d);
            if (c > e)
                interschimbare(ref c, ref e);
            if (d > e)
                interschimbare(ref d, ref e);
            Console.WriteLine($"{a} {b} {c} {d} {e} ");
        }

        private static void interschimbare(ref int x, ref int y)
        {
            int aux = x;
            x = y;
            y = aux;
        }
    }
}
