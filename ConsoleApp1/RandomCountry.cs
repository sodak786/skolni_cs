using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RandomCountry
    {
        public static void Main()
        {
            string obsah_textu = File.ReadAllText("cloud.txt");

            List<string> zeme = new(obsah_textu.Split('\n'));
            List<string>seznam_zemi = zeme.ToList();

            foreach(var jedna_zeme in seznam_zemi)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("---ZEMĚ---");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(jedna_zeme);
            }

            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("Chcete vygenerovat nahodnou zemi Y/N");
            string volba =Console.ReadLine();
            if (volba == "Y")
            {
                Random generator = new Random();
                /*
                int nahodna_pozice = generator.Next(0, seznam_zemi.Count);
                Console.WriteLine(seznam_zemi[nahodna_pozice]);
                */
                int cislo_min;
                int cislo_max;
                Console.WriteLine("Zadej spodní hranici: ");
                string cislo_prvni = Console.ReadLine();

                Console.WriteLine("Zadej horní hranici: ");
                string cislo_druhy = Console.ReadLine();

                cislo_min = Convert.ToInt32(cislo_prvni);
                cislo_max = Convert.ToInt32(cislo_druhy);

                int nahodna_pozice = generator.Next(cislo_min, cislo_max);
                Console.WriteLine(seznam_zemi[nahodna_pozice]);
            }
        }
    }
}
