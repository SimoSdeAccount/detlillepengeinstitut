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
                Kunde kunde = new Kunde();
                kunde.Opretkunde();
                kunder.Add(kunde);
                opretCounter++;
            }
            while (opretCounter < opretAntal);
        }
        public void OpretKonto()
        {

        }
    }
}
