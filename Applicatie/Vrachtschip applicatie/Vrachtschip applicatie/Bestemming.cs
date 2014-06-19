using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vrachtschip_applicatie
{
    public class Bestemming
    {
        //attributes
        public string Naam { get; private set; }//naam van de haven
        public string Land { get; private set; }// naam van het land waar de haven ligt

        //constructor
        public Bestemming(string Naam, string Land)
        {
            this.Naam = Naam;
            this.Land = Land;
        }

    }
}
