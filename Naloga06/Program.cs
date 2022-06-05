using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga06
{
    internal class Program
    {
        /*6.	naloga: Napiši program, ki prebere v enodimenzionalno polje 10 celih števil, nato pa v metodi Max poišče največje izmed njih. 
         * Na koncu rezultat izpiše glavni program. */
        public static int Max(int[] p)
        {
            int najvecji = p[0];
            for (int i = 1; i < p.Length; i++)
            {
                if (p[i] > najvecji)
                    najvecji = p[i];
            }
            return najvecji;
        }
        static void Main(string[] args)
        {
            int[] polje = new int[10];
            Random r = new Random();

            for (int i = 0; i < polje.Length; i++)  //polnjenje z naključnimi vrednostmi
            {
                polje[i] = r.Next(1, 100);
            }
            for (int i = 0; i < polje.Length; i++)  //izpis polja
                Console.Write("{0} ", polje[i]);

            Console.WriteLine();
            Console.WriteLine("Največji element tabele je {0}", Max(polje));  //tabelo pošiljamo brez []
            Console.ReadLine();
        }
    }
}
