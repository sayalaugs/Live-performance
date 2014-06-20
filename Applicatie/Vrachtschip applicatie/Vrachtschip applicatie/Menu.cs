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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnIndelen_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItems i = new AddItems();
            this.Hide();
            i.Show();
        }
    }
}
