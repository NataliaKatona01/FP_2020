using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Program
    {
        static int[] v = new int[100];
        static int i;
        static int n;
        static int x;
        static int nr;
        static void Main(string[] args)
        {
            //
            Console.WriteLine("Introduceti lungimea vectorului:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Elementele tabloului sunt: ");
            for (int i = 1; i <= n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Introduceti valoarea cautata:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            for (int i = 1; i <= n; i++)
            {
                if (v[i] == x)
                    nr++;
            }
            Console.WriteLine($"{x} apare de {nr} ori in vector ");
        


        }
    }
}
