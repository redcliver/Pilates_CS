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
    public partial class fm_novaConta : Form
    {
        public fm_novaConta()
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
            decimal valor = Convert.ToDecimal(tb_valor.Text);
            DateTime data = dp_data.Value;
            DateTime agora = DateTime.Now;
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string query = "INSERT INTO conta (nome, data_venc, data_cadastro, valor) VALUES (@n, @dv, @dc, @v)";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("dv", data);
            cmd.Parameters.AddWithValue("dc", agora);
            cmd.Parameters.AddWithValue("v", valor);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
