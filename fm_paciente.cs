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
    public partial class fm_paciente : Form
    {
        public fm_paciente()
        {
            InitializeComponent();
        }

        private void bt_novoPac_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_novoPaciente fmNovoPac = new fm_novoPaciente();
            fmNovoPac.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_editPac fmBuscaPac = new fm_editPac();
            fmBuscaPac.ShowDialog();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
