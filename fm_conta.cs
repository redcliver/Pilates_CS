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
    public partial class fm_conta : Form
    {
        public fm_conta()
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
            fm_novaConta fmNovaCon = new fm_novaConta();
            fmNovaCon.ShowDialog();
        }

        private void bt_edita_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_editConta fmEditCon = new fm_editConta();
            fmEditCon.ShowDialog();
        }

        private void bt_pagar_Click(object sender, EventArgs e)
        {
            this.Hide();
            fm_pag_conta fmPagCont = new fm_pag_conta();
            fmPagCont.ShowDialog();
        }
    }
}
