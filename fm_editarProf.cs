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
    public partial class fm_editarProf : Form
    {
        public fm_editarProf(string id)
        {
            InitializeComponent();
            int proId = Int32.Parse(id);
            string query = "SELECT * FROM profissional WHERE prof_id=@idPro";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexao.con);
            cmd.Parameters.AddWithValue("@idPro", proId);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lb_id.Text = (dr["prof_id"].ToString());
                tb_nome.Text = (dr["nome"].ToString());
                tb_tel.Text = (dr["telefone"].ToString());
                tb_cel.Text = (dr["celular"].ToString());
            }
            else
            {
                MessageBox.Show("Ops! Algo deu errado, favor entrar em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conexao.desconectar();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_editarProf_Load(object sender, EventArgs e)
        {

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string tel1 = tb_tel.Text;
            string cel1 = tb_cel.Text;
            Int32.TryParse(tel1, out int tel);
            Int32.TryParse(cel1, out int cel);
            int proid = Int32.Parse(lb_id.Text);
            string query = "UPDATE profissional SET nome=@n, telefone=@t, celular=@c WHERE prof_id=@idPro";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conexao.con;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("idPro", proid);
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("t", tel);
            cmd.Parameters.AddWithValue("c", cel);
            cmd.ExecuteNonQuery();
            conexao.desconectar();
            this.Close();
        }
    }
}
