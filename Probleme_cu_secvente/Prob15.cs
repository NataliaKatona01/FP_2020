using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob15
    {
        //O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrescator. 
        //De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. 
        //Se da o secventa de n numere. Sa se determine daca este bitonica. 

        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool crescator = false;
            bool descrescator = false;

            int a = int.Parse(Console.ReadLine());
            
            for (int i = 2; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                int nr2 = int.Parse(Console.ReadLine());
                if (a < nr) 
                {
                    crescator = true;
                    a = nr;
                }
                if (nr > nr2)
                {
                    descrescator = true;
                    nr = nr2;
                }

                
            }
            if (crescator && descrescator) 
            Console.WriteLine("Secventa este bitonica");
            else
            Console.WriteLine("Secventa nu este bitonica");
        }
    }
}
