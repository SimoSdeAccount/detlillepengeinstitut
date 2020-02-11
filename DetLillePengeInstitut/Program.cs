using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetLillePengeInstitut
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programKøre = true;
            List<Kunde> Kunder = new List<Kunde>();
            do
            {
                Menu Menu = new Menu();
                string[] lovligeMenuValg = { "1", "2", "3", "4", "5", "6", "7", "8" };
                string menuValg;
                bool ulovligtMenuValg = true;
                Menu.PrintMenu();
                do
                {
                    menuValg = Console.ReadLine();
                    for (int i = 0; i < lovligeMenuValg.Length; i++)
                    {
                        if (menuValg == lovligeMenuValg[i])
                        {
                            ulovligtMenuValg = false;
                        }
                    }
                }
                while (ulovligtMenuValg == true);
                switch (menuValg)
                {
                    case "1":
                        Opret Kunde = new Opret(Kunder);
                        Kunde.OpretKunde();
                        break;
                    case "2":
                        Opret OpretKonto = new Opret(Kunder);
                        OpretKonto.OpretKonto();
                        break;
                    case "3":
                        Print PrintKunder = new Print(Kunder);
                        PrintKunder.PrintKunde(); 
                        break;
                    case "4":
                        Print PrintKonto = new Print(Kunder);
                        PrintKonto.PrintKonto();
                        break;
                    case "5":
                        Print PrintKapital = new Print(Kunder);
                        PrintKapital.PrintSamletKapital();
                        break;
                    case "6":
                        Indsæt IndsætPenge = new Indsæt(Kunder);
                        IndsætPenge.IndsætBeløb();
                        break;
                    case "7":
                        Slet KundeSlet = new Slet(Kunder);
                        Kunder = KundeSlet.SletKunde();
                        break;
                    case "8":
                        Slet SletKonto = new Slet(Kunder);
                        SletKonto.SletKonto();
                        break;
                    case "9":
                        programKøre = false;
                        break;
                }
            }
            while (programKøre);
        }
    }
}
