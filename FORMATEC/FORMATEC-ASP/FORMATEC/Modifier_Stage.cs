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
    public partial class Modifier_Stage : Form
    {
        public Modifier_Stage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Stage.ds.Stage[Stage.CodeRow][0]=textBox1.Text;
            Stage.ds.Stage[Stage.CodeRow][1]=textBox2.Text;
            Stage.stage.Update(Stage.ds.Stage);
            
            MessageBox.Show("Bien modifié");

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Modifier_Stage_Load(object sender, EventArgs e)
        {
            textBox1.Text = Stage.ds.Stage[Stage.CodeRow][0].ToString();
            textBox2.Text = Stage.ds.Stage[Stage.CodeRow][1].ToString();
        }
    }
}
