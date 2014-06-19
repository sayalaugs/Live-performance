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

            ctrl.schepen = db.GetAllShips();

            cbShips.DataSource = Enum.GetValues(typeof(Container.ContainerType));

            foreach (Vrachtschip v in ctrl.schepen)
            {
                cbDestination.Items.Add(v.Type);
            }
        }

        private void btnGenerateLayout_Click(object sender, EventArgs e)
        {
            Vrachtschip ship = db.GetShip("MPP-F3");
        }
    }
}
