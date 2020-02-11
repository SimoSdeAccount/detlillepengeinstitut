using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Konto
    {
        public Konto()
        {
            KontoNummerIncrementer++;
        }
        private int kontoNummer;
        private double saldo;
        private static double rentefod = 1.02;
        private static int KontoNummerIncrementer;
        public int GetSetKontoNummer
        {
            get { return kontoNummer; }
            set { kontoNummer = value; }
        }
        public double GetSetSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public void OpretKonto()
        {
            GetSetKontoNummer = KontoNummerIncrementer;
            GetSetSaldo = 0;
        }
        public void PrintKonto()
        {
            Console.WriteLine("Konto nr: " + GetSetKontoNummer.ToString());
            Console.WriteLine("Saldo: " + GetSetSaldo.ToString());
            Console.WriteLine("Rentefod: " + rentefod.ToString());
        }
        public void IndsætBeløb(int Beløb)
        {
            GetSetSaldo += Beløb;
        }
    }
}
