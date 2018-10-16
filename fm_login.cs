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
    public partial class fm_login : Form
    {
        public fm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string query = "SELECT * FROM usuario WHERE usuario=@usuario AND senha=@senha";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@usuario", tb_usuario.Text);
            cmd.Parameters.AddWithValue("@senha", tb_senha.Text);

            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read()) {
                autenticacao.login(dr["usuario"].ToString(), dr["senha"].ToString());
                this.Hide();
                new fm_principal().Show();
            }
            else
            {
                MessageBox.Show("Ops! Usuário / Senha incorreto!", "Erro no login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conn.Close();
        }

        private void fm_login_Load(object sender, EventArgs e)
        {
            tb_usuario.Select();
            this.AcceptButton = bt_login;
        }
    }
}
