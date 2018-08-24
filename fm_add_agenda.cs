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
    public partial class fm_add_agenda : Form
    {
        public fm_add_agenda()
        {
            InitializeComponent();
            DateTime hoje = DateTime.Now;
            tb_teste.Text = hoje.ToString("dddd");
        }

        private void fm_add_agenda_Load(object sender, EventArgs e)
        {

        }
    }
}
