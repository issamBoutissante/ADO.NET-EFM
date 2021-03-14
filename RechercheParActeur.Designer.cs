
namespace Gestion_Des_Films
{
    partial class RechercheParActeur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CodeActeur_Combo = new System.Windows.Forms.ComboBox();
            this.gestionFilmsDataSet = new Gestion_Des_Films.GestionFilmsDataSet();
            this.acteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acteurTableAdapter = new Gestion_Des_Films.GestionFilmsDataSetTableAdapters.ActeurTableAdapter();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratTableAdapter = new Gestion_Des_Films.GestionFilmsDataSetTableAdapters.ContratTableAdapter();
            this.numContratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateContratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refFilmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeActeurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFilmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numContratDataGridViewTextBoxColumn,
            this.dateContratDataGridViewTextBoxColumn,
            this.refFilmDataGridViewTextBoxColumn,
            this.codeActeurDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contratBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(69, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 243);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 57);
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
            this.CodeActeur_Combo.Location = new System.Drawing.Point(166, 54);
            this.CodeActeur_Combo.Name = "CodeActeur_Combo";
            this.CodeActeur_Combo.Size = new System.Drawing.Size(121, 21);
            this.CodeActeur_Combo.TabIndex = 2;
            this.CodeActeur_Combo.ValueMember = "CodeActeur";
            this.CodeActeur_Combo.SelectedIndexChanged += new System.EventHandler(this.CodeActeur_Combo_SelectedIndexChanged);
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
            // contratBindingSource
            // 
            this.contratBindingSource.DataMember = "Contrat";
            this.contratBindingSource.DataSource = this.gestionFilmsDataSet;
            // 
            // contratTableAdapter
            // 
            this.contratTableAdapter.ClearBeforeFill = true;
            // 
            // numContratDataGridViewTextBoxColumn
            // 
            this.numContratDataGridViewTextBoxColumn.DataPropertyName = "Num_Contrat";
            this.numContratDataGridViewTextBoxColumn.HeaderText = "Num_Contrat";
            this.numContratDataGridViewTextBoxColumn.Name = "numContratDataGridViewTextBoxColumn";
            this.numContratDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateContratDataGridViewTextBoxColumn
            // 
            this.dateContratDataGridViewTextBoxColumn.DataPropertyName = "DateContrat";
            this.dateContratDataGridViewTextBoxColumn.HeaderText = "DateContrat";
            this.dateContratDataGridViewTextBoxColumn.Name = "dateContratDataGridViewTextBoxColumn";
            // 
            // refFilmDataGridViewTextBoxColumn
            // 
            this.refFilmDataGridViewTextBoxColumn.DataPropertyName = "RefFilm";
            this.refFilmDataGridViewTextBoxColumn.HeaderText = "RefFilm";
            this.refFilmDataGridViewTextBoxColumn.Name = "refFilmDataGridViewTextBoxColumn";
            // 
            // codeActeurDataGridViewTextBoxColumn
            // 
            this.codeActeurDataGridViewTextBoxColumn.DataPropertyName = "CodeActeur";
            this.codeActeurDataGridViewTextBoxColumn.HeaderText = "CodeActeur";
            this.codeActeurDataGridViewTextBoxColumn.Name = "codeActeurDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // RechercheParActeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CodeActeur_Combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RechercheParActeur";
            this.Text = "RechercheParActeur";
            this.Load += new System.EventHandler(this.RechercheParActeur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFilmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CodeActeur_Combo;
        private GestionFilmsDataSet gestionFilmsDataSet;
        private System.Windows.Forms.BindingSource acteurBindingSource;
        private GestionFilmsDataSetTableAdapters.ActeurTableAdapter acteurTableAdapter;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private GestionFilmsDataSetTableAdapters.ContratTableAdapter contratTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numContratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateContratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn refFilmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeActeurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
    }
}