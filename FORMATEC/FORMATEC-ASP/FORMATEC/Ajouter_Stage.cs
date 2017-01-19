using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FORMATEC.FORMATECDataSetTableAdapters;
using System.Data.SqlClient;

namespace FORMATEC
{
    public partial class Ajouter_Stage : Form
    {
        public Ajouter_Stage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow ligne = Stage.ds.Tables["Stage"].NewRow();
            ligne[0]=textBox1.Text;
            ligne[1]=textBox2.Text;
            Stage.ds.Tables["Stage"].Rows.Add(ligne);
            MessageBox.Show("Bien ajouté");
            Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
