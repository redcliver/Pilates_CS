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
    public partial class fm_editPac : Form
    {
        public fm_editPac()
        {
            InitializeComponent();
        }
        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_editPac_Load(object sender, EventArgs e)
        {
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "SELECT * FROM paciente ORDER BY nome";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("paciente_id", typeof(int));
            dt.Columns.Add("nome", typeof(string));
            dt.Load(reader);

            cb_paciente.ValueMember = "paciente_id";
            cb_paciente.DisplayMember = "nome";
            cb_paciente.DataSource = dt;

            conn.Close();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            string pacId = cb_paciente.SelectedValue.ToString();
            fm_editarPac fmEditarPac = new fm_editarPac(pacId);
            fmEditarPac.ShowDialog();
        }

        private void cb_paciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
