using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_Client_Serveur
{
    public partial class GestionDesNotes : Form
    {
        public GestionDesNotes()
        {
            InitializeComponent();
        }

        private void GestionDesNotes_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            GestionDesStagiaires.MyAdapNote.Fill(GestionDesStagiaires.MyDS.Notes);
            GestionDesStagiaires.MyAdapter.Fill(GestionDesStagiaires.MyDS.Stagiaire);
            GestionDesStagiaires.AdapVue.Fill(GestionDesStagiaires.MyDS.Vue3);
            string var;
            for (int i = 0; i < GestionDesStagiaires.MyDS.Stagiaire.Count; i++)
            {
                var = GestionDesStagiaires.MyDS.Stagiaire[i][0].ToString() + " "
                    + GestionDesStagiaires.MyDS.Stagiaire[i][1].ToString() +
                    " " + GestionDesStagiaires.MyDS.Stagiaire[i][2].ToString();
                comboBox1.Items.Add(var);
            }
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            comboBox2.Text = "";
            textBox1.Text = "";
            comboBox2.Items.Clear();
            GestionDesStagiaires.MyAdaptMod.Fill(GestionDesStagiaires.MyDS.Module);
            for (int i = 0; i < GestionDesStagiaires.MyDS.Module.Count; i++)
            {
                comboBox2.Items.Add(GestionDesStagiaires.MyDS.Module[i][1]);
                
            }
           
                int var1 = (int)GestionDesStagiaires.MyDS.Stagiaire[int.Parse(comboBox1.SelectedIndex.ToString())][0];
                DataView dv = new DataView();
                dv.Table = GestionDesStagiaires.MyDS.Tables["Vue3"];
                dv.RowFilter = "Num_Sta =" + var1 + "";
                dataGridView1.DataSource = dv;

                         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            int var1 = (int)GestionDesStagiaires.MyDS.Stagiaire[int.Parse(comboBox1.SelectedIndex.ToString())][0];
           int var2 = (int)GestionDesStagiaires.MyDS.Module[int.Parse(comboBox2.SelectedIndex.ToString())][0];
           if (GestionDesStagiaires.MyDS.Notes.FindByNum_StaNum_Mod(var1, var2)[2] == null)
           {
               textBox1.Text = "";

           }
           else
            textBox1.Text = GestionDesStagiaires.MyDS.Notes.FindByNum_StaNum_Mod(var1, var2)[2].ToString();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            if (button1.Text == "Nouveau")
            {
                textBox1.Enabled = true;
                button1.Text = "Valider";
                
            }
            else
            {
                int var1 = (int)GestionDesStagiaires.MyDS.Stagiaire[int.Parse(comboBox1.SelectedIndex.ToString())][0];
                int var2 = (int)GestionDesStagiaires.MyDS.Module[int.Parse(comboBox2.SelectedIndex.ToString())][0];
                textBox1.Enabled = false;
                button1.Text = "Nouveau";
                SqlConnection MyConnection = new SqlConnection();
                MyConnection.ConnectionString = "Initial Catalog=TPClientServeur;Data Source=localhost;Integrated Security=SSPI;";
                SqlCommand MyCommand = new SqlCommand();
                MyCommand.Connection = MyConnection;
                MyCommand.CommandType = CommandType.Text;
                MyCommand.CommandText = "update Notes set Note =" + float.Parse(textBox1.Text) + "where Num_Sta =" + var1 + " and Num_Mod =" + var2;
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Enregistrer note")
            {
                textBox1.Enabled = true;
                button2.Text = "Enregistrer  note";

            }
            else
            {
                int var1 = (int)GestionDesStagiaires.MyDS.Stagiaire[int.Parse(comboBox1.SelectedIndex.ToString())][0];
                int var2 = (int)GestionDesStagiaires.MyDS.Module[int.Parse(comboBox2.SelectedIndex.ToString())][0];
                textBox1.Enabled = false;
                button2.Text = "Enregistrer note";
                SqlConnection MyConnection = new SqlConnection();
                MyConnection.ConnectionString = "Initial Catalog=TPClientServeur;Data Source=localhost;Integrated Security=SSPI;";
                SqlCommand MyCommand = new SqlCommand();
                MyCommand.Connection = MyConnection;
                MyCommand.CommandType = CommandType.Text;
                MyCommand.CommandText = "update Notes set Note =" + float.Parse(textBox1.Text) + "where Num_Sta =" + var1 + " and Num_Mod =" + var2;
                MyConnection.Open();
                MyCommand.ExecuteNonQuery();
                MyConnection.Close();
            }
            GestionDesStagiaires.MyAdapNote.Update(GestionDesStagiaires.MyDS.Notes);
            MessageBox.Show("La note a été enregisté", "Ajoute", MessageBoxButtons.OK);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Modifier note")
            {
                textBox1.Enabled = true;
                button3.Text = "Valider";

            }
            else
            {
                button3.Text ="Modifier note";
                textBox1.Enabled = false;
                GestionDesStagiaires.MyDS.Notes[comboBox2.SelectedIndex][2] = float.Parse(textBox1.Text);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[3].Value.ToString() != "")
            {
                float res = 0;
                for (int i = 0; i < GestionDesStagiaires.MyDS.Module.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() != "")
                    {
                        res += float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    }
                }
                textBox2.Text = (res / GestionDesStagiaires.MyDS.Module.Count).ToString();
            }
            else
                textBox2.Text = "0";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
