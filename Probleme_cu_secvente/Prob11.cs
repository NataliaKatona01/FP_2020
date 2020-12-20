using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob11
    {
        //Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                suma += Oglindit(nr);
            }
            Console.WriteLine($"Suma inverselor = {suma}");
        }

        private static int Oglindit(int nr)
        {
            int ogl = 0;
            while (nr != 0)
            {
                ogl = ogl * 10 + nr % 10;
                nr /= 10;
            }
            return ogl;
        }
    }
}
