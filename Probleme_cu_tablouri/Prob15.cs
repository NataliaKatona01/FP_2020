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
            int[] v = new int[n];

            for (int i = 0; i < n; i++)
                 v[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if(v[i] == v[j])
                    { 
                        for (int k = j; k < n - 1; k++)
                            v[k] = v[k + 1];
                        n--;
                    }
            Array.Resize(ref v, n);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            } 
        }
    }
}
