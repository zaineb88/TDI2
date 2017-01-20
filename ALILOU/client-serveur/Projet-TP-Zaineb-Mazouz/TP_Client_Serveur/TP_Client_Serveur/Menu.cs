using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_Client_Serveur
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gestionDesStagiairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDesStagiaires GS = new GestionDesStagiaires();
            GS.MdiParent = this;
            GS.Show();
        }

        private void gestionDesNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDesNotes GN = new GestionDesNotes();
            GN.MdiParent = this;
            GN.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aPropreDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Realizer par ZAINEB MAZOUZ ");
        }

        private void bulltinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.MdiParent = this;
            F1.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
