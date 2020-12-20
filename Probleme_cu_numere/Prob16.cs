using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Prob16
    {
        //Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            if(a < b)
            {
                if (b < c)
                {
                    if (c < d)
                    {
                        if (d < e)
                            Console.WriteLine($"{a}, {b}, {c}, {d}, {e}");
                        else
                            Console.WriteLine($"{a}, {b}, {c}, {e}, {d}");
                    }
                    else
                    {
                        if (c < e)
                            Console.WriteLine($"{a}, {b}, {d}, {c}, {e}");
                        else
                            Console.WriteLine($"{a}, {b}, {d}, {e}, {c}");
                    }
                }
                 else //a c b
                {
                    if (b < d)
                    {
                        if (d < e)
                            Console.WriteLine($"{a}, {c}, {b}, {d}, {e}");
                        else
                            Console.WriteLine($"{a}, {c}, {b}, {e}, {d}");
                    }
                    else //
                    {
                        if (c < e)
                            Console.WriteLine($"{a}, {b}, {d}, {c}, {e}");
                        else
                            Console.WriteLine($"{a}, {b}, {d}, {e}, {c}");
                    }
                }
                    

            }
            else
            {

            }
        }
    }
}
