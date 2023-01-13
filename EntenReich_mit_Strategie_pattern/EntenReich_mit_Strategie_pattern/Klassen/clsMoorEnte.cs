using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    internal class clsMoorEnte : absclsEnte
    {
        public clsMoorEnte() 
        { 
            flugFähig = new clsFliegtmitFlügel();
            quackFähig = new clsQuacken();

        }
        public override void Aussehen()
        {
            Console.WriteLine("Ich bin braun und kann mich im Moor daher sehr gut verstecken");
        } 
        
    }
}
