using System;
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
    public partial class Fm_agenda : Form
    {
        public Fm_agenda()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_novo_age_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_add_agenda fmaddage = new fm_add_agenda();
            fmaddage.ShowDialog();
        }
    }
}
