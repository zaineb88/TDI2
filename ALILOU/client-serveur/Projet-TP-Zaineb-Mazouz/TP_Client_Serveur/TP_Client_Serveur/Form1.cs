using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TP_Client_Serveur.TPClientServeurDataSetTableAdapters;

namespace TP_Client_Serveur
{
    public partial class Form1 : Form
    {
        Bulltin B = new Bulltin();
        BulltinTableAdapter TA = new BulltinTableAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TA.Fill(GestionDesStagiaires.MyDS.Bulltin);
            B.SetDataSource(GestionDesStagiaires.MyDS);
            crystalReportViewer1.ReportSource = B;

        }
    }
}
