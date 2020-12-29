using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob16
    {
        //O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica 
        //prin rotiri succesive (rotire = primul element devine ultimul). 
        //Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool crescator = false;
            bool descrescator = false;
            bool bitonica = false;
            int a = int.Parse(Console.ReadLine());
            int b;

            for (int i = 2; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                int nr2 = int.Parse(Console.ReadLine());
                /*
                while (a < nr)
                    crescator = true;
                a = nr;

                if (a < nr && nr > nr2)
                    bitonica = true;
                */

                if (a < nr)
                {
                    crescator = true;
                    a = nr;
                }
                if (a > nr)
                {
                    b = nr;
                    if (b > nr2)
                        descrescator = true;
                    b = nr2;
                }


            }
            if (crescator && descrescator)
                Console.WriteLine("Secventa este bitonica");
            else
                Console.WriteLine("Secventa nu este bitonica");
        }
    }
}