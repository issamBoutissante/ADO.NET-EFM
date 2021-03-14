using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Gestion_Des_Films
{
    public partial class Imprission : Form
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["Gestion_Des_Films.Properties.Settings.GestionFilmsConnectionString"].ConnectionString;
        public Imprission()
        {
            InitializeComponent();
        }
        
        private void Imprission_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gestionFilmsDataSet.Acteur' table. You can move, or remove it, as needed.
            this.acteurTableAdapter.Fill(this.gestionFilmsDataSet.Acteur);

        }

        private void ImprimerContrat_Click(object sender, EventArgs e)
        {
            DataTable ContratTable = new DataTable();
            
            new SqlDataAdapter($"select * from Contrat where CodeActeur = {CodeActeur_Combo.SelectedValue};",
                new SqlConnection(connectionString)).Fill(ContratTable);
            ContratCrystalReport report = new ContratCrystalReport();
            report.SetDataSource(ContratTable);

            crystalReportViewer1.ReportSource = report;
        }

        private void ImprimerFilms_Click(object sender, EventArgs e)
        {
            DataTable FilmTable = new DataTable();

            new SqlDataAdapter($"select Film.* from Contrat join Film on Contrat.RefFilm = Film.RefFilm " +
                $"where CodeActeur = {CodeActeur_Combo.SelectedValue};",
                new SqlConnection(connectionString)).Fill(FilmTable);
            FilmsCrystalReport report = new FilmsCrystalReport();
            report.SetDataSource(FilmTable);

            crystalReportViewer1.ReportSource = report;
        }
    }
}
