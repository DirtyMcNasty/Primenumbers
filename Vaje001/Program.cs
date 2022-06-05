using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje001
{
    /*Program ki izračuna in izpiše seštevek elementov tabele celih števil*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tabela = { 12, 23, 34, 45, 56 };
            int vsota = 0;
            try
            {
                for (int i = 0; i < tabela.Length; i++)
                    vsota = vsota + tabela[i];              
            }
            catch (Exception ex)
            {
                Console.WriteLine("Prišlo je do napake!");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            Console.WriteLine("Vsota elementov tabele je {0}", vsota);
        }
    }
}
