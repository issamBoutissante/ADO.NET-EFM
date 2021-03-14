using System;
using System.Windows.Forms;

namespace Gestion_Des_Films
{
    public partial class Contrat : Form
    {
        public Contrat()
        {
            InitializeComponent();
        }

        private void Contrat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Acteur' table. You can move, or remove it, as needed.
            this.acteurTableAdapter.Fill(this.gestionFilmsDataSet.Acteur);
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.gestionFilmsDataSet.Film);
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Contrat' table. You can move, or remove it, as needed.
            this.contratTableAdapter.Fill(this.gestionFilmsDataSet.Contrat);

        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                this.contratBindingSource.RemoveCurrent();
                MessageBox.Show("La supprission a ete effectue", "Termine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                this.contratTableAdapter.Update(this.gestionFilmsDataSet.Contrat);
                MessageBox.Show("La mise a jour a ete effectue", "Termine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Modifeir_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                MessageBox.Show("il fuat remplir tous les champs", "termine");
                return;
            };
            try
            {
                this.contratBindingSource.EndEdit();
                MessageBox.Show("La modification a ete effectue", "Termine");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            this.contratBindingSource.AddNew();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (!Validate()) 
            {
                MessageBox.Show("il fuat remplir tous les champs","termine");
                return;
            };
            try
            {
                this.contratBindingSource.EndEdit();
                MessageBox.Show("L'ajout a ete effectue","Termine");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void Precedent_Click(object sender, EventArgs e)
        {
            this.contratBindingSource.MovePrevious();
        }

        private void Dernier_Click(object sender, EventArgs e)
        {
            this.contratBindingSource.MoveLast();
        }

        private void Suivant_Click(object sender, EventArgs e)
        {
            this.contratBindingSource.MoveNext();
        }

        private void Premier_Click(object sender, EventArgs e)
        {
            this.contratBindingSource.MoveFirst();
        }
        private bool Validate()
        {
            foreach (Control c in this.Controls)
               if (string.IsNullOrEmpty(c.Text))
                   return false;
            return true;
        }
    }
}
