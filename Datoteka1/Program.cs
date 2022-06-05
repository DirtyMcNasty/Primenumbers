using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datoteka1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.CreateText("c:\\temp\\primer1.txt");
            //File.CreateText(@"c:\temp\primer1.txt");

            Console.Write("Vnesi pod in ime datoteke: ");
            string datoteka = Console.ReadLine();

            File.CreateText(datoteka);
        }
    }
}
