using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using FORMATEC.FORMATECDataSetTableAdapters;

namespace FORMATEC
{
    public partial class Ajouter_Session : Form
    {
        SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=FORMATEC;Integrated Security=True");
       
        public Ajouter_Session()
        {
            InitializeComponent();
        }

        private void Ajouter_Session_Load(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Session values (" + textBox1.Text + ",'" + dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day + "','" + +dateTimePicker2.Value.Year + "/" + dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.Day  +"'," + textBox2.Text + ")", cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show("Bien ajouté");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
