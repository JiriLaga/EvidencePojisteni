using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojisteni
{
    class Evidence
    {
        private Seznam seznam;

        public Evidence()
        {
            seznam = new Seznam();
        }


        public void PridejZaznam()
        {
            Console.WriteLine("Zadej jméno:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine().ToLower().Trim()))
            {
                Console.WriteLine("Zadej jméno znovu:");
            }
            

            Console.WriteLine("Zadej příjmení:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine().ToLower().Trim()))
            {
                Console.WriteLine("Zadej příjmení znovu:");
            }


            Console.WriteLine("Zadej telefon:");
            int telefon;
            while (!int.TryParse(Console.ReadLine(), out telefon))
                Console.WriteLine("Neplatné číslo, zadej prosím znovu:");



            Console.WriteLine("Zadej věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
                Console.WriteLine("Neplatné číslo, zadej prosím znovu:");
            if ((vek >= 0) && (vek < 100))
            {
                seznam.PridejZaznam(jmeno, prijmeni, vek, telefon);
                Console.WriteLine("Záznam uložen...");
            }
            else
                Console.WriteLine("Chybně zadaný věk. Zadej rozpětí 0 - 99 let. Záznam neuložen...");

        }


        public void VypisVsech()
        {
            List<Zaznam> zaznamy = seznam.Vypis();
            foreach (Zaznam z in zaznamy)
                Console.WriteLine(z);
        }


        public void NajdiOsobu()
        {
            Console.WriteLine("Zadej jméno:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine().ToLower().Trim()))
            {
                Console.WriteLine("Zadej jméno znovu:");
            }


            Console.WriteLine("Zadej příjmení:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine().ToLower().Trim()))
            {
                Console.WriteLine("Zadej příjmení znovu:");
            }


            List<Zaznam> zaznamy = seznam.NajdiOsobu(jmeno, prijmeni,false);
            if (zaznamy.Count() > 0)
            {
                Console.WriteLine("Nalezeno: ");
                foreach (Zaznam z in zaznamy)
                    Console.WriteLine(z);
            }
            else
                Console.WriteLine("Nebyly nalezeny žádné osoby.");
        }


        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("--------------------");
            Console.WriteLine();
        }
    }
}
