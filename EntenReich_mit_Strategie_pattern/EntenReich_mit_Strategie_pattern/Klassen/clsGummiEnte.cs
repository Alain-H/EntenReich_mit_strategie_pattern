using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    public class clsGummiEnte : absclsEnte
    {
        public clsGummiEnte() 
        {
            flugFähig = new clsFliegtGarNicht();
            quackFähig = new clsQuitschen();
        }
        public override void Aussehen()
        {
            Console.WriteLine("Ich bin eine Gummiente, meistens bin ich gelb, mit einem orangen Schnabel ich kann aber auch bunt sein wie ein Regenbogen!");
        }
    }
}
