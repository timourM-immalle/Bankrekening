using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankrekening10._3En24._6
{
    class Bankrekening
    {
        private int rentePercentage;
        public List<double> transacties = new List<double>();

        public void Storten(double bedrag)
        {
            transacties.Add(bedrag);
        }

        public void Opnemen(double bedrag)
        {
            transacties.Add(bedrag); //het bedag moet neg. zijn ...
        }

        public double HuidigSaldo
        {
            get; set;
        }
    }
}
