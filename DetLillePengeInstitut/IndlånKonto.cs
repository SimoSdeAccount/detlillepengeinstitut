using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class IndlånKonto : Konto
    {
        private static string lånType = "Indlån";
        private static double rentefod = 1.02;
        
        public string GetSetLånType
        {
            get { return lånType; }
            set { lånType = value; }
        }
    }
}
