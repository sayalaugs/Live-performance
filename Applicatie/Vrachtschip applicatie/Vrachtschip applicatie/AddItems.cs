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
    public partial class AddItems : Form
    {
        DatabaseConnection db;
        CSCcontrol ctrl;

        public AddItems()
        {
            InitializeComponent();
            //initializeerd de controller klasse en de database connectie
            db = new DatabaseConnection();
            ctrl = new CSCcontrol();

            //haalt alle bedrijven uit de database
            ctrl.bedrijven = db.GetAllCompanys();
            //haalt alle bestemmingen uit de database
            ctrl.bestemmingen = db.GetAllDestinations();

            //voegt de gevonden bedrijven toe aan de combobox
            foreach (Bedrijf b in ctrl.bedrijven)
            {
                cbContainerCompany.Items.Add(b.Naam.ToString());
            }

            //voegt de gevonden bestemmingen toe aan de combobox
            foreach (Bestemming be in ctrl.bestemmingen)
            {
                cbContainerDestination.Items.Add(be.Naam.ToString());
            }

            //vult de container combobox met enum waarders van ContainerType
            cbContainerType.DataSource = Enum.GetValues(typeof(Container.ContainerType));
        }

        //voegt een bestemming toe aan het systeem
        private void btnAddDestination_Click(object sender, EventArgs e)
        {
            string name = tbDestinationName.Text;
            string country = tbDestinationCountry.Text;

            if (name != "" && country != "")
            {
                Bestemming destination = new Bestemming(name, country);
                if (ctrl.Add(destination))
                {
                    MessageBox.Show("De bestemming is toegevoegd!");
                }
            }
            else
            {
                MessageBox.Show("U heeft niet alle bestemings gegevens ingevoerd");
            }
        }

        //voegt een schip toe aan het systeem
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

        //voegt een bedrijf toe aan het systeem
        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            string name = tbCompanyName.Text;
            string contact = tbCompanyContactPerson.Text;
            int kvk = 0;
            if (tbCompanyKvknr.Text != "")
            {
               kvk = int.Parse(tbCompanyKvknr.Text);
            }

            if (name != "" && contact != "" && kvk != 0)
            {
                Bedrijf company = new Bedrijf(name, contact, kvk);

                if (ctrl.Add(company))
                {
                    MessageBox.Show("Het bedrijf is toegevoegd!");
                }
            }
            else
            {
                MessageBox.Show("U heeft niet alle bedrijfs gegevens ingevoerd");
            }
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            Bedrijf company = db.GetCompany(cbContainerCompany.SelectedItem.ToString());
            int weight = Convert.ToInt32(tbContainerWeight.Text);
            string bestemming = cbContainerDestination.SelectedItem.ToString(); 


            //haalt het container type enum uit de combox
            Container.ContainerType type = (Container.ContainerType)Enum.Parse(typeof(Container.ContainerType), cbContainerType.SelectedItem.ToString());

            Container container = new Container(weight, type, company);

            if (ctrl.Add(container))
            {
                MessageBox.Show("De container is toegevoegd!");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
