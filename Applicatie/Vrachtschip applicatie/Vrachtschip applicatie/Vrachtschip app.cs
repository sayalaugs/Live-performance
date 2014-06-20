using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Vrachtschip_applicatie
{
    //Deze applicatie is gemaakt voor de Live-perfomance door saya laugs.
    public partial class Form1 : Form
    {
        CSCcontrol ctrl;
        DatabaseConnection db;
        public List<Container> unplannedcontainers;
        public List<Container> waardevollecontainers;
        public List<Container> gewonecontainers;
        public List<Container> gekoeldecontainers;

        int waardevollecount;
        int gewonecount;
        int gekoeldecount;

        public Form1()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            ctrl = new CSCcontrol();

            //haalt alle schepen en bestemmingen en containers op uit de database
            ctrl.schepen = db.GetAllShips();
            ctrl.bestemmingen = db.GetAllDestinations();
            ctrl.containers = db.GetAllContainers();

            //een lijst voor alle containers die nog niet ingepland zijn
            unplannedcontainers = new List<Container>();
            waardevollecontainers = new List<Container>();
            gewonecontainers = new List<Container>();
            gekoeldecontainers = new List<Container>();

            waardevollecount = waardevollecontainers.Count;
            gewonecount = gewonecontainers.Count;
            gekoeldecount = gekoeldecontainers.Count;

            //vult de lijst met niet geplande containers
            foreach (Container c in ctrl.containers)
            {
                if (c.Ingepland == false)
                {
                    c.Ingepland = true;
                    db.UpdateContainerPlanned(c);
                    unplannedcontainers.Add(c);
                }
            }

            foreach (Container c in unplannedcontainers)
            {
                if (c.Type.ToString() == "Waardevol")
                {
                    waardevollecontainers.Add(c);
                }
            }

            foreach (Container c in unplannedcontainers)
            {
                if (c.Type.ToString() == "Normaal")
                {
                    gewonecontainers.Add(c);
                }
            }

            foreach (Container c in unplannedcontainers)
            {
                if (c.Type.ToString() == "Gekoeld")
                {
                    gekoeldecontainers.Add(c);
                }
            }

            //voegt de gevonden schepen en bestemmingen toe aan de combobox
            foreach (Vrachtschip v in ctrl.schepen)
            {
                cbShips.Items.Add(v.Type.ToString());
            }
            foreach (Bestemming b in ctrl.bestemmingen)
            {
                cbDestination.Items.Add(b.Naam.ToString());
            }
        }

        //genereerd een indeling voor een schip
        private void btnGenerateLayout_Click(object sender, EventArgs e)
        {
            string selectedshiptype = null;
            string selecteddestination = null;

            try
            {
                //gaat niet verder tenzij bestemming en schip zijn geselecteerd
                if (cbShips.SelectedItem.ToString() != null && cbDestination.SelectedItem.ToString() != null)
                {
                    //geselecteerde ship en bestemming uit de combobox
                    selectedshiptype = cbShips.SelectedItem.ToString();
                    selecteddestination = cbDestination.SelectedItem.ToString();


                    //haalt het geselecteerde schip op uit de database
                    Vrachtschip ship = db.GetShip(cbShips.SelectedItem.ToString());
                    //de grootte van het schip opgehaald
                    int rijen = ship.AantalRijen;
                    int containersperrij = ship.ContainersPerRij;
                    int schiphoogte = ship.MaxHoogte;

                    //3d array om container waardes in te plaatsen
                    Container[, ,] indeling = new Container[schiphoogte, rijen, containersperrij];

                    //array loop voor gekoelde
                    for (int hoogte = 0; hoogte <= schiphoogte - 1; hoogte++)
                    {
                        for (int breedte = 0; breedte <= rijen - 1; breedte++)
                        {
                            for (int diepte = 0; diepte <= 0; diepte++)
                            {
                                foreach (Container c in gekoeldecontainers)
                                {
                                    indeling[hoogte, breedte, diepte] = c;
                                }
                            }
                        }
                    }

                    //array loop voor waardevolle
                    for (int hoogte = 0; hoogte <= schiphoogte - 1; hoogte++)
                    {
                        for (int breedte = 1; breedte <= rijen - 2; breedte++)
                        {
                            for (int diepte = 1; diepte <= containersperrij - 2; diepte++)
                            {
                                foreach (Container c in waardevollecontainers)
                                {
                                    indeling[hoogte, breedte, diepte] = c;
                                }
                            }
                        }
                    }


                    //array loop voor gewone containers
                    for (int hoogte = 0; hoogte <= schiphoogte - 1; hoogte++)
                    {
                        for (int breedte = 0; breedte <= rijen - 1; breedte++)
                        {
                            for (int diepte = 0; diepte <= containersperrij - 1; diepte++)
                            {
                                foreach (Container c in gewonecontainers)
                                {
                                    indeling[hoogte, breedte, diepte] = c;
                                }
                            }
                        }
                    }


                    //vult listbox met indelingsgegevens

                    for (int hoogte = 0; hoogte <= schiphoogte - 1; hoogte++)
                    {
                        lbGeneratedLayout.Items.Add("Laag " + hoogte);

                        for (int breedte = 0; breedte <= rijen - 1; breedte++)
                        {
                            for (int diepte = 0; diepte <= containersperrij - 1; diepte++)
                            {
                                lbGeneratedLayout.Items.Add(indeling[hoogte, breedte, diepte].Type.ToString() + " ");
                            }
                        }
                    }      
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Er is geen schip en/of bestemming geselecteerd");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void btnExportInfo_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();

            f.ShowDialog();

            string textout = "";

            // assume the li is a string - will fail if not
            foreach (string li in lbGeneratedLayout.Items)
            {
                textout = textout + li + Environment.NewLine;
            }

            textout = "Opgeslagen indelingsgegevens: " + Environment.NewLine + textout;
            File.WriteAllText(f.FileName, textout);

            MessageBox.Show("De gegevens zijn opgeslagen");
        }
    }
}
