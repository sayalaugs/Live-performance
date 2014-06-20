using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vrachtschip_applicatie
{
    //Deze applicatie is gemaakt voor de Live-perfomance door saya laugs.
    public partial class Form1 : Form
    {
        CSCcontrol ctrl;
        DatabaseConnection db;

        public Form1()
        {
            InitializeComponent();
            db = new DatabaseConnection();
            ctrl = new CSCcontrol();
            
            //haalt alle schepen en bestemmingen op uit de database
            ctrl.schepen = db.GetAllShips();
            ctrl.bestemmingen = db.GetAllDestinations();
            
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
            //het geselecteerde schip en bestemming
            string selectedshiptype = cbShips.SelectedText;
            string selecteddestination = cbDestination.SelectedText;

            //checked of bestemming en schip geselecteerd zijn
            if (selectedshiptype == "" || selecteddestination == "")
            {
                MessageBox.Show("Er is geen schip type of bestemming geselecteerd");
            }
            else
            {
                //haalt het geselecteerde schip op uit de database
                Vrachtschip ship = db.GetShip(cbShips.SelectedItem.ToString());
                //de grootte van het schip opgehaald
                int rijen = ship.AantalRijen;
                int containersperrij = ship.ContainersPerRij;
                int hoogte = ship.MaxHoogte;
                
                // array met hoogte, aantal rijen, lengte rijen van een schip
                //int[, ,] array = new int[rijen, containersperrij, hoogte];
                

            }
        }
    }
}
