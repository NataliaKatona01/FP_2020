using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob13
    {
        //Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = InitArray(n, 0, 100);

            PrintArray(v);
            InsertionSort(v);
            PrintArray(v);
        }

        private static void InsertionSort(int[] v)
        {
            int aux;
            for (int i = 1; i < v.Length; i++)
            {
                for (int k = i; k > 0 && v[k] < v[k - 1]; k--)
                {
                    aux = v[k];
                    v[k] = v[k - 1];
                    v[k - 1] = aux;
                }
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
