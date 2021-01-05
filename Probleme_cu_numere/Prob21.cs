using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob21
    {
        //Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

        static void Main(string[] args)
        {
            int x, nr;
            Random rnd = new Random(); 
            x = rnd.Next(1, 1024); 
            do
            {
                Console.Write("Numarul este mai mare sau egal decat: ");
               
                nr = int.Parse(Console.ReadLine());
                if (x >= nr) Console.WriteLine("Da");
                else
                if (x < nr) Console.WriteLine("Nu");
            }
            while (nr != x);
            Console.WriteLine($"Numarul este: {x} ");
        }
    }
}
