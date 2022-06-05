using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga08
{
    /*8.	naloga: Napiši program, ki bo v ustvaril polje 10 celih števil in ga napolnil z naključnimi lihimi števili med 1 in 1000. 
     * Nato izračunajte in izpišite na ekran vsoto in povprečno vrednost vseh elementov v polju. 
Poljnjenje polja, preverjanje ali je število liho, izračun vsote, izračun povprečja ter izpis polja realiziraje s funkcijami. 
*/
    internal class Program
    {
        public static double VrniPovprecje(int[] p)
        {
            int vsota = VrniVsoto(p);
            return (double)vsota / p.Length;
        }
        public static void Izpisi(int[] p)
        {
            Console.WriteLine();
            for (int i = 0; i < p.Length; i++)
            {
                Console.Write("{0} ", p[i]);
            }
            Console.WriteLine();
        }
        public static int VrniVsoto(int[] p)
        {
            int vsota = 0;
            for (int i=0; i<p.Length; i++)
            {
                vsota = vsota + p[i];
            }
            return vsota;
        }
        public static bool JeLiho(int stevilo)
        {
            bool vrni = false;
            if (stevilo % 2 != 0)
                vrni = true;
                return vrni;
        }
        public static void Polni(int[] p)
        {
            Random r = new Random();
            for (int i = 0; i < p.Length; i++)
            {
                int stevilo;
                do
                {
                   stevilo = r.Next(1, 1000);
                } while (!(JeLiho(stevilo)));
                p[i] = stevilo;                
            }
        }
        static void Main(string[] args)
        {
            int[] polje = new int[10];
            Polni(polje);
            Izpisi(polje);
            Console.WriteLine("Vsota elementov tabele je: {0}", VrniVsoto(polje));
            Console.WriteLine("Povprečje elementov tabele je {0}", VrniPovprecje(polje));
        }
    }
}
