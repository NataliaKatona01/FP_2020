using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob17
    {
        //Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.
        //Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul
        //maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are 
        //nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 

        static void Main(string[] args)
        {
            Console.WriteLine("n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int nr1 = int.Parse(Console.ReadLine());
            if (nr1 == 1)
                Console.WriteLine("Secventa incorecta");
            for (int i = 1; i < n - 1; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr == 0)
                    count++;
                if (nr == 1)
                    count--;
            }
            int nr2 = int.Parse(Console.ReadLine());
            if (nr2 == 0)
                Console.WriteLine("Secventa incorecta");
            if (nr2 == 1)
                count--;


            if (count == 0)
                Console.WriteLine("Secventa este corecta");
            else
                Console.WriteLine("Secventa este incorecta");
        }
    }
}
