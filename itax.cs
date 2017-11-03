using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelmanegementsystem
{
    class itax
    {
        public double mcTaxrate = 0.55;

        public double ifindtex(double icamount)
        {
            double findtax = icamount - (icamount * mcTaxrate);
            return findtax;
        }
     }
}
