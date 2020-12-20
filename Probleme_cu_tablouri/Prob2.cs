using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob2
    {
        //Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. 
        //Daca k nu apare in vector rezultatul va fi -1. 

        static void Main(string[] args)
        {
            int[] v = new int[100];
            Console.WriteLine("Introduceti lungimea vectorului: ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                
            }
            Console.Write("Introduceti valoarea pe care vreti sa o cautati: ");
            int k = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                if(v[i] == k)
                    Console.WriteLine($"{k} se afla pe pozitia {i}");
                else
                    Console.WriteLine("-1");
            }
            

        }
    }
}
