using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Slet
    {
        List<Kunde> Kunder = new List<Kunde>();
        public Slet(List<Kunde> inKunder)
        {
            Kunder = inKunder;
        }
        public List<Kunde> SletKunde()
        {
            Selector KundeVælg = new Selector(Kunder);
            int valgtKunde = KundeVælg.VælgKunde();
            Kunder.RemoveAt(valgtKunde-1);
            return Kunder;
        }
        public List<Kunde> SletKonto()
        {
            Selector KundeKontoVælg = new Selector(Kunder);
            int kundeValg = KundeKontoVælg.VælgKunde();
            string kontoTypeValg = string.Empty;
            bool ulovligKontoTypeValg = true;
            do
            {
                Console.WriteLine("Tast i for at slette en indlånskonto og u for at slette en udlånskonto");
                kontoTypeValg = Console.ReadLine();
                if(kontoTypeValg == "i" || kontoTypeValg == "I" || kontoTypeValg == "u" || kontoTypeValg == "U")
                {
                    ulovligKontoTypeValg = false;
                }
            }
            while (ulovligKontoTypeValg);
            if (kontoTypeValg == "i")
            {
                int kontoValg = KundeKontoVælg.VælgIndlånKonto();
                Kunder[kundeValg - 1].GetSetIndlånKontoer.RemoveAt(kontoValg - 1);
            }
            else
            {
                int kontoValg = KundeKontoVælg.VælgUdlånKonto();
                Kunder[kundeValg - 1].GetSetUdlånKontoer.RemoveAt(kontoValg - 1);
            }
            return Kunder;
        }
    }
}
