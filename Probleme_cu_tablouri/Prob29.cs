using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob29
    {
        //Mergesort. Sortati un vector folosind metoda MergeSort.
        static void Main(string[] args)
        {

            int[] v = { 45, 3, 77, 15, 4, 7, 11, 23, 35 };
            MyMergeSort(v);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
            Console.WriteLine();
        }
        private static void MyMergeSort(int[] v)
        {
            MyMergeSortHelper(v, 0, v.Length - 1);
        }
        private static void MyMergeSortHelper(int[] v, int start, int end)
        {
            int mid;
            if (start < end)
            {
                mid = (start + end) / 2;
                MyMergeSortHelper(v, start, mid);
                MyMergeSortHelper(v, mid + 1, end);
                MyMerge(v, start, mid, end);
            }
        }
        private static void MyMerge(int[] v, int start, int mid, int end)
        {
            int[] v1 = new int[mid - start + 1];
            int[] v2 = new int[end - mid];
            int i, j, k;
            for (i = start; i <= mid; i++)
            {
                v1[i - start] = v[i];
            }
            for (i = mid + 1; i <= end; i++)
            {
                v2[i - (mid + 1)] = v[i];
            }
            i = 0;
            j = 0;
            k = 0;

            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                    v[start + k++] = v1[i++];
                else
                    v[start + k++] = v2[j++];
            }
            while (i < v1.Length)
                v[start + k++] = v1[i++];
            while (j < v2.Length)
                v[start + k++] = v2[j++];
        }
        private static int[] Interclasare(int[] v1, int[] v2)
        {
            int i = 0, j = 0, k = 0;
            int[] v3 = new int[v1.Length + v2.Length];
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                    v3[k++] = v1[i++];
                else
                    v3[k++] = v2[j++];
            }
            while (i < v1.Length)
                v3[k++] = v1[i++];
            while (j < v2.Length)
                v3[k++] = v2[j++];
            return v3;
        }
    }
}
