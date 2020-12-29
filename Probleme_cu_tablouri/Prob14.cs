using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob14
    {
        //Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. 
        //(nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[100];
            Random rnd = new Random();
            int x;
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(100);
                if (v[i] == 0)
                {
                    v[n] = v[i];
                    
                }
                Console.Write($"{v[i]} ");

            }
        }
    }
}
