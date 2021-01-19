using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 3, 45, 698, 45, 4, 66, 78, 6 };
            var sorted = QuickSort(arr, 0, arr.Length);

            foreach (var item in sorted)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static int[] QuickSort(int []arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = partion(arr, start, end);
                QuickSort(arr, start, pivot);
                QuickSort(arr, pivot + 1, end);
            }
            return arr;
        }
        public static void swap(int []arr, int i, int j)
        {
            int aux = arr[i];
            arr[i] = arr[j];
            arr[j] = aux;
        }
        public static int partion(int []arr, int start, int end)
        {
            int pivot = arr[start];
            int swapIndex = start;
            for (int i = start + 1; i < end; i++)
            {
                if(arr[i] < pivot)
                {
                    swapIndex++;
                    swap(arr, i, swapIndex);
                }
            }
            swap(arr, start, swapIndex);
                return swapIndex;
        }
    }
}
