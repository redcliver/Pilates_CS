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
    public partial class fm_novoProf : Form
    {
        public fm_novoProf()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string tel1 = tb_tel.Text;
            string cel1 = tb_cel.Text;
            Int32.TryParse(tel1, out int tel);
            Int32.TryParse(cel1, out int cel);
            DateTime agora = DateTime.Now;
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string query = "INSERT INTO profissional (nome, telefone, celular, data_cadastro) VALUES (@n, @t, @c, @d)";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("t", tel);
            cmd.Parameters.AddWithValue("c", cel);
            cmd.Parameters.AddWithValue("d", agora);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
