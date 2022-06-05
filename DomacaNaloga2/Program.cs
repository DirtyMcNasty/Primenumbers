using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomacaNaloga2
{
    /*2.	naloga: Napiši program, ki v polje 10 celih števil po vrsti zapiše praštevila večja od 10000. Preverjanje praštevila realiziraj v 
     * funkciji. Napiši še funkcijo za izpis polja. */
    internal class Program
    {
        public static int Prastevila (int preveri)
        {            
            int counter = 0;

            for (int i = 1; i < preveri; i++)
            {
                if (preveri % i == 0)
                    counter++;               
            }
            if (counter == 0)
                return preveri;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int[] tabela = new int[10];
            int y = 0;
            int x = 5;
            do
            {                
                int stevilo = Prastevila(x);
                if (stevilo !=0)
                {
                    tabela[y] = stevilo;
                    y++;
                }
                x++;
            }while (y < 10);
            Console.WriteLine();
            for (int i = 0; i < tabela.Length; i++)
                Console.Write("{0} ", tabela[i]);
        }

    }
}
