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
    public partial class fm_principal : Form
    {
        public fm_principal()
        {
            InitializeComponent();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_paciente_Click(object sender, EventArgs e)
        {
            pn_principal.Controls.Clear();
            fm_paciente fmPac = new fm_paciente();
            fmPac.TopLevel = false;
            pn_principal.Controls.Add(fmPac);
            fmPac.FormBorderStyle = FormBorderStyle.None;
            fmPac.Show();

        }

        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_outro_Click(object sender, EventArgs e)
        {
            pn_principal.Controls.Clear();
            fm_outros fmOutro = new fm_outros();
            fmOutro.TopLevel = false;
            pn_principal.Controls.Add(fmOutro);
            fmOutro.FormBorderStyle = FormBorderStyle.None;
            fmOutro.Show();
        }

        private void bt_presenca_Click(object sender, EventArgs e)
        {
            pn_principal.Controls.Clear();
            fm_presenca fmPresenca = new fm_presenca();
            fmPresenca.TopLevel = false;
            pn_principal.Controls.Add(fmPresenca);
            fmPresenca.FormBorderStyle = FormBorderStyle.None;
            fmPresenca.Show();
        }

        private void bt_agenda_Click(object sender, EventArgs e)
        {
            pn_principal.Controls.Clear();
            fm_agenda1 fmAgenda = new fm_agenda1();
            fmAgenda.TopLevel = false;
            pn_principal.Controls.Add(fmAgenda);
            fmAgenda.FormBorderStyle = FormBorderStyle.None;
            fmAgenda.Show();
        }
    }
}
