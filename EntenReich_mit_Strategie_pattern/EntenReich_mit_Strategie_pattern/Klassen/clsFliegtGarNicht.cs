using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    internal class clsFliegtGarNicht : IFlugfähig
    {
        public void fliegen()
        {
            Console.WriteLine("Ich habe keine Flügel ich kann nicht fliegen!");
        }

    }
}
