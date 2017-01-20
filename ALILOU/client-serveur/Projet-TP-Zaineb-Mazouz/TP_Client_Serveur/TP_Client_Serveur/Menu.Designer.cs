namespace TP_Client_Serveur
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulltinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPropreDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.quiterToolStripMenuItem,
            this.bulltinToolStripMenuItem,
            this.aPropreDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesStagiairesToolStripMenuItem,
            this.gestionDesNotesToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // gestionDesStagiairesToolStripMenuItem
            // 
            this.gestionDesStagiairesToolStripMenuItem.Name = "gestionDesStagiairesToolStripMenuItem";
            this.gestionDesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDesStagiairesToolStripMenuItem.Text = "Gestion des stagiaires";
            this.gestionDesStagiairesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesStagiairesToolStripMenuItem_Click);
            // 
            // gestionDesNotesToolStripMenuItem
            // 
            this.gestionDesNotesToolStripMenuItem.Name = "gestionDesNotesToolStripMenuItem";
            this.gestionDesNotesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDesNotesToolStripMenuItem.Text = "Gestion des notes";
            this.gestionDesNotesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesNotesToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quiterToolStripMenuItem.Text = "Quitter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // bulltinToolStripMenuItem
            // 
            this.bulltinToolStripMenuItem.Name = "bulltinToolStripMenuItem";
            this.bulltinToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.bulltinToolStripMenuItem.Text = "Bulltin";
            this.bulltinToolStripMenuItem.Click += new System.EventHandler(this.bulltinToolStripMenuItem_Click);
            // 
            // aPropreDeToolStripMenuItem
            // 
            this.aPropreDeToolStripMenuItem.Name = "aPropreDeToolStripMenuItem";
            this.aPropreDeToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.aPropreDeToolStripMenuItem.Text = "A propre de";
            this.aPropreDeToolStripMenuItem.Click += new System.EventHandler(this.aPropreDeToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesStagiairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPropreDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bulltinToolStripMenuItem;
    }
}

