using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvidencePojistenych;

namespace EvidencePojistenych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hlava hlavicka = new Hlava();

            Console.WriteLine(hlavicka.VolejHlavu());

            List<Pojistenci> pojistenci = new List<Pojistenci>();
            pojistenci.AddRange(new List<Pojistenci>
            {
                new Pojistenci ("Adam" , "Novotný" , 42, 369852147),
                new Pojistenci ("Barbora", "Novotná" , 38, 159753147),
                new Pojistenci ("Cecil" , "Novotný" , 12, 606848789),
            });


            void VypisSeznam()
            {   
                int pocet = 0;
                foreach (Pojistenci pojistenci_vypis in pojistenci)
                {
                    pocet++;
                    
                }
                if (pocet == 0)
                    Console.WriteLine("Neexistují žádní pojištěnci. ");
                else
                    Console.WriteLine("Evidujeme tyto pojištěnce: ");
                Console.WriteLine();

                foreach (Pojistenci pojistenci_vypis in pojistenci)
                {
                    Console.WriteLine(pojistenci_vypis);
                }

            }


            void PridejDoSeznamu()
            {

                Console.WriteLine("Zadejte jméno: ");
                string jmeno;
                do
                {
                    jmeno = Console.ReadLine();
                    if (jmeno.Length < 3)
                        Console.WriteLine("Jméno musí obsahovat nejméně 3 znaky: ");
                }
                while (jmeno.Length < 3);


                Console.WriteLine("Zadejte příjmení: ");
                string prijmeni;
                do
                {
                    prijmeni = Console.ReadLine();
                    if (prijmeni.Length < 3)
                        Console.WriteLine("Příjmení musí obsahovat nejméně 3 znaky: ");
                }
                while (prijmeni.Length < 3);

                Console.WriteLine("Zadejte věk: ");
                int vek;
                while (!int.TryParse(Console.ReadLine(), out vek))
                    Console.WriteLine("Neplatný znak - jsou povoleny pouze čísla. ");


                Console.WriteLine("Zadejte telefonní číslo: ");
                int telefon;
                while (!int.TryParse(Console.ReadLine(), out telefon))
                    Console.WriteLine("Neplatný znak, zadejte prosím v číselném tvaru: ");

                pojistenci.Add(new Pojistenci(jmeno, prijmeni, vek, telefon));
            }


            void VyhledavaniPojisteneho()
            {
                Console.WriteLine("\nZadejte jméno pojištěnce: ");
                string JmenoHledaneho;
                do
                {
                    JmenoHledaneho = Console.ReadLine();
                    if (JmenoHledaneho.Length < 3)                                           // 
                        Console.WriteLine("Jméno musí obsahovat minimálně 3 znaky: ");       // Ošetření vstupu
                     
                }
                while (JmenoHledaneho.Length < 3);

                Console.WriteLine("Zadejte příjmení:");
                string PrijmeniHledaneho;
                do
                {
                    PrijmeniHledaneho = Console.ReadLine();
                    if (PrijmeniHledaneho.Length < 3)                                             // 
                        Console.WriteLine("Příjmení musí obsahovat minimálně 3 znaky: ");         // Ošetření vstupu
                }
                while (PrijmeniHledaneho.Length < 3);

                Console.WriteLine();
                foreach (Pojistenci HledaniPojistencu in pojistenci)
                {
                    if (HledaniPojistencu.jmeno == JmenoHledaneho && HledaniPojistencu.prijmeni == PrijmeniHledaneho)
                    {
                        Console.WriteLine(HledaniPojistencu);
                    }
                }
            }



            bool pokracovat = true;
            do
            {
                int volba;
                while (!int.TryParse(Console.ReadLine(), out volba))             //
                    Console.WriteLine("Neplatný znak, zadejte prosím znovu: ");  //Ošetření vstupu


                if (volba < 5 && volba > 0)
                {
                    switch (volba)
                    {
                        case 1:
                            PridejDoSeznamu();
                            Console.WriteLine("\nPojištěnec úspěšne přidán, vyberte další akci. ");
                            
                            break;
                        case 2:
                            VypisSeznam();
                            Console.WriteLine("\nVypsání proběhlo úspěšně, vyberte další akci. ");
                            
                            break;
                        case 3:
                            VyhledavaniPojisteneho();
                            Console.WriteLine("\nVyhledání proběhlo úspěšně, vyberte další akci. ");
                            
                            break;
                        case 4:
                            pokracovat = false;
                            Console.WriteLine("\nDěkujeme za použití tohoto programu. \n\nStiskni libovolné tlačítko... ");
                            Console.ReadKey();
                            break;
                    }
                }
                else
                    Console.WriteLine("Neplatná volba");

            }
            while (pokracovat == true);
        }
    }
}