﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pilates_CS
{
    public partial class fm_presenca : Form
    {
        public fm_presenca()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_manual_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_manual fmManu = new fm_manual();
            fmManu.ShowDialog();
        }
    }
}
