using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening10._3En24._6
{
    class Program
    {
        private static void ExecuteerMenu()
        {
            
        }

        private static void LaatRekeningZien()
        {

        }

        static void Main(string[] args)
        {
            Bankrekening rekening = new Bankrekening();

            Console.WriteLine("Doe iets! Hierna ziet u uw tansactie.");
            Console.WriteLine("schrijf een + voor het bedrag als er bijkomt en een - als er weggaat!");
            Console.WriteLine("Schrijf STOP (in drukletters) als u klaar bent!");

            string cmd = Console.ReadLine();

            switch (cmd)
            {
                case "STOP":
                    break;
            }

            if (cmd != "STOP")
            {
                if (Convert.ToDouble(cmd) > 0)
                {
                    Console.WriteLine("U stort een extra bedrag ...");
                    rekening.Storten(Convert.ToDouble(cmd));
                }
                else if (Convert.ToDouble(cmd) < 0)
                {
                    Console.WriteLine("U betaalt iets ..."); //En Wat als u er het geld niet voor heeft?
                    rekening.Opnemen(Convert.ToDouble(cmd));
                }
            }
        }
    }
}
