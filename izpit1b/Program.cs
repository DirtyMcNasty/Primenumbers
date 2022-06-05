using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit1b
{
    /* Napiši metodo, ki za vhodno pozitivno celo število n izpiše vse njegove faktorje (števila, s katerim je n deljiv). Npr. 
    •	za n = 30 je izpis naslednji: 1 2 3 5 6 10 15 30.
    •	za n = 31 je izpis: 1 31. 
    Na začetku naj metoda preveri ali je n pozitiven. Če ni, potem naj to izpiše in zaključi z izvajanjem metode.

    V glavnem programu pokliči zgornjo metodo za 10 naključno generiranih števil med 0 in 100000. 
    */
    internal class Program
    {
        public static void IzpisiFaktorje(int n)
        {
            if (n<0)
            {
                Console.WriteLine("Parameter ni pozitiven");
                return;
            }
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write("{0} ", i);
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                IzpisiFaktorje(r.Next(0, 100001));
                Console.WriteLine();
            }
        }
    }
}
