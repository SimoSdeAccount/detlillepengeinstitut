using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Selector
    {
        List<Kunde> Kunder = new List<Kunde>();
        private int thisKundeValg = 0;
        public Selector(List<Kunde> inKunder)
        {
            Kunder = inKunder;
        }
        public int VælgKunde()
        { 
            int kundeValg = 0;
            bool ulovligtKundeValg = true;
            List<int> MuligeKundeValg = new List<int>();
            Console.WriteLine("Der er oprettet følgende kunder:");
            for (int i = 0; i < Kunder.Count; i++)
            {
                Console.WriteLine("Kunde: " + (i+1).ToString() + "Kundenummer: " + Kunder[i].GetSetKundeNummer + " Navn: " + Kunder[i].GetSetNavn + " Email: " + Kunder[i].GetSetEmail);
                MuligeKundeValg.Add(i+1);
            }
            Console.WriteLine("Indtast nummer på listen for at vælge kunde (ikke kundenummer)");
            do
            {
                try
                {
                    kundeValg = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dit input var ikke et tal");
                }
                for (int i = 0; i < MuligeKundeValg.Count; i++)
                {
                    if (kundeValg == MuligeKundeValg[i])
                    {
                        ulovligtKundeValg = false;
                    }
                }
            }
            while (ulovligtKundeValg);
            thisKundeValg = kundeValg;
            return kundeValg;
        }
        public int VælgKontoType(bool indlån)
        {
            List<int> MuligeKontoValg = new List<int>();
            bool ulovligtKontoValg = true;
            int kontoValg = 0;
            if(indlån)
            {
                Console.WriteLine("Indlåns kontoer for Kunde nummer: " + Kunder[thisKundeValg - 1].GetSetKundeNummer.ToString());
                Console.WriteLine("Indlåns kontoer: ");
                for (int i = 0; i < Kunder[thisKundeValg - 1].GetSetIndlånKontoer.Count; i++)
                {
                    Console.WriteLine("Konto: " + (i + 1).ToString() + " Kontonummer: " + Kunder[thisKundeValg - 1].GetSetIndlånKontoer[i].GetSetKontoNummer.ToString() + " Saldo: " + Kunder[thisKundeValg - 1].GetSetIndlånKontoer[i].GetSetSaldo.ToString());
                    MuligeKontoValg.Add(i + 1);
                }
            }
            else
            {
                Console.WriteLine("UdlånsKontoer for Kunde nummer: " + Kunder[thisKundeValg - 1].GetSetKundeNummer.ToString());
                Console.WriteLine("Udlåns kontoer: ");
                for (int i = 0; i < Kunder[thisKundeValg - 1].GetSetUdlånKontoer.Count; i++)
                {
                    Console.WriteLine("Konto: " + (i + 1).ToString() + " Kontonummer: " + Kunder[thisKundeValg - 1].GetSetUdlånKontoer[i].GetSetKontoNummer.ToString() + " Saldo: " + Kunder[thisKundeValg - 1].GetSetUdlånKontoer[i].GetSetSaldo.ToString());
                    MuligeKontoValg.Add(i + 1);
                }
            }
            do
            {
                Console.WriteLine("Indtast nummeret på kontoen (ikke kontonummeret)");
                try
                {
                    kontoValg = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Dit input var ikke et tal");
                }
                for (int i = 0; i < MuligeKontoValg.Count; i++)
                {
                    if(kontoValg == MuligeKontoValg[i])
                    {
                        ulovligtKontoValg = false;
                    }
                }
            }
            while (ulovligtKontoValg);
            return kontoValg;
        }
    }
}
