using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    internal class clsQuitschen : IQuackFähig
    {
        public void Quacken()
        {
            Console.WriteLine("Ich kann nicht Quacken dafür kann ich quitschen!");
        }
    }
}
