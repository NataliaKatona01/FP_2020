using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob4
    {
        //Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numar a. 
        //Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea secventei:");
            int n = int.Parse(Console.ReadLine());
            
            int p = 0, pozitie = 0;
            
            Console.WriteLine("Introduceti valoarea pe care doriti sa o cautati:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (a == x)
                    p = pozitie;
                else
                    p = -1;
                pozitie++;
            }

            Console.WriteLine($"Pozitia pe care se afla {a} este {p}");
            
        }
    }
}
