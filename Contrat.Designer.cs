
namespace Gestion_Des_Films
{
    partial class Contrat
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Premier = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Suivant = new System.Windows.Forms.Button();
            this.Dernier = new System.Windows.Forms.Button();
            this.Precedent = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Modifeir = new System.Windows.Forms.Button();
            this.Enregistrer = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.gestionFilmsDataSet = new Gestion_Des_Films.GestionFilmsDataSet();
            this.contratBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratTableAdapter = new Gestion_Des_Films.GestionFilmsDataSetTableAdapters.ContratTableAdapter();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new Gestion_Des_Films.GestionFilmsDataSetTableAdapters.FilmTableAdapter();
            this.acteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acteurTableAdapter = new Gestion_Des_Films.GestionFilmsDataSetTableAdapters.ActeurTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gestionFilmsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acteurBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero contrat";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "Num_Contrat", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(141, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Premier
            // 
            this.Premier.Location = new System.Drawing.Point(296, 41);
            this.Premier.Name = "Premier";
            this.Premier.Size = new System.Drawing.Size(75, 23);
            this.Premier.TabIndex = 2;
            this.Premier.Text = "|<<";
            this.Premier.UseVisualStyleBackColor = true;
            this.Premier.Click += new System.EventHandler(this.Premier_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contratBindingSource, "RefFilm", true));
            this.comboBox1.DataSource = this.filmBindingSource;
            this.comboBox1.DisplayMember = "RefFilm";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "RefFilm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date Contrat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reference Film";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Code Acteur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Role";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "Role", true));
            this.textBox5.Location = new System.Drawing.Point(141, 201);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contratBindingSource, "DateContrat", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contratBindingSource, "DateContrat", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contratBindingSource, "CodeActeur", true));
            this.comboBox2.DataSource = this.acteurBindingSource;
            this.comboBox2.DisplayMember = "CodeActeur";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(141, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "CodeActeur";
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(387, 43);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 2;
            this.Suivant.Text = ">>";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Dernier
            // 
            this.Dernier.Location = new System.Drawing.Point(549, 43);
            this.Dernier.Name = "Dernier";
            this.Dernier.Size = new System.Drawing.Size(75, 23);
            this.Dernier.TabIndex = 2;
            this.Dernier.Text = ">>|";
            this.Dernier.UseVisualStyleBackColor = true;
            this.Dernier.Click += new System.EventHandler(this.Dernier_Click);
            // 
            // Precedent
            // 
            this.Precedent.Location = new System.Drawing.Point(468, 43);
            this.Precedent.Name = "Precedent";
            this.Precedent.Size = new System.Drawing.Size(75, 23);
            this.Precedent.TabIndex = 2;
            this.Precedent.Text = "<<";
            this.Precedent.UseVisualStyleBackColor = true;
            this.Precedent.Click += new System.EventHandler(this.Precedent_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(505, 95);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 2;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(342, 93);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(75, 23);
            this.Nouveau.TabIndex = 2;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Modifeir
            // 
            this.Modifeir.Location = new System.Drawing.Point(342, 137);
            this.Modifeir.Name = "Modifeir";
            this.Modifeir.Size = new System.Drawing.Size(75, 23);
            this.Modifeir.TabIndex = 2;
            this.Modifeir.Text = "Modifier";
            this.Modifeir.UseVisualStyleBackColor = true;
            this.Modifeir.Click += new System.EventHandler(this.Modifeir_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.Location = new System.Drawing.Point(430, 180);
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.Enregistrer.TabIndex = 2;
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.UseVisualStyleBackColor = true;
            this.Enregistrer.Click += new System.EventHandler(this.Enregistrer_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(505, 137);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // gestionFilmsDataSet
            // 
            this.gestionFilmsDataSet.DataSetName = "GestionFilmsDataSet";
            this.gestionFilmsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.gestionFilmsDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
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
            // Contrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 240);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Precedent);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Enregistrer);
            this.Controls.Add(this.Modifeir);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Dernier);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Premier);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Contrat";
            this.Text = "Contrat";
            this.Load += new System.EventHandler(this.Contrat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestionFilmsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acteurBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Premier;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Dernier;
        private System.Windows.Forms.Button Precedent;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.Button Modifeir;
        private System.Windows.Forms.Button Enregistrer;
        private System.Windows.Forms.Button Supprimer;
        private GestionFilmsDataSet gestionFilmsDataSet;
        private System.Windows.Forms.BindingSource contratBindingSource;
        private GestionFilmsDataSetTableAdapters.ContratTableAdapter contratTableAdapter;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private GestionFilmsDataSetTableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource acteurBindingSource;
        private GestionFilmsDataSetTableAdapters.ActeurTableAdapter acteurTableAdapter;
    }
}