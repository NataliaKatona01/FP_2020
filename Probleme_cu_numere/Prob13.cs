using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob13
    {
        //Determianti cati ani bisecti sunt intre anii y1 si y2.

        static void Main(string[] args)
        {
            int y1 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            
            int contor = 0;
            for (int y = y1; y <= y2; y++)
            {
                if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
                contor++;
            }
            
            Console.WriteLine($"Sunt {contor} ani bisecti intre anii {y1} si {y2}.");

        }
    }
}
