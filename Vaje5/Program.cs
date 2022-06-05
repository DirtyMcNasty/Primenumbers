using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje5
{
    internal class Program
    {
        /* 1.	naloga: Napiši program, ki prebere 10 celih števil in jih izpiše v obratnem vrstnem redu. Uporabi polja!*/

        static void Main(string[] args)
        {
            int[] polje = new int[10];  //kreiranje tabele

            for (int i=0; i<polje.Length; i++)  //polje.Length je velikost polja
            {
                Console.Write("Vnesi število: ");
                polje[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i=0; i<polje.Length; i++)  //izpis vrednosti
            {
                Console.Write("{0} ", polje[i]);
            }
            Console.WriteLine();
            for (int i = polje.Length-1; i >= 0; i--)
            {
                Console.Write("{0} ", polje[i]);
            }
            Console.WriteLine();
            foreach (int el in polje)
            {
                Console.Write("{0} ", el);
            }
        }
    }
}
