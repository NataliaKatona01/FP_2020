using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_tablouri
{
    class Prob17
    {
        //Se da un numar n in baza 10 si un nr b. 1 < b < 17
        //Sa se converteasca si sa se afiseze numarul n in baza b.

        static void Main(string[] args)
        {
            Console.Write("Dati un numar in baza 10: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Dati baza in care vreti sa convertiti numarul: ");
            int b = int.Parse(Console.ReadLine());

            string number = conversie(n, b);
            Console.WriteLine($"{number}");
        }
        private static string conversie(int n, int b)
        {
            string nr = "";
            while (n != 0)
            {
                int r = n % b;
                if (r > 9)
                    nr = baza(r) + nr;
                else
                    nr = r + nr;
                n = n / b;
            }
            return nr;
        }
        static string baza(int r)
        {
            switch (r)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                default: return "";
            }
        }
    }
}
