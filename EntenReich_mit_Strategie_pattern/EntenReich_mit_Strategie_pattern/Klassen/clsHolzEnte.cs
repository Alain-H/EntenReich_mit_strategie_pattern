using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    public class clsHolzEnte : absclsEnte
    {
        public clsHolzEnte() 
        {
            flugFähig = new clsFliegtGarNicht();
            quackFähig = new clsStummesQuacken();
        }
        public override void Aussehen()
        {
            Console.WriteLine("Ich bin aus holz, ein Mensch hat mich geformt, nicht die Natur.");
        }
    }
}
