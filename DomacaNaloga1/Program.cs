using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomacaNaloga1
{
    /*Tabele t1 , t2 in t3 so enako velike enorazsežne tabele znakov. Predpostavite, da so v tabelah t1 in t2 znaki urejeni po velikosti. 
     * Napišite metodo, ki bo prepisala vsebino tabel t1 in t2 v tabelo t3 tako, da bodo znaki v t3 urejeni po velikosti. (pazite na dolžine 
     * tabel. V zadnjo lahko zapišete zgolj omejeno št. elementov).*/
    internal class Program
    {
        public static void Uredi(int[] tabela)
        {
            int stevec = 0;
            do
            {
                for (int i = 0; i < tabela.Length - 1; i++)
                {
                    
                    if (tabela[i] > tabela[i + 1])
                    {
                        int temp;
                        temp = tabela[i];
                        tabela[i] = tabela[i + 1];
                        tabela[i + 1] = temp;
                    }                   
                }
                stevec++;

            } while (stevec < tabela.Length);
            Console.WriteLine();
            for (int i = 0; i < tabela.Length; i++)
                Console.Write("{0} ", tabela[i]);
        }
        public static int[] Prepis(int[] t1, int[] t2)
        {
            int x = t1.Length + t2.Length;
            int[] t3 = new int[x];            

            for (int i= 0; i < t1.Length; i++)
            {
                t3[i]=t1[i];
            }
            for (int i = 0; i < t1.Length; i++)
            {
                t3[i+t1.Length]=t2[i];
            }
            for (int i = 0; i < t3.Length; i++)
                Console.Write("{0} ", t3[i]);
            return t3;
        }
        static void Main(string[] args)
        {

            int[] t2 = {1,3, 5, 7};
            int[] t1 = {0, 2, 4, 6};            
            int[] t3;
            for (int i = 0; i < t1.Length; i++)
                Console.Write("{0} ", t1[i]);
            Console.WriteLine();
            for (int i = 0; i < t2.Length; i++)
                Console.Write("{0} ", t2[i]);
            Console.WriteLine();
            int[]t4=Prepis(t1, t2);
            Uredi(t4);



        }
    }
}
