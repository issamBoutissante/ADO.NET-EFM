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
    public partial class RechercheParActeur : Form
    {
        public RechercheParActeur()
        {
            InitializeComponent();
        }

        private void RechercheParActeur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Contrat' table. You can move, or remove it, as needed.
            this.contratTableAdapter.Fill(this.gestionFilmsDataSet.Contrat);
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Acteur' table. You can move, or remove it, as needed.
            this.acteurTableAdapter.Fill(this.gestionFilmsDataSet.Acteur);
            
            //Pour Affecher les contrat de l'acteur en cour au chargement
            this.contratBindingSource.Filter = $"CodeActeur = {CodeActeur_Combo.SelectedValue}";
        }

        private void CodeActeur_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.contratBindingSource.Filter = $"CodeActeur = {CodeActeur_Combo.SelectedValue}";
        }
    }
}
