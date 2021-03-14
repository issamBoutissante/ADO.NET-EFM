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
    public partial class RecherchePar_Film_Et_Acteur : Form
    {
        public RecherchePar_Film_Et_Acteur()
        {
            InitializeComponent();
        }

        private void RecherchePar_Film_Et_Acteur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Contrat' table. You can move, or remove it, as needed.
            this.contratTableAdapter.Fill(this.gestionFilmsDataSet.Contrat);
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Acteur' table. You can move, or remove it, as needed.
            this.acteurTableAdapter.Fill(this.gestionFilmsDataSet.Acteur);
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.gestionFilmsDataSet.Film);

            //Pour Affecher les contrat de l'acteur et RefFilm en cour au chargement
            this.contratBindingSource.Filter = $"CodeActeur = {CodeActeur_Combo.SelectedValue} and RefFilm = {ReferenceFilm_Combo.SelectedValue}";
        }

        //on va assoucie cette method a l'evenement selectedIndexChanged de chaque ComboBox
        private void Recherche(object sender, EventArgs e)
        {
            this.contratBindingSource.Filter = $"CodeActeur = {CodeActeur_Combo.SelectedValue} and RefFilm = {ReferenceFilm_Combo.SelectedValue}";
        }
    }
}
