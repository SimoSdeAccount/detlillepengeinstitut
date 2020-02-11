using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Indsæt
    {

        List<Kunde> kunder = new List<Kunde>();
        public Indsæt() { }
        public Indsæt(List<Kunde> inKunder)
        {
            kunder = inKunder;
        }
        public void IndsætBeløb()
        {
            bool UlovligtBeløbInput = true;
            int beløb = 0;
            string kontoTypeValg = string.Empty;
            Selector KundeKontoVælg = new Selector(kunder);
            int kundeValg = KundeKontoVælg.VælgKunde();
            bool ulovligKontoTypeValg = true;
            do
            {
                Console.WriteLine("Tast i for at indsætte i en indlånskonto og u for at indsætte en udlånskonto");
                kontoTypeValg = Console.ReadLine();
                if (kontoTypeValg == "i" || kontoTypeValg == "I" || kontoTypeValg == "u" || kontoTypeValg == "U")
                {
                    ulovligKontoTypeValg = false;
                }
            }
            while (ulovligKontoTypeValg);
            if (kontoTypeValg == "i")
            {
                int kontoValg = KundeKontoVælg.VælgIndlånKonto();
                Console.WriteLine("Du har valgt konto nr " + kontoValg.ToString() + "Indtast beløb du vil indsætte");
                do
                {
                    try
                    {
                        beløb = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dit input var ikke et tal");
                        continue;
                    }
                    if(beløb > 0)
                    {
                        UlovligtBeløbInput = false;
                    }
                }
                while (UlovligtBeløbInput);
                kunder[kundeValg - 1].GetSetIndlånKontoer[kontoValg - 1].IndsætBeløb(beløb);
                Console.WriteLine("Saldoen på kontoen er nu " + kunder[kundeValg - 1].GetSetIndlånKontoer[kontoValg - 1].GetSetSaldo);
            }
            else
            {
                int kontoValg = KundeKontoVælg.VælgUdlånKonto();
                Console.WriteLine("Du har valgt konto nr " + kontoValg.ToString() + "Indtast beløb du vil indsætte");
                do
                {
                    try
                    {
                        beløb = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Dit input var ikke et tal");
                        continue;
                    }
                    if (beløb > 0)
                    {
                        UlovligtBeløbInput = false;
                    }
                }
                while (UlovligtBeløbInput);
                kunder[kundeValg - 1].GetSetUdlånKontoer[kontoValg - 1].IndsætBeløb(beløb);
                Console.WriteLine("Saldoen på kontoen er nu " + kunder[kundeValg - 1].GetSetUdlånKontoer[kontoValg - 1].GetSetSaldo);
            }
            Console.WriteLine("Tast enter for at fortsætte");
            Console.ReadLine();
        }
    }
}
