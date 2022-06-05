using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaje002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stevilo = 0;
            bool jePravilenVnos = true;
            Console.Write("Vnesi število: ");
            do
            {
                try
                {
                    Console.Write("Vnesi število: ");
                    stevilo = int.Parse(Console.ReadLine());
                    jePravilenVnos = true;
                }
                catch
                {
                    Console.WriteLine("Napačen vnos!");
                    jePravilenVnos = false;
                }
            } while (!jePravilenVnos);
                Console.WriteLine("{0} ", stevilo);
            
        }
    }
}
