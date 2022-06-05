using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naloga05
{
    internal class Program
    {
        /*5.	naloga: Napiši program, ki prebere tvoje ocene pri vseh predmetih in izračuna njihovo povprečje. Število ocen, 
         * ki jih boš vnesel naj bo spremenljivka (vendar naj ne preseže največjo dovoljeno velikost polja).*/
        static void Main(string[] args)
        {
            int[] ocene = new int[8];
            int vsota = 0;
            int steviloOcen = 0;
            for (int i = 0; i < ocene.Length; i++)
            {
                Console.Write("Vnesi oceno: ");
                int ocena = int.Parse(Console.ReadLine());
                if (ocena > 0)                      //če vnesemo vrednost manjšo od 0 zaključimo z zanko
                { 
                    ocene[i] = ocena;
                    vsota = vsota + ocene[i];
                    steviloOcen++;
                }
                else
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Povprečje {0} pridobljenih ocen je {1}", steviloOcen, (double)vsota/steviloOcen);
        }
    }
}
