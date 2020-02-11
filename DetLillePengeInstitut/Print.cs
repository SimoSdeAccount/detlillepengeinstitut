using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Print
    {
        List<Kunde> Kunder = new List<Kunde>();
        public Print() { }
        public Print(List<Kunde> inKunder)
        {
            Kunder = inKunder;
        }
        public void PrintKunder()
        {
            for (int i = 0; i < Kunder.Count; i++)
            {
                Console.WriteLine("Kundenavn: " + Kunder[i].GetSetNavn);
                Console.WriteLine("Indlåns Kontoer:");
                for (int j = 0; j < Kunder[i].GetSetIndlånKontoer.Count; j++)
                {
                    Console.WriteLine((i + 1).ToString());
                    Console.WriteLine("Konto nr " + Kunder[i].GetSetIndlånKontoer[j].GetSetKontoNummer.ToString());
                }
                Console.WriteLine("Udlåns Kontoer:");
                for (int j = 0; j < Kunder[i].GetSetUdlånKontoer.Count; j++)
                {
                    Console.WriteLine((i + 1).ToString());
                    Console.WriteLine("Konto nr " + Kunder[i].GetSetUdlånKontoer[j].GetSetKontoNummer.ToString());
                }
            }
            Console.WriteLine("Tast enter for at fortsætte");
            Console.ReadLine();
        }
        public void PrintSamletKapital()
        {
            double summer = 0;
            Console.WriteLine("Institutets samlede kapital er: " + summer.ToString());
        }
        public void PrintKunde()
        {
            Printer(true);
        }
        public void PrintKonto()
        {
            Printer(false);
        }
        private void Printer(bool KundeEllerKonto)
        {
            Selector kundeVælg = new Selector(Kunder);
            int kundeValg = kundeVælg.VælgKunde();
            if(KundeEllerKonto == true)
            {
                Console.WriteLine("Printer kunde med kundenummer" + Kunder[kundeValg - 1].GetSetKundeNummer.ToString());
                Kunder[kundeValg - 1].printKunde();
            }
            else
            {
                Console.WriteLine("Printer kontoer for kunde med kundenummer" + Kunder[kundeValg - 1].GetSetKundeNummer.ToString());
                Console.WriteLine("Indlåns kontoer:");
                for (int i = 0; i < Kunder[kundeValg-1].GetSetIndlånKontoer.Count; i++)
                {
                    Console.WriteLine((i + 1).ToString());
                    Kunder[kundeValg - 1].GetSetIndlånKontoer[i].PrintKonto();
                }
                Console.WriteLine("Udlåns kontoer:");
                for (int i = 0; i < Kunder[kundeValg - 1].GetSetUdlånKontoer.Count; i++)
                {
                    Console.WriteLine((i + 1).ToString());
                    Kunder[kundeValg - 1].GetSetUdlånKontoer[i].PrintKonto();
                }
            }
            Console.WriteLine("Tast enter for at fortsætte");
            Console.ReadLine();
        }
    }
}
