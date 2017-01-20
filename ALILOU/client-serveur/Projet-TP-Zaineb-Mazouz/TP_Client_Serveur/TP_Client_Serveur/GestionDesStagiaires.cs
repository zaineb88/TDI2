using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Client_Serveur.TPClientServeurDataSetTableAdapters;

namespace TP_Client_Serveur
{
    public partial class GestionDesStagiaires : Form
    {
        internal static StagiaireTableAdapter MyAdapter = new StagiaireTableAdapter();
        internal static TPClientServeurDataSet MyDS = new TPClientServeurDataSet();
        internal static BindingSource BS = new BindingSource();
        internal static NotesTableAdapter MyAdapNote = new NotesTableAdapter();
        internal static BindingSource BSNote = new BindingSource();
        internal static ModuleTableAdapter MyAdaptMod = new ModuleTableAdapter();
        internal static Vue3TableAdapter AdapVue = new Vue3TableAdapter();
        internal static BindingSource BSVue = new BindingSource();
       
        public GestionDesStagiaires()
        {
            InitializeComponent();
        }

        private void GestionDesStagiaires_Load(object sender, EventArgs e)
        {
            MyAdapNote.Fill(MyDS.Notes);
            BSNote.DataSource = MyDS.Notes;
            MyAdapter.Fill(MyDS.Stagiaire);
            BS.DataSource = MyDS.Stagiaire;
            textBox1.DataBindings.Add("Text", BS, "Num_Sta");
            textBox2.DataBindings.Add("Text", BS, "Nom_Sta");
            textBox3.DataBindings.Add("Text", BS, "Pre_Sta");
            textBox4.DataBindings.Add("Text", BS, "Date_Sta");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BS.MoveFirst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BS.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BS.MoveNext();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BS.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Nouveau Stagiaire")
            {
                button1.Text = "Valider";
                BS.AddNew();
            }
            else
            {
                button1.Text = "Nouveau Stagiaire";
                BS.EndEdit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyAdapter.Update(MyDS.Stagiaire);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BS.EndEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraimenet supprimez ? ", "Suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BS.RemoveCurrent();
                BS.EndEdit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataView s = new DataView(MyDS.Notes);
            float Moyenne=0;
            s.RowFilter = "Num_Sta =" + int.Parse(textBox1.Text);
            for (int i = 0; i < s.Count; i++)
            {
                Moyenne += float.Parse(s[i][2].ToString());
            }
            Moyenne = Moyenne / s.Count;
            MessageBox.Show("La moyenne est : " + Moyenne.ToString() + " points.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (BS.Find("Num_Sta", textBox5.Text) == -1)
            {
                MessageBox.Show("Le stagiaire  " + textBox5.Text + " Le numero de stagiaire n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { BS.Position = BS.Find("Num_Sta", textBox5.Text); }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Recherche Rech = new Recherche();
            if (Rech.ShowDialog() == DialogResult.OK)
            {
                if (Rech.radioButton1.Checked)
                {
                    if (BS.Find("Nom_Sta", Rech.textBox1.Text) == -1)
                    {
                        MessageBox.Show("Le stagiaire  " + Rech.textBox1.Text + "  n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    { BS.Position = BS.Find("Nom_Sta", Rech.textBox1.Text); }
                }
                else
                {
                    if (BS.Find("Pre_Sta", Rech.textBox1.Text) == -1)
                    {
                        MessageBox.Show("Le stagiaire  " + Rech.textBox1.Text + "  n'existe pas", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    { BS.Position = BS.Find("Pre_Sta", Rech.textBox1.Text); }
                }
            }
        }
    }
}
