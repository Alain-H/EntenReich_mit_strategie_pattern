using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    internal class clsFliegtmitFlügel : IFlugfähig
    {
        public void fliegen()
        {
            Console.WriteLine("ich kann mit Flügel Fliegen.");
        }

    }
}
