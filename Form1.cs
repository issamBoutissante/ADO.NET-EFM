using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Des_Films
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void contratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvreForm(new Contrat());
        }
        private void OuvreForm(Form form)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void parFilmActeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvreForm(new RecherchePar_Film_Et_Acteur());
        }

        private void parActeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvreForm(new RechercheParActeur());
        }

        private void imprissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OuvreForm(new Imprission());
        }
    }
}
