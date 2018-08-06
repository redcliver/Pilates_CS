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
    public partial class fm_plano : Form
    {
        public fm_plano()
        {
            InitializeComponent();
        }

        private void fm_plano_Load(object sender, EventArgs e)
        {

        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_novoPlano fmNovoPlan = new fm_novoPlano();
            fmNovoPlan.ShowDialog();
        }

        private void bt_edita_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_editPlano fmEditaPlan = new fm_editPlano();
            fmEditaPlan.ShowDialog();
        }
    }
}
