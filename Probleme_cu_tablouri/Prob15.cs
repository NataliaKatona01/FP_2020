using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob15
    {
        //Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[100];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(100);

            }
        }
    }
}
