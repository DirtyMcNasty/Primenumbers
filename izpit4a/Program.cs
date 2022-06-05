using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit4a
{
    /*IV. (15 točk)
    Napiši metodo, ki kot parameter dobi tabelo celih števil in vrne:
    •	1, če je v tabeli več pozitivnih elementov, kot negativnih;
    •	0, če je v tabeli enako število pozitivnih in negativnih elementov;
    •	-1, če je v tabeli več negativnih, kot pozitivnih elementov. 

    Pri tem upoštevaj, da 0 ni ne pozitiven, ne negativen element.

    Napiši še eno metodo, ki kot parameter dobi tabelo celih števil in jo napolni z naključnimi števili med -1000 in 1000. V glavnem programu 
    ustvari tabelo celih števil velikosti 20 in jo napolni z naključnimi števili z uporabo predhodne metode. V glavnem programu z uporabo prve 
    metode preveri in izpiši ali je v tabeli več pozitivnih ali negativnih elementov. Polnjenje tabele in preverjanje ponovi dokler ne dobiš tabelo, 
    ki ima več pozitivnih elementov. Naredi še pomožno metodo za izpis in jo pokliči po potrebi
    */
    internal class Program
    {
        public static void Izpis(int[] tabela)
        {
            for (int i = 0; i < tabela.Length; i++)
                Console.Write(" {0}", tabela[i]);
             Console.WriteLine();
        }
        public static void Napolni(int[] tabela)
        {
            Random r = new Random();
            for (int i = 0; i < tabela.Length; i++)
            {
                tabela[i] = r.Next(-1000, 1001);
            }
        }
        public static int VecPoz(int[] tabela)
        {
            int stPoz = 0;
            int stNeg = 0;
            for (int i = 0; i < tabela.Length; i++)
            {
                if (tabela[i]>0)
                    stPoz++;
                if (tabela[i]<0)
                    stNeg++;
            }
            if (stPoz > stNeg)
                return 1;
            if (stPoz == stNeg)
                return 0;
            else
                return -1;

        }
        static void Main(string[] args)
        {

            int[] t = new int[20];  //kreiranje tabele
            do
            {
                Napolni(t);  //klic metode, ki napolni tabelo z naključnimi vrednostmi
                Izpis(t);

                Console.WriteLine(VecPoz(t));
            } while (!(VecPoz(t) == 1));  //ponavlja polnjenje dokler ni več pozitivnih kot negativnih
        }
    }
}
