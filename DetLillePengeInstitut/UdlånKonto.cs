﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class UdlånKonto : Konto
    {
        private static string lånType = "Udlån";
        private static double rentefod = 1.05;
        public string GetSetLånType
        {
            get { return lånType; }
            set { lånType = value; }
        }
        public void PrintKonto()
        {
            Console.WriteLine("Konto nr: " + GetSetKontoNummer.ToString());
            Console.WriteLine("Saldo: " + GetSetSaldo.ToString());
            Console.WriteLine("Rentefod: " + rentefod.ToString());
        }
    }
}
