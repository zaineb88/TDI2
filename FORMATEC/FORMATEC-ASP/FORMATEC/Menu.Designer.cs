namespace FORMATEC
{
    partial class Menu
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etatStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionStageToolStripMenuItem,
            this.gestionSessionToolStripMenuItem,
            this.etatStageToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // gestionStageToolStripMenuItem
            // 
            this.gestionStageToolStripMenuItem.Name = "gestionStageToolStripMenuItem";
            this.gestionStageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gestionStageToolStripMenuItem.Text = "Gestion Stage";
            this.gestionStageToolStripMenuItem.Click += new System.EventHandler(this.gestionStageToolStripMenuItem_Click);
            // 
            // gestionSessionToolStripMenuItem
            // 
            this.gestionSessionToolStripMenuItem.Name = "gestionSessionToolStripMenuItem";
            this.gestionSessionToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gestionSessionToolStripMenuItem.Text = "Gestion Session";
            this.gestionSessionToolStripMenuItem.Click += new System.EventHandler(this.gestionSessionToolStripMenuItem_Click);
            // 
            // etatStageToolStripMenuItem
            // 
            this.etatStageToolStripMenuItem.Name = "etatStageToolStripMenuItem";
            this.etatStageToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.etatStageToolStripMenuItem.Text = "Etat Stage";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etatStageToolStripMenuItem;

    }
}