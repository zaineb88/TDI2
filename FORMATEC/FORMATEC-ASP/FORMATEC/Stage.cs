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
    public partial class Stage : Form
    {
        

        internal static int CodeRow;

        internal static StageTableAdapter stage = new StageTableAdapter();
        internal static FORMATECDataSet ds=new FORMATECDataSet();
        internal static BindingSource bs=new BindingSource();

        
        public Stage()
        {
            InitializeComponent();
        }
        
        private void Stage_Load(object sender, EventArgs e)
        {
            stage.Fill(ds.Stage);

            dataGridView1.DataSource = ds.Tables["Stage"];
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Statistiques_Stage stati = new Statistiques_Stage();
            stati.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ajouter_Stage aj_sta = new Ajouter_Stage();
            aj_sta.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modifier_Stage mod_sta = new Modifier_Stage();
            mod_sta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stage.Update(ds.Stage);
            MessageBox.Show("Bien enregistré");
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Voulez vous vraiment supprimer", "Supprission", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ds.Tables["Stage"].Rows[CodeRow].Delete();
               
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodeRow = e.RowIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(ds.Stage);
                if (radioButton1.Checked == true)
                {
                    dataGridView1.DataSource = ds.Tables["Stage"];

                }
                else
                {
                    if (radioButton2.Checked == true)
                    {
                        dv.RowFilter = "numerostage =" + textBox1.Text;
                        dataGridView1.DataSource = dv;
                    }
                    else
                    {

                        if (radioButton3.Checked == true)
                        {
                            dv.RowFilter = "intituléstage like '"+textBox1.Text+"%'";
                            dataGridView1.DataSource = dv;
                        }
                    }
                }
            }
            catch { }


        }
    }
}
