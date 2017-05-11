using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening10._3En24._6
{
    class Bankrekening
    {
        //private int rentePercentage;
        private List<double> transacties = new List<double>();
        private double totaalbedrag = 0.00;

        public void Storten(double bedrag)
        {
            if (bedrag > 0)
            {
                transacties.Add(bedrag);
            }
            else
            {
                Console.WriteLine("error: Verkeerde methode?");
            }

            totaalbedrag += bedrag;
        }

        public void Opnemen(double bedrag)
        {
            if (bedrag < 0)
            {
                transacties.Add(bedrag);
            }
            else
            {
                Console.WriteLine("error: Verkeerde methode?");
            }

            totaalbedrag += bedrag; //"+=" en niet "-=", want als u bv. -(-1 ) doet, krijgt u weer en pos. get. en word het er bij opgeteld
        }

        public double HuidigSaldo
        {
            get { return totaalbedrag; }
        }
    }
}
