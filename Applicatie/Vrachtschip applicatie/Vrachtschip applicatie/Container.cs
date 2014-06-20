using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vrachtschip_applicatie
{

    public class Container
    {
        //attributen
        public int ID { get; set; }
        public int Gewicht { get; private set; }// het gewicht van de container in kg
        public Transport Transport { get; private set; } // dit bevat de transport gegevens waar de container op mee is geweest
        public ContainerType Type { get; private set; } // het soort container
        public Bedrijf Bedrijf { get; private set; } // het bedrijf waar de container van is
        public int GPScode { get; private set; }//wordt pas gebruikt in volgende versie
        public bool Ingepland = false;//een check om te kijken of de container al is ingepland op een schip ofniet

        //een enum om het type van een container aan te geven
        public enum ContainerType
        {
            Normaal,
            Waardevol,
            Gekoeld,
        }

        //de constructor
        public Container(int Gewicht, ContainerType Type, Bedrijf Bedrijf)
        {
            this.Gewicht = Gewicht;
            this.Type = Type;
            this.Bedrijf = Bedrijf;
        }

        public override string ToString()
        {
            if (Type == ContainerType.Gekoeld)
            {
                return "E ";
            }
            else if (Type == ContainerType.Waardevol)
            {
                return "V ";
            }
            else
            {
                return "C ";
            }
        }
    }
}
