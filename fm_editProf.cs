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
    public partial class fm_editProf : Form
    {
        public fm_editProf()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_editProf_Load(object sender, EventArgs e)
        {
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "SELECT * FROM profissional ORDER BY nome";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("prof_id", typeof(int));
            dt.Columns.Add("nome", typeof(string));
            dt.Load(reader);

            cb_prof.ValueMember = "prof_id";
            cb_prof.DisplayMember = "nome";
            cb_prof.DataSource = dt;

            conn.Close();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            this.Hide();
            string proId = cb_prof.SelectedValue.ToString();
            fm_editarProf fmEditarPro = new fm_editarProf(proId);
            fmEditarPro.ShowDialog();
        }
    }
}
