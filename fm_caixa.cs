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
    public partial class fm_caixa : Form
    {
        public fm_caixa()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_entrada_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_entrada fmEntr = new fm_entrada();
            fmEntr.ShowDialog();
        }

        private void bt_retirada_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_retirada fmRet = new fm_retirada();
            fmRet.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_fechar fmFec = new fm_fechar();
            fmFec.ShowDialog();
        }
    }
}
