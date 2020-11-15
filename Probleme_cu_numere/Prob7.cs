using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob7
    {
        //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
        //Se cere sa se inverseze valorile lor. 
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Inversarea valorilor: ");
            int a1;
            a1 = a;
            a = b;
            b = a1;

            Console.WriteLine($"a = {a} {Environment.NewLine}b = {b}" );

        }
    }
}
