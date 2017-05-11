using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening10._3En24._6
{
    class Program
    {
        private static string cmd;
        private static Bankrekening rekening = new Bankrekening();

        private static void ExecuteerMenu()
        {
           
        }

        private static void LaatRekeningZien()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Doe iets! Hierna ziet u uw tansactie.");
            Console.WriteLine("schrijf een + voor het bedrag als er bijkomt en een - als er weggaat!");
            Console.WriteLine("Schrijf STOP (in drukletters) als u klaar bent!");
            Console.WriteLine("Typ momenteel alleen gehelegetallen in!"); //tijdelijk

            while (cmd != "STOP")
            {
                //niet meer in methode ExecuteerMenu(): anders werkt de break niet meer
                string cmd = Console.ReadLine();

                if (cmd != "STOP")
                {
                    if (Convert.ToDouble(cmd) > 0.00) //Wrm lukt het niet met het intypen van decimalen?
                    {
                        Console.WriteLine("U stort een extra bedrag ...");
                        rekening.Storten(Convert.ToDouble(cmd));
                    }
                    else if (Convert.ToDouble(cmd) < 0.00)
                    {
                        Console.WriteLine("U betaalt iets ..."); //En Wat als u er het geld niet voor heeft?
                        rekening.Opnemen(Convert.ToDouble(cmd));
                    }
                    else
                    {
                        Console.WriteLine("overbodig");
                    }
                }
                else
                {
                    Console.WriteLine("salu en de kost!");
                    break;
                }
            }
            
        }
    }
}
