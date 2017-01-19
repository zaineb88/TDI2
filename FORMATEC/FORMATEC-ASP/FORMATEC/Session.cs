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
    public partial class Session : Form
      
    {    internal static int CodeRow;

 //SqlConnection cnx = new SqlConnection("Data Source=.;Initial Catalog=FORMATEC;Integrated Security=True");
    //SqlCommand cmd = new SqlCommand("select * from Session"),cnx;
   //internal static SqlDataReader dr = new SqlDataReader();


        public Session()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Session aj_sess = new Ajouter_Session();
            aj_sess.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier_Session mo_sess = new Modifier_Session();
            mo_sess.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Session_Load(object sender, EventArgs e)
        {
            //session.Fill(ds.Session);

            //dataGridView1.DataSource = ds.Tables["Session"];
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=FORMATEC;Integrated Security=True");
           con.Open();
            SqlCommand cmd = new SqlCommand("select * from Session ",con);
            dataGridView1.DataSource = cmd;
            cmd.ExecuteNonQuery();
            con.Close();
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodeRow = e.RowIndex;
        }

       
    }
}
