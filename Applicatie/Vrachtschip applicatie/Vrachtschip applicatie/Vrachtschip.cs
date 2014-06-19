using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vrachtschip_applicatie
{
    public class Vrachtschip
    {
        //atributen, ID wordt toegevoegd na het ophalen van schip info uit de database
        public int ID { get; set; }
        public string Type { get; private set; }
        public int MaxHoogte { get; private set; }
        public int AantalRijen { get; private set; }
        public int ContainersPerRij { get; private set; }
        public int AantalStroom { get; private set; }

        //de constructer van de klasse
        public Vrachtschip(string Type, int MaxHoogte, int AantalRijen, int ContainersPerRij, int AantalStroom)
        {
            this.Type = Type;
            this.MaxHoogte = MaxHoogte;
            this.AantalRijen = AantalRijen;
            this.ContainersPerRij = ContainersPerRij;
            this.AantalStroom = AantalStroom;
        }
    }
}
