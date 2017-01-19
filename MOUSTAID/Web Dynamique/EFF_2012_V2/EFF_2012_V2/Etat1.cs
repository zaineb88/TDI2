using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EFF_2012_V2
{
    public partial class Etat1 : Form
    {
        public Etat1()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            CrystalReport1 CR = new CrystalReport1();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
