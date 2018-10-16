using Microsoft.Reporting.WebForms;
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
    public partial class fm_repost : Form
    {
        public fm_repost()
        {
            InitializeComponent();
        }

        private void fm_repost_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            var month = today.AddMonths(-1);
            // TODO: esta linha de código carrega dados na tabela 'DataSet2.caixa_geral'. Você pode movê-la ou removê-la conforme necessário.
            this.caixa_geralTableAdapter.Fill(this.DataSet2.caixa_geral);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
