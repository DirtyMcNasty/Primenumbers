using System;
using System.Text;
using System.IO;
namespace Primer7
{
    class Program
    {
        static void Main(string[] args)
        {
            // primer 7: branje iz datoteke iz primera 6 in izpis vsebine na standardni izhod
            string strVrstica;
            Console.Write("Vnesite ime datoteke (celotno pot): ");
            string strDatoteka = Console.ReadLine();
            if (File.Exists(strDatoteka))
            {
                StreamReader srDatoteka = File.OpenText(strDatoteka);
                for (int i = 1; i <10000; i++)
                {
                    strVrstica = srDatoteka.ReadLine();
                    Console.WriteLine(strVrstica);
                }
                srDatoteka.Close();
            }
        }
    }
}