using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Print
    {
        List<Kunde> kunder = new List<Kunde>();
        public Print() { }
        public Print(List<Kunde> inKunder)
        {
            kunder = inKunder;
        }
        public void PrintKunder()
        {
            for (int i = 0; i < kunder.Count; i++)
            {
                Console.WriteLine("Kundenavn: " + kunder[i].GetSetNavn);
                Console.WriteLine("Kontoer:");
                for (int j = 0; j < kunder[i].GetSetKontoer.Count; j++)
                {
                    Console.WriteLine("Konto nr " + kunder[i].GetSetKontoer[j].GetSetKontoNummer.ToString());
                }
            }
        }
        public void PrintKunde()
        {

        }
    }
}
