using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    /*Napiši program, ki bo izpisal vsa števila med 1 in naključno generiranim številom iz intervala [2..42] in sicer na naslednji način: 
     * če je naključno število liho, potem naj izpiše števila od 1 do naključnega števila; če je naključno število sodo, naj izpiše števila 
     * od naključnega števila do 1. Primer izpisa: 
•	    če je naključno število 5, bo izpis:
        1 2 3 4 5
•	    če je naključno število 6, bo izpis:
        6 5 4 3 2 1 
        */
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(2,43);  //spodnja meja je vključena, zgornja pa je <, kar pomeni da daš +1 če želiš vključit še zgornjo mejo
            Console.WriteLine(x);

            if (x % 2 != 0)
            {
                for (int i = 1; i <= x; i++)
                    Console.Write("{0} ", i);
            }
            else
            {
                for (int i = x; i >= 1; i--)
                    Console.Write("{0} ", i);
            }

        }
    }
}
