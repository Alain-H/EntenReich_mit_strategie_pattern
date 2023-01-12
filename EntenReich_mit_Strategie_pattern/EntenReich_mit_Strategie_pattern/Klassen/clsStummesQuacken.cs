using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    internal class clsStummesQuacken : IQuackFähig
    {
        public void Quacken()
        {
            Console.WriteLine("Leider kann ich nicht Quacken oder Quitschen, denn ich bin Stumm!");
        }
    }
}
