
namespace Gestion_Des_Films
{
    partial class Imprission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeActeur_Combo = new System.Windows.Forms.ComboBox();
            this.gestionFilmsDataSet = new Gestion_Des_Films.GestionFilmsDataSet();
            this.acteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acteurTableAdapter = new Gestion_Des_Films.GestionFilmsDataSetTableAdapters.ActeurTableAdapter();
            this.ImprimerContrat = new System.Windows.Forms.Button();
            this.ImprimerFilms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFilmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 61);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(801, 389);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code Acteur";
            // 
            // CodeActeur_Combo
            // 
            this.CodeActeur_Combo.DataSource = this.acteurBindingSource;
            this.CodeActeur_Combo.DisplayMember = "CodeActeur";
            this.CodeActeur_Combo.FormattingEnabled = true;
            this.CodeActeur_Combo.Location = new System.Drawing.Point(146, 20);
            this.CodeActeur_Combo.Name = "CodeActeur_Combo";
            this.CodeActeur_Combo.Size = new System.Drawing.Size(121, 21);
            this.CodeActeur_Combo.TabIndex = 2;
            this.CodeActeur_Combo.ValueMember = "CodeActeur";
            // 
            // gestionFilmsDataSet
            // 
            this.gestionFilmsDataSet.DataSetName = "GestionFilmsDataSet";
            this.gestionFilmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // acteurBindingSource
            // 
            this.acteurBindingSource.DataMember = "Acteur";
            this.acteurBindingSource.DataSource = this.gestionFilmsDataSet;
            // 
            // acteurTableAdapter
            // 
            this.acteurTableAdapter.ClearBeforeFill = true;
            // 
            // ImprimerContrat
            // 
            this.ImprimerContrat.Location = new System.Drawing.Point(334, 20);
            this.ImprimerContrat.Name = "ImprimerContrat";
            this.ImprimerContrat.Size = new System.Drawing.Size(142, 23);
            this.ImprimerContrat.TabIndex = 3;
            this.ImprimerContrat.Text = "Imprimer Les Contrat";
            this.ImprimerContrat.UseVisualStyleBackColor = true;
            this.ImprimerContrat.Click += new System.EventHandler(this.ImprimerContrat_Click);
            // 
            // ImprimerFilms
            // 
            this.ImprimerFilms.Location = new System.Drawing.Point(523, 18);
            this.ImprimerFilms.Name = "ImprimerFilms";
            this.ImprimerFilms.Size = new System.Drawing.Size(142, 23);
            this.ImprimerFilms.TabIndex = 4;
            this.ImprimerFilms.Text = "Imprimer Les Films";
            this.ImprimerFilms.UseVisualStyleBackColor = true;
            this.ImprimerFilms.Click += new System.EventHandler(this.ImprimerFilms_Click);
            // 
            // Imprission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ImprimerFilms);
            this.Controls.Add(this.ImprimerContrat);
            this.Controls.Add(this.CodeActeur_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Imprission";
            this.Text = "Imprission";
            this.Load += new System.EventHandler(this.Imprission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionFilmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CodeActeur_Combo;
        private GestionFilmsDataSet gestionFilmsDataSet;
        private System.Windows.Forms.BindingSource acteurBindingSource;
        private GestionFilmsDataSetTableAdapters.ActeurTableAdapter acteurTableAdapter;
        private System.Windows.Forms.Button ImprimerContrat;
        private System.Windows.Forms.Button ImprimerFilms;
    }
}