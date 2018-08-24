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
    public partial class fm_novoPlano : Form
    {
        public fm_novoPlano()
        {
            InitializeComponent();
            cb_periodo.Items.Add("Avulso");
            cb_periodo.Items.Add("Mensal");
            cb_periodo.Items.Add("Trimestral");
            cb_periodo.SelectedItem = "Avulso";
            cb_nPessoas.Items.Add("1");
            cb_nPessoas.Items.Add("2");
            cb_nPessoas.SelectedItem = "1";

        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_novoPlano_Load(object sender, EventArgs e)
        {

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string per = cb_periodo.Text;
            double valor = Convert.ToDouble(tb_valor.Text);
            int nPes = Int32.Parse(cb_nPessoas.Text);
            DateTime agora = DateTime.Now;
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string query = "INSERT INTO plano (nome, periodo, valor, npessoas, data_cadastro) VALUES (@n, @p, @v, @np, @d)";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("p", per);
            cmd.Parameters.AddWithValue("v", valor);
            cmd.Parameters.AddWithValue("np", nPes);
            cmd.Parameters.AddWithValue("d", agora);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
