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

        private int indexTeller = 0;
        private string[] transactielijst;

        public void Storten(double bedrag) //Wrm nier geen foutmelding bij geen static en te Program.cs wel?
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

        public void ToonTransactielijst(string transactie)
        {
            transactielijst[indexTeller] += transactie;

            foreach (var t in transactielijst)
            {
                Console.WriteLine(t);
            }
        }

        public double HuidigSaldo
        {
            get { return totaalbedrag; }
        }
    }
}