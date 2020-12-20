using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob1
    {
        //Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea vectorului:");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[100];
            int suma = 0;

            Console.WriteLine("Elementele tabloului sunt: ");
            for (int i = 1; i <= n; i++)
            {
               v[i] = int.Parse(Console.ReadLine());
                suma += v[i]; 
            }
            Console.WriteLine($"Suma = {suma}");


        }
    }
}
