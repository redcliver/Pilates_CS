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
    public partial class fm_prof : Form
    {
        public fm_prof()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_novoProf fmNovoProf = new fm_novoProf();
            fmNovoProf.ShowDialog();
        }

        private void bt_edita_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_editProf fmEdiProf = new fm_editProf();
            fmEdiProf.ShowDialog();
        }
    }
}
