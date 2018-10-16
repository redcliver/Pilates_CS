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
    public partial class fm_balanco : Form
    {
        public fm_balanco()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_diario_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_repost fmDia = new fm_repost();
            fmDia.ShowDialog();
        }

        private void bt_mensal_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_mensal fmMes = new fm_mensal();
            fmMes.ShowDialog();
        }

        private void bt_anual_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_anual fmAno = new fm_anual();
            fmAno.ShowDialog();
        }
    }
}
