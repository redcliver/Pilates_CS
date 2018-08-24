using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Pilates_CS
{
    public partial class fm_editConta : Form
    {
        public fm_editConta()
        {
            InitializeComponent();
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "SELECT * FROM conta ORDER BY nome";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("conta_id", typeof(int));
            dt.Columns.Add("nome", typeof(string));
            dt.Load(reader);

            cb_conta.ValueMember = "conta_id";
            cb_conta.DisplayMember = "nome";
            cb_conta.DataSource = dt;

            conn.Close();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_editConta_Load(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            string conId = cb_conta.SelectedValue.ToString();
            fm_editarConta fmEditarCont = new fm_editarConta(conId);
            fmEditarCont.ShowDialog();
        }
    }
}
