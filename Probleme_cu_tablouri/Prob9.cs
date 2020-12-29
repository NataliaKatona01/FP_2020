using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob9
    {
        //Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            InitArray(v, 0, 100);

            PrintArray(v, "Before:");
            RotateLeft(v, k);
            PrintArray(v, "After:");

        }


        private static void RotateLeft(int[] v, int k)
        {
            for (int i = 0; i < k; i++)
            {
                RotateLeft(v);
            }
        }

        private static void PrintArray(int[] v, string message)
        {
            Console.WriteLine(message);
            foreach (var item in v)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        private static void InitArray(int[] v, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < v.Length; i++)
            {
                v[i] = rnd.Next(min, max);
            }
        }

     
        private static void RotateLeft(int[] v)
        {
            int aux;
            aux = v[0];

            for (int i = 1; i < v.Length; i++)
            {
                v[i - 1] = v[i];
            }
            v[v.Length - 1] = aux;
        }
    }
           
        
    }
