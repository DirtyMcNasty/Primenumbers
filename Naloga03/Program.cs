using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga03
{
    internal class Program
    {
        /*3.	naloga: Napiši program, ki preko tipkovnice prebere velikost polja n. Nato preko tipkovnice beremo realna števila v polje 
         * tako dolgo, dokler ne zapolnimo polja. Izpiši najmanjši in največji element v polju, kot tudi njuna položaja (indeks) v polju.
         Izračunaj in izpiši seštevek vseh elementov in povprečje.*/

        static void Main(string[] args)
        {
            double[] tabela;
            Console.Write("Vnesi velikost tabele: ");
            int velikost = int.Parse(Console.ReadLine());
            tabela = new double[velikost];

            for (int i=0; i<tabela.Length; i++)   //vnos elementov v tabelo
            {
                Console.Write("Vnesi element tabele: ");
                tabela[i] = double.Parse(Console.ReadLine());
            }
            double najvecji, najmanjsi;            //iskanje najmanjšega in največjega elementa
            najvecji = najmanjsi = tabela[0];
            int najvecjiInd, najmanjsiInd;
            najvecjiInd = najmanjsiInd = 0;
            double vsota = 0.0;
            for (int i=0; i<tabela.Length; i++)
            {
                if (tabela[i] > najvecji)
                {
                    najvecji = tabela[i];
                    najvecjiInd = i;
                }
                if (tabela[i] < najmanjsi)
                {
                    najmanjsi = tabela[i];
                    najmanjsiInd = i;
                }
                vsota = vsota + tabela[i];
            }
            Console.WriteLine();
            Console.WriteLine("Največji element tabele je {0} na {1}", najvecji, najvecjiInd+1);
            Console.WriteLine("Najmanjši element tabele je {0} na {1}", najmanjsi, najmanjsiInd+1);

            Console.WriteLine("Seštevek vseh elementov je {0}", vsota);
            Console.WriteLine("Povprečje elementov je {0}", vsota/tabela.Length);
        }
    }
}
