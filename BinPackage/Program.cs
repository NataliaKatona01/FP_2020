using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] weight = { 2, 5, 4, 7, 1, 3, 8 };
            int c = 10;
            //Sortare(weight);

            Array.Sort(weight);

            Console.WriteLine($"Next fit. Numar de containere: {NextFit(weight, c)}");
            Console.WriteLine($"Best fit. Numar de containere: {BestFit(weight, c)}");
        }
        static void Sortare(int[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                for (int j = i + 1; j < v.Length; j++)
                {
                    if (v[i] > v[j])
                        (v[i], v[j]) = (v[j], v[i]);
                }
            }
        }
        static int NextFit(int[] weight, int cMax)
        {
            int bins = 1;
            int curentCapacity = 0;
            for (int i = 0; i < weight.Length; i++)
            {
                if (weight[i] + curentCapacity < cMax)
                    curentCapacity += weight[i];
                else
                {
                    bins++;
                    curentCapacity = weight[i];
                }
            }
            return bins;
        }
        static int BestFit(int[] weight, int cMax)
        {
            int[] bins = new int[weight.Length];
            int k = 1;
            for (int i = 0; i < weight.Length; i++)
            {
                int bin = -1;
                int min = cMax;
                for (int j = 0; j < k; j++)
                {
                    if (weight[i] + bins[j] < cMax)
                    {
                        int remain = cMax - (weight[i] + bins[j]);
                        if (remain < min)
                        {
                            min = remain;
                            bin = j;
                        }
                    }
                }
                if (bin == -1)
                    bins[k++] = weight[i];
                else
                    bins[bin] += weight[i];
            }
            return k;
        }
    }
}
