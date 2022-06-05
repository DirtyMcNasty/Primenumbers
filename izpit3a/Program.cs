using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit3a
{
    /*Z uporabo vgnezdenih zank napišite metodo, ki za podan argument n izpiše naslednji kvadrat (primer za n=4):
        *.*.
        .*.*
        *.*.
        .*.*

Napišite program, ki prebere število n in pokliče predhodno metodo. Uporabnik naj vnos ponavlja dokler n ni v intervalu med 7 in 11 (meje so vključene).
*/
    internal class Program
    {
        public static void Izris (int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if ((i + j) % 2 != 0)
                        Console.Write("*");
                    else Console.Write(".");                    
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            int stevilo;
            do
            {
                Console.WriteLine("Vnesite izbrano število: ");
                stevilo = int.Parse(Console.ReadLine());
                Izris (stevilo);
            } while (stevilo <= 7 && stevilo <= 11);            
        }
    }
}
