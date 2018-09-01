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
    public partial class fm_outros : Form
    {
        public fm_outros()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_plano_Click(object sender, EventArgs e)
        {
            this.Close();
            fm_plano fmPlano = new fm_plano();
            fmPlano.ShowDialog();
        }

        private void bt_prof_Click(object sender, EventArgs e)
        {
            this.Close();
            fm_prof fmProf = new fm_prof();
            fmProf.ShowDialog();
        }

        private void bt_balanco_Click(object sender, EventArgs e)
        {
            this.Close();
            fm_balanco fmBal = new fm_balanco();
            fmBal.ShowDialog();
        }

        private void bt_conta_Click(object sender, EventArgs e)
        {
            this.Close();
            fm_conta fmCont = new fm_conta();
            fmCont.ShowDialog();
        }

        private void bt_caixa_Click(object sender, EventArgs e)
        {
            this.Close();
            fm_caixa fmCaixa = new fm_caixa();
            fmCaixa.ShowDialog();
        }

        private void bt_pagamento_Click(object sender, EventArgs e)
        {
            this.Close();
            fm_pagamento fmPag = new fm_pagamento();
            fmPag.ShowDialog();
        }
    }
}
