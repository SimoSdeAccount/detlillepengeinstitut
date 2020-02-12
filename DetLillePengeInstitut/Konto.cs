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
        public void IndsætBeløb(int Beløb)
        {
            GetSetSaldo += Beløb;
        }
    }
}
