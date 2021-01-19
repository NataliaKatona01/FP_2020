using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob16
    {
        //Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int b = 0; ;
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for (int i = 1; i < n - 1; i++)
            {
                if (i == 1)
                    b = cmmdc(v[i - 1], v[i]);
                else
                    b = cmmdc(v[i], b);
            }
            Console.WriteLine($"{b}");
        }

        private static int cmmdc(int a, int b)
        {
            while (a != b)
                if (a > b)
                    a -= b;
                else b -= a;
            return a;
        }
    }
}
