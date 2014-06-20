using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vrachtschip_applicatie
{
    public class Bedrijf
    {
        //attributes, ID wordt toegevoegd na het ophalen van de informatie van een bedrijf uit de database
        public int ID { get; set; }
        public string Naam { get; private set; }//bedrijfsnaam
        public string Contactpersoon { get; private set; }//contactpersoon van het bedrijf
        public int KVKnr { get; private set; }//kvk nummer van het bedrijf


        //contructer van de klasse
        public Bedrijf(string Naam, string Contactpersoon, int KVKnr)
        {
            this.Naam = Naam;
            this.Contactpersoon = Contactpersoon;
            this.KVKnr = KVKnr;
        }
    }
}
