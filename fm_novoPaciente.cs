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
    public partial class fm_novoPaciente : Form
    {
        public fm_novoPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string tel = tb_tel.Text;
            string cel = tb_cel.Text;
            DateTime data = dp_data_nasc.Value;
            DateTime agora = DateTime.Now;
            string que = tb_queixa.Text;
            string obj = tb_objetivo.Text;
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string query = "INSERT INTO paciente (nome, telefone, celular, data_nasc, data_cadastro, queixa, objetivo) VALUES (@n, @t, @c, @d, @dc, @q, @o)";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("t", tel);
            cmd.Parameters.AddWithValue("c", cel);
            cmd.Parameters.AddWithValue("d", data);
            cmd.Parameters.AddWithValue("dc", agora);
            cmd.Parameters.AddWithValue("q", que);
            cmd.Parameters.AddWithValue("o", obj);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();

        }

        private void fm_novoPaciente_Load(object sender, EventArgs e)
        {

        }
    }
}
