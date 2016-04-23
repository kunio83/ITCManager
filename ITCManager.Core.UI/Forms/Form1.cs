﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITCManager.Core.UI.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iTC_DBPOwerDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iTC_DBPOwerDataSet.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.iTC_DBPOwerDataSet.Persona);

        }
    }
}
