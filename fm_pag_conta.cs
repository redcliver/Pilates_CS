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
    public partial class fm_pag_conta : Form
    {
        public fm_pag_conta()
        {
            InitializeComponent();
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "SELECT * FROM conta WHERE estado=@est ORDER BY nome";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;
            cmd.Parameters.AddWithValue("@est", "aberto");
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

        private void bt_busca_Click(object sender, EventArgs e)
        {
            this.Hide();
            string contId = cb_conta.SelectedValue.ToString();
            fm_pag_final fmfinal = new fm_pag_final(contId);
            fmfinal.ShowDialog();
        }
    }
}
