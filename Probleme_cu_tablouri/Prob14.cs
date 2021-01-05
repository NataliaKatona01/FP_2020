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
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if(v[i] == 0 && i != n - 1)
                {
                    int j = i + 1;
                    while (v[j] == 0 && j != n - 1)
                        j++;

                    int aux = v[i];
                    v[i] = v[j];
                    v[j] = aux;

                }
               
            }
            for (int i = 0; i < n; i++)
                 Console.Write($"{v[i]} ");  
        }
    }
}
