using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntenReich_mit_Strategie_pattern.Klassen
{
    public abstract class absclsEnte
    {
        public IFlugfähig flugFähig;
        public IQuackFähig quackFähig;

        public abstract void Aussehen();
        public virtual void Schwimmen()                                                    //Methoden die in der Abstrakten klasse implementiert werden immer mit virtual !!!!
        {
            Console.WriteLine("Uhhh ich kann schwimmen!");
        }
        public virtual void toFliegen()
        {
            flugFähig.fliegen();
        }
        public virtual void toQuacken()
        {
            quackFähig.Quacken();
        }
        public void SetFliegen(IFlugfähig ff)
        {
            flugFähig = ff;
        }
        public void SetQuacken(IQuackFähig qf)
        {
            quackFähig = qf;
        }
    }
}
