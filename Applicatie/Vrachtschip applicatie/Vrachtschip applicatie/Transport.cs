using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vrachtschip_applicatie
{
    public class Transport
    {
        //attributes
        public int ID { get; set; }
        public Vrachtschip Vrachtschip { get; private set; }//het schip wat de transport doet
        public Bestemming Bestemming { get; private set; }//bestemming waar de boot de containers heen brengt

        //de containers die de boot vervoert
        public List<Container> containers = new List<Container>();

        //constructor
        public Transport(Vrachtschip Vrachtschip, Bestemming Bestemming)
        {
            this.Bestemming = Bestemming;
            this.Vrachtschip = Vrachtschip;
        }
    }
}
