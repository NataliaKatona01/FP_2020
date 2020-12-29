using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob12
    {
        //Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = InitArray(n, 0, 100);

            PrintArray(v);
            SelectionSort(v);
            PrintArray(v);
        }

        private static void SelectionSort(int[] v)
        {
            int aux;
            for (int i = 0; i < v.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[j] < v[k])
                    {
                        k = j;
                    }
                }

                aux = v[k];
                v[k] = v[i];
                v[i] = aux;
            }
        }
            
        
        private static void PrintArray(int[] v)
        {
            foreach (int item in v)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static int[] InitArray(int length, int min, int max)
        {
            int[] v = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);
            }
            return v;
        }
    }
}
