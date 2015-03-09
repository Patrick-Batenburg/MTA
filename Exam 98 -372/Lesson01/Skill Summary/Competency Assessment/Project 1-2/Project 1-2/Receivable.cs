using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyA.Acounting
{
    class Receivable : Records
    {
        public Receivable()
        {
            
            Records[] n;
            n = new Records[5];

            n[0] = new Records();
            n[0].name = "Henk";

            n[1] = new Records();
            n[1].name = "Piet";

            n[2] = new Records();
            n[2].name = "Fer";

            n[3] = new Records();
            n[3].name = "Kelvin";

            n[4] = new Records();
            n[4].name = "Dennis";

            n[5] = new Records();
            n[5].name = "Kees";
        }
    }
}
