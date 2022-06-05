using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit2a
{
    /*Napiši metodo, ki kot argument dobi celo število, vrne pa število enk v številu. Npr. za število 1291 vrne 2, za število 290 vrne 0, 
     * za število 1151 vrne 3. V primeru, da je argument negativen, naj vrne -1.
Z uporabo metode v glavnem programu izpiši število enk za 20 naključnih števil med -10000 in 10000 v obliki:

Število  |  Število enk
  1203   |       1
  1214   |       2
  -109   |      -1
   239   |       0
*/
    internal class Program
    {
        public static int Prestej (int stevilo)
        {
            int counter = 0;
            if (stevilo < 0)
                return -1;
            else
            {
                do
                {
                    int temp;                    
                    temp = stevilo % 10;
                    if (temp == 1)
                    counter++;
                    stevilo = stevilo / 10;
                } while (stevilo > 0);      
                
            }return counter;
        }
        static void Main(string[] args)
        {
           /* Console.WriteLine("Vnesi celo število: ");
            int vnos = int.Parse(Console.ReadLine());
            int sestevek = Prestej(vnos);
            Console.WriteLine("V vnesenem številu je {0} števil 1", sestevek);*/
           Random r = new Random();
            Console.WriteLine("\tŠtevilo\t|Število enk");
            for (int i=1; i<=20; i++)
            {
                int st = r.Next(-10000, 10001);
                Console.WriteLine("\t{0}\t|\t{1}", st, Prestej(st));
            }
            
        }
    }
}
