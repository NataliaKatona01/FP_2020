using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob25
    {
        //(Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat 
        //crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
        static void Main(string[] args)
        {
            int[] v1 = { 2, 5, 7, 8 };
            int[] v2 = { 1, 3, 4, 6, 10 };
            int[] v = Interclasare(v1, v2);
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }

        }
        private static int[] Interclasare(int[] v1, int[] v2)
        {
            int[] v = new int[v1.Length + v2.Length];
            int i = 0, j = 0, k = 0;
            while (i < v1.Length && j < v2.Length)
            {

                if (v1[i] < v2[j])
                    v[k++] = v1[i++];
                else
                    v[k++] = v2[j++];
            }
            while (i < v1.Length)
                v[k++] = v1[i++];
            while (j < v2.Length)
                v[k++] = v2[j++];
            return v;
        }
    }
}
