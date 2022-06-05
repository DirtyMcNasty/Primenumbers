using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datoteka2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vnesi ime datoteke: ");
            string strDatoteka = Console.ReadLine();
            if (!File.Exists(strDatoteka))
            {
                StreamWriter swDatoteka = File.CreateText(strDatoteka);
                for (int i = 1; i<10000; i++)
                swDatoteka.WriteLine("Prvi zapis v tekstovno datoteko!");
                swDatoteka.Close();                
            }
            else
                Console.WriteLine("Datoteka {0} že obstaja!", strDatoteka);
        }
    }
}
