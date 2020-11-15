using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob5
    {
        //Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
        static void Main(string[] args)
        {
            int nr = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int contor = 0, cifra;
            do
            {
                cifra = nr % 10;
                nr = nr / 10;
                contor++;
                
            } while (contor < k);
           
            Console.WriteLine($"A {k}-a cifra a numarului {nr} este {cifra}");
                
          
        }
    }
}
