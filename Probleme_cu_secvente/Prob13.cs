using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_secvente
{
    class Prob13
    {
        //O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi 
        //transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = 
        //toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).
        //Determinati daca o secventa de n numere este o secventa crescatoare rotita. 

        static void Main(string[] args)
        {
            //4 5 6 7 2 3 
            //5 6 7 2 3 4 
            //6 7 2 3 4 5
            //7 2 3 4 5 6
            //2 3 4 5 6 7

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool crescator = true;
            bool rotita = true;
            
            int a = int.Parse(Console.ReadLine());
            int min = a;
            for (int i = 1; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
               
                if (!crescator && (min < nr || a > nr))
                    rotita = false;
                if (a > nr)
                    crescator = false;
                a = nr;
            }
            if(crescator || rotita)
            Console.WriteLine($"Secventa este crescatoare rotita");
            else
                Console.WriteLine($"Secventa nu este crescatoare rotita");
        }
    }
}
