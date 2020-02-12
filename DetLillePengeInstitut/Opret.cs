using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Opret
    {
        private List<Kunde> kunder = new List<Kunde>();
        public Opret(){}
        public Opret(List<Kunde> inKunder)
        {
            kunder = inKunder;
        }
        public List<Kunde> GetKunder
        {
            get { return kunder; }
        }
        public void OpretKunde()
        {
            Console.WriteLine("Indtast hvor mange kunder du vil oprette");
            int opretAntal = int.Parse(Console.ReadLine());
            int opretCounter = 0;
            do
            {
                Console.WriteLine("Du er nu igang med at oprette kunde " + (opretCounter + 1).ToString() + " ud af " + opretAntal.ToString()); 
                Kunde kunde = new Kunde();
                kunde.Opretkunde();
                kunder.Add(kunde);
                opretCounter++;
            }
            while (opretCounter < opretAntal);
            Console.WriteLine("Tast enter for at fortsætte");
            Console.ReadLine();
        }
        public void OpretKonto()
        {
            Selector KundeVælg = new Selector(kunder);
            int kundeValg = KundeVælg.VælgKunde();
            int antalKontoer = 0;
            int kontoCounter = 0;
            string lånType = string.Empty;
            bool ulovligLånType = true;
            Console.WriteLine("Indtast antal kontoer du vil oprette");
            antalKontoer = int.Parse(Console.ReadLine()); 
            do
            {
                Console.WriteLine("Hvilken kontotype vil du oprette? Tast i for indlån og u for udlån");
                do
                {
                    lånType = Console.ReadLine();
                    if(lånType == "i" || lånType == "I" || lånType == "u" || lånType == "U")
                    {
                        ulovligLånType = false;
                    }
                }
                while (ulovligLånType);
                if(lånType == "i" || lånType == "I")
                {
                    IndlånKonto nyKonto = new IndlånKonto();
                    nyKonto.OpretKonto();
                    kunder[kundeValg - 1].GetSetIndlånKontoer.Add(nyKonto);
                }
                else
                {
                    UdlånKonto nyKonto = new UdlånKonto();
                    nyKonto.OpretKonto();
                    kunder[kundeValg - 1].GetSetUdlånKontoer.Add(nyKonto);
                }
                kontoCounter++;
            }
            while (kontoCounter < antalKontoer);
            Console.WriteLine("Kontoer er oprettet, tast enter for at fortsætte");
            Console.ReadLine();
        }
    }
}
