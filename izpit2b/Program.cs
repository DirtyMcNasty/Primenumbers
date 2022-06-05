using System;

namespace Naloga02
{
    class Program
    {
        /*
        *Napiši metodo, ki kot argument dobi celo število, vrne pa najmanjšo števko v številu. Npr. za število
        *1291 vrne 1, za število 190 vrne 0, za število 9768 vrne 6. V primeru, da je argument negativen,
        *naj vrne -1.
        Z uporabo metode v glavnem programu izpiši najmanjšo števko za 20 naključnih števil med -10000 in 10000 v obliki:

        Število | Najmanjša števka
        1203 | 0
        1224 | 1
        -109 | -1
        739 | 3
        ...
        */
        public static int VrniMinStevko(int stevilo)
        {
            if (stevilo < 0) return -1;

            int najmanjsa = 9;
            while (stevilo > 0)
            {
                int stevka = stevilo % 10;
                if (stevka < najmanjsa)
                    najmanjsa = stevka;
                stevilo = stevilo / 10;
            }
            return najmanjsa;
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("\tŠtevilo\t|\tNajmanjša števka");
            for (int i = 1; i <= 20; i++)
            {
                int st = r.Next(-10000, 10001);
                Console.WriteLine("\t{0}\t|\t{1}", st, VrniMinStevko(st));
            }
        }
    }
}