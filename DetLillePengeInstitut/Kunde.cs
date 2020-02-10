using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Kunde
    {
        private int KundeNummer;
        private int cprNr;
        private string Navn;
        private string email;
        private string adresse;
        private List<Konto> Kontoer = new List<Konto>();
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
        public List<Konto> GetSetKontoer
        {
            get { return Kontoer; }
            set { Kontoer = value; }
        }
        public void printKunde()
        {
            Console.WriteLine("CPR" + GetSetCpr.ToString());
            Console.WriteLine("Navn" + this.GetSetNavn.ToString());
            Console.WriteLine("Email" + this.GetSetNavn.ToString());
            Console.WriteLine("Adresse" + this.GetSetAdresse.ToString());

        }
        public void Opretkunde()
        {
            Console.WriteLine("Angiv cpr-nummer");
            GetSetCpr = int.Parse(Console.ReadLine());
            Console.WriteLine("Angiv navn");
            GetSetNavn = Console.ReadLine();
            Console.WriteLine("Angiv email");
            GetSetEmail = Console.ReadLine();
            Console.WriteLine("Angiv adresse");
            GetSetAdresse = Console.ReadLine();
            Konto DefaultKonto = new Konto();
            DefaultKonto.OpretKonto();
            Kontoer.Add(DefaultKonto);
        }
    }
}
