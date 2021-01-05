using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob8
    {
        //(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. 
        //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   

        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Inversarea valorilor: ");
            a = a + b; 
            b = a - b; 
            a = a - b;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
