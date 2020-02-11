using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Kunde
    {
        public Kunde()
        {
            KundeNummerIncrementer++;
        }
        private static int KundeNummerIncrementer;
        private int KundeNummer;
        private int cprNr;
        private string Navn;
        private string email;
        private string adresse;
        private int telefonnr;
        private List<IndlånKonto> IndlånKontoer = new List<IndlånKonto>();
        private List<UdlånKonto> UdlånKontoer = new List<UdlånKonto>();
        public int GetSetKundeNummer
        {
            get {return KundeNummer;}
            set {KundeNummer = value;}
        }
        public int GetSetCpr
        {
            get { return cprNr; }
            set { cprNr = value; }
        }
        public string GetSetNavn 
        {
            get{return Navn;}
            set{Navn = value;}    
        }
        public string GetSetEmail
        {
            get { return email; }
            set { email = value; }
        }
        public string GetSetAdresse
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public int GetSetTelefonNr
        {
            get { return telefonnr; }
            set { telefonnr = value; }
        }
        public List<IndlånKonto> GetSetIndlånKontoer
        {
            get { return IndlånKontoer; }
            set { IndlånKontoer = value; }
        }
        public List<UdlånKonto> GetSetUdlånKontoer
        {
            get { return UdlånKontoer; }
            set { UdlånKontoer = value; }
        }
        public void printKunde()
        {
            Console.WriteLine("CPR: " + GetSetCpr.ToString());
            Console.WriteLine("Navn: " + this.GetSetNavn.ToString());
            Console.WriteLine("Email: " + this.GetSetEmail.ToString());
            Console.WriteLine("Adresse: " + this.GetSetAdresse.ToString());
        }
        public void Opretkunde()
        {
            bool UlovligInput = true;
            GetSetKundeNummer = KundeNummerIncrementer;
            Console.WriteLine("Angiv cpr-nummer");
            do
            {
                try
                {
                    GetSetCpr = int.Parse(Console.ReadLine());
                    UlovligInput = false;
                }
                catch
                {
                    Console.WriteLine("Dit input var ikke et tal");
                }
            }
            while (UlovligInput);
            UlovligInput = true;
            Console.WriteLine("Angiv navn");
            GetSetNavn = Console.ReadLine();
            Console.WriteLine("Angiv email");
            GetSetEmail = Console.ReadLine();
            Console.WriteLine("Angiv adresse");
            GetSetAdresse = Console.ReadLine();
            Console.WriteLine("Angiv Telefonnr");
            do
            {
                try
                {
                    GetSetTelefonNr = int.Parse(Console.ReadLine());
                    UlovligInput = false;
                }
                catch
                {
                    Console.WriteLine("Dit input var ikke et tal");
                }
            }
            while (UlovligInput);
            IndlånKonto DefaultKonto = new IndlånKonto();
            DefaultKonto.OpretKonto();
            IndlånKontoer.Add(DefaultKonto);
        }
    }
}
