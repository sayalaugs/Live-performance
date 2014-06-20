using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vrachtschip_applicatie
{
    public class CSCcontrol
    {
        //database klasse
        DatabaseConnection db = new DatabaseConnection();

        //atributes
        public List<Vrachtschip> schepen = new List<Vrachtschip>();
        public List<Bedrijf> bedrijven = new List<Bedrijf>();
        public List<Bestemming> bestemmingen = new List<Bestemming>();
        public List<Container> containers = new List<Container>();

        public CSCcontrol()
        {
        }

        //deze methode voegt een vrachtschip toe aan het systeem en de database
        public bool Add(Vrachtschip vrachtschip)
        {
            foreach (Vrachtschip v in schepen)
                if (v.Type == vrachtschip.Type)
                {
                    return false;
                }
                else
                {
                    schepen.Add(vrachtschip);
                    db.AddShip(vrachtschip);
                    return true;
                }
            schepen.Add(vrachtschip);
            db.AddShip(vrachtschip);

            return true;
        }

        //deze methode voegt een bedrijf toe aan het systeem en de database
        public bool Add(Bedrijf bedrijf)
        {
            bedrijven.Add(bedrijf);
            db.AddCompany(bedrijf);

            return true;
        }

        //deze methode voegt een bestemming toe aan het systeem en de database
        public bool Add(Bestemming bestemming)
        {
            foreach (Bestemming b in bestemmingen)
                if (b.Naam == bestemming.Naam)
                {
                    return false;
                }
                else
                {
                    bestemmingen.Add(bestemming);
                    db.AddDestination(bestemming);
                    return true;
                }
            bestemmingen.Add(bestemming);
            db.AddDestination(bestemming);

            return true;
        }

        public bool Add(Container container)
        {
            foreach (Container c in containers)
                if (c.ID == container.ID)
                {
                    return false;
                }
                else
                {
                    containers.Add(container);
                    db.AddContainer(container);
                    return true;
                }
            containers.Add(container);
            db.AddContainer(container);

            return true;
        }

        //deze methode returned een bedrijf, welke wordt gezocht op bedrijfsnaam
        public Bedrijf SearchCompany(string bedrijfsnaam)
        {
            foreach (Bedrijf b in bedrijven)
            {
                if (b.Naam == bedrijfsnaam)
                {
                    return b;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
