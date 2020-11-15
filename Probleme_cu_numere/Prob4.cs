using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob4
    {
        //Detreminati daca un an y este an bisect. 
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            if((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            Console.WriteLine($"Anul {y} este an bisect");
            else
                Console.WriteLine($"Anul {y} nu este an bisect");
        }
    }
}
