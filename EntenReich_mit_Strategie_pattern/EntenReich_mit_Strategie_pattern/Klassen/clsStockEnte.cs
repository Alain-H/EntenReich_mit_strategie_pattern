using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    internal class clsStockEnte : absclsEnte
    {
        public clsStockEnte()
        {
            flugFähig = new clsFliegtmitFlügel();
            quackFähig = new clsQuacken();
        }

        public override void Aussehen()
        {
            Console.WriteLine("Ich bin eine Stockente und habe wenn ich männlich bin eine grüne befederung, wennich weiblich bin" +
                "habe ich ein Gefieder wie ein Leopard!");
        }
    }
}
