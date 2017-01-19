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
    public partial class Statistiques_Stage : Form
    {
       
        QueriesTableAdapter totalcan = new QueriesTableAdapter();
        DataView dv = new DataView(Stage.ds.Stage);


        public Statistiques_Stage()
        {
            InitializeComponent();
        }

        private void Statistiques_Stage_Load(object sender, EventArgs e)
        {


            Stage.stage.Fill(Stage.ds.Stage);
            dataGridView1.DataSource = Stage.ds.Tables["Stage"];
            comboBox1.DataSource = Stage.ds.Stage;
            comboBox1.ValueMember = Stage.ds.Stage.Columns[1].ToString();
            comboBox1.Text = "";


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {

                dv.Table = Stage.ds.Stage;
                dv.RowFilter = "Intituléstage='" + comboBox1.SelectedValue + "'";
                dataGridView1.DataSource = dv;

            }
        }


        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {

                if (maskedTextBox1.Text.Length > 0)
                {
                    dv.Table = Stage.ds.Stage;
                    dv.RowFilter = " numerostage=" + maskedTextBox1.Text;
                    dataGridView1.DataSource = dv;
                }
                else
                {
                    dataGridView1.DataSource = Stage.ds.Stage;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            dataGridView1.DataSource = Stage.ds.Stage;
            maskedTextBox1.Enabled = radioButton1.Checked;
            comboBox1.Enabled = radioButton2.Checked;
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label4.Text = totalcan.totalcandidats((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            if (label4.Text == "")
            {
                label4.Text = "ce stage n'a pas des candidats";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

      

    }

}

