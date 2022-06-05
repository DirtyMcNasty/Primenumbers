using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit4b
{
    /*Napiši metodo, ki kot parametre dobi dve tabeli celih števil in celo število n. Metoda naj vrne novo tabelo, ki jo dobi tako, da prvi 
     * tabeli doda vsebino iz druge tabele na poziciji n. Metoda naj to naredi samo v primeru, če je pozicija n veljavna (znotraj prve tabele). 
     * Če to ni možno, naj metoda vrne prazno tabelo.

    Npr.:
    vriniTabelo([1, 1, 1, 2, 1], [1, 2], 0)  -> [1, 2, 1, 1, 1, 2, 1]
    vriniTabelo([1, 1, 1, 2, 1], [1, 2], 2)  -> [1, 1, 1, 2, 1, 2, 1]

    Pokliči metodo iz glavnega programa in preveri njeno delovanje. Po potrebi ustvari dodatne (pomožne) metode.
    */
    internal class Program
    {
        public static void Izpis(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
                Console.Write("{0} ", t[i]);
            Console.WriteLine();
        }
        public static int[] vriniTabelo(int[] t1, int[] t2, int poz)
        {
            if (poz > t1.Length)
                return new int[0];

            int[] t3 = new int[t1.Length+t2.Length]; //velikost nove tabele
            int st = 0;
            for (int i=0; i<poz; i++)  // prepis prvega dela prve tabele (manjše od poz)
            {
                t3[i] = t1[i];
            }
            for (int i=0; i<t2.Length; i++)  //prepis druge tabele (vrivanje)
            {
                t3[st++] = t2[i];
            }
            for(int i = poz; i < t1.Length; i++)  //prepis preostalega dela prve tabele
                t3[st++] = t1[i];
            return t3;
        }
        static void Main(string[] args)
        {
            int[] t1 = {1, 1, 1, 2, 1 };
            int[] t2 = { 1, 2 };

            int[] t3 = vriniTabelo(t1, t2, 0);
            Izpis(t3);
        }
    }
}
