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

        private void btnGenerateLayout_Click(object sender, EventArgs e)
        {
            string selectedshiptype = cbShips.SelectedText;
            string selecteddestination = cbDestination.SelectedText;

            if (selectedshiptype == "" || selecteddestination == "")
            {
                MessageBox.Show("Er is geen schip type of bestemming geselecteerd");
            }
            else
            {
                Vrachtschip ship = db.GetShip(cbShips.SelectedItem.ToString());
            }
        }

        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            string name = tbDestinationName.Text;
            string country = tbDestinationCountry.Text;

            Bestemming destination = new Bestemming(name, country);
            if (ctrl.Add(destination))
            {
                MessageBox.Show("De bestemming is toegevoegd!");
            }

        }

        private void btnAddShip_Click(object sender, EventArgs e)
        {
            string type = tbShipType.Text;
            int Hight = Convert.ToInt32(tbShipHight.Text);
            int rows = Convert.ToInt32(tbShipRows.Text);
            int containersperrow = Convert.ToInt32(tbShipContPerRow.Text);
            int amountofpower = Convert.ToInt32(tbShipAmountOfElectricty.Text);

            Vrachtschip ship = new Vrachtschip(type, Hight, rows, containersperrow, amountofpower);

            if (ctrl.Add(ship))
            {
                MessageBox.Show("Het vrachtschip is toegevoegd!");
            }
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            string name = tbCompanyName.Text;
            string contact = tbCompanyContactPerson.Text;
            int kvk = Convert.ToInt32(tbCompanyKvknr.Text);

            Bedrijf company = new Bedrijf(name, contact, kvk);

            if (ctrl.Add(company))
            {
                MessageBox.Show("Het bedrijf is toegevoegd!");
            }
        }
    }
}
