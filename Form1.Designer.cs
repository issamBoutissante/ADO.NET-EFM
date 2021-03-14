
namespace Gestion_Des_Films
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contratToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parActeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFilmActeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratToolStripMenuItem,
            this.rechercheToolStripMenuItem,
            this.imprissionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contratToolStripMenuItem
            // 
            this.contratToolStripMenuItem.Name = "contratToolStripMenuItem";
            this.contratToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.contratToolStripMenuItem.Text = "Contrat";
            this.contratToolStripMenuItem.Click += new System.EventHandler(this.contratToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parActeurToolStripMenuItem,
            this.parFilmActeurToolStripMenuItem});
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            // 
            // imprissionToolStripMenuItem
            // 
            this.imprissionToolStripMenuItem.Name = "imprissionToolStripMenuItem";
            this.imprissionToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.imprissionToolStripMenuItem.Text = "Imprission";
            this.imprissionToolStripMenuItem.Click += new System.EventHandler(this.imprissionToolStripMenuItem_Click);
            // 
            // parActeurToolStripMenuItem
            // 
            this.parActeurToolStripMenuItem.Name = "parActeurToolStripMenuItem";
            this.parActeurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parActeurToolStripMenuItem.Text = "Par Acteur";
            this.parActeurToolStripMenuItem.Click += new System.EventHandler(this.parActeurToolStripMenuItem_Click);
            // 
            // parFilmActeurToolStripMenuItem
            // 
            this.parFilmActeurToolStripMenuItem.Name = "parFilmActeurToolStripMenuItem";
            this.parFilmActeurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parFilmActeurToolStripMenuItem.Text = "Par Film et Acteur";
            this.parFilmActeurToolStripMenuItem.Click += new System.EventHandler(this.parFilmActeurToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contratToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parActeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFilmActeurToolStripMenuItem;
    }
}

