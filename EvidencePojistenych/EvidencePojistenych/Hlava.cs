using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych
{
    internal class Hlava
    {
        string hlava =
            "-----------------------------------\n" +
            "        Evidence Pojištěných       \n" +
            "-----------------------------------\n" +
            "\n" +
            "Vyberte požadovanou akci :\n" +
            "1 - Přidat nového pojištěnce\n" +
            "2 - Vypsat všechny pojištěnce\n" +
            "3 - Vyhledat pojištěnce\n" +
            "4 - Ukončit program\n";

        public string VolejHlavu() { return hlava; }
    }
}
