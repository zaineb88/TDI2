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
    public partial class Etat2 : Form
    {
        public Etat2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CrystalReport2 CR = new CrystalReport2();
            crystalReportViewer1.ReportSource = CR;
        }
    }
}
