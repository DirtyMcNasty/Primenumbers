using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izpit3b
{
    /*Z uporabo vgnezdenih zank napišite metodo, ki za podan argument n izpiše naslednji trikotnik (primer za n=4):
    1
    2 3
    4 5 6
    7 8 9 10
    Napišite program, ki prebere število n in pokliče predhodno metodo. Uporabnik naj vnos ponavlja dokler n ni v intervalu med 1 in 32 
    (meje so vključene).
    */
    internal class Program
    {
        public static void Trikotnik (int n)
        {
            int st = 1;
            for (int i =1; i <= n; i++)
            {
                for (int j=1; j<=i; j++)
                    Console.Write("{0} ", st++);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int st;
            do
            {
                Console.Write("Vnesi n (1-32): ");
                st = int.Parse(Console.ReadLine());
            } while (st < 1 || st > 32);
            Trikotnik(st);
        }
    }
}
