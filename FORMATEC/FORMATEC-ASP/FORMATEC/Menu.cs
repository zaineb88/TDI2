﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FORMATEC.FORMATECDataSetTableAdapters;

namespace FORMATEC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gestionStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stage sta = new Stage();
            sta.MdiParent = this;
            sta.Show();
        }

        private void gestionSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session ses = new Session();
            ses.MdiParent = this;
            ses.Show();
        }
    }
}
