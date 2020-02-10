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
                string Kør = Console.ReadLine();
                Menu Menu = new Menu();
                string[] lovligeMenuValg = { "1", "2", "3", "4", "5", "6", "7" };
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
                        Opret Kunde = new Opret();
                        Kunde.OpretKunde();
                        Kunder = Kunde.GetKunder;
                        break;
                    case "2":
                        Opret OpretKonto = new Opret(Kunder);
                        break;
                    case "3":
                        Print PrintKunder = new Print(Kunder);
                        PrintKunder.PrintKunder();
                        break;
                    case "4":
                        Print PrintKonto = new Print();
                        break;
                    case "5":
                        Slet SletKunde = new Slet();
                        break;
                    case "6":
                        Slet SletKonto = new Slet();
                        break;
                    case "7":
                        programKøre = false;
                        break;
                }
            }
            while (programKøre);
        }
    }
}
