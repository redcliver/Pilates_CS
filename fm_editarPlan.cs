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
    public partial class fm_editarPlan : Form
    {
        public fm_editarPlan(string id)
        {
            InitializeComponent();
            int planId = Int32.Parse(id);
            string query = "SELECT * FROM plano WHERE plano_id=@idPlan";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexao.conn);
            cmd.Parameters.AddWithValue("@idPlan", planId);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lb_id.Text = (dr["plano_id"].ToString());
                tb_nome.Text = (dr["nome"].ToString());
                tb_valor.Text = (dr["valor"].ToString());
                cb_periodo.Text = (dr["periodo"].ToString());
                cb_nPessoas.Text = (dr["nPessoas"].ToString());
                cb_nPessoas.Items.Add("1");
                cb_nPessoas.Items.Add("2");
                cb_periodo.Items.Add("Avulso");
                cb_periodo.Items.Add("Mensal");
                cb_periodo.Items.Add("Trimestral");
            }
            else
            {
                MessageBox.Show("Ops! Algo deu errado, favor entrar em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            conexao.desconectar();
        }

        private void fm_editarPlan_Load(object sender, EventArgs e)
        {
            tb_nome.Select();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            string per = cb_periodo.Text;
            double valor = Convert.ToDouble(tb_valor.Text);
            int nPes = Int32.Parse(cb_nPessoas.Text);
            int planid = Int32.Parse(lb_id.Text);
            string query = "UPDATE plano SET nome=@n, periodo=@p, valor=@v, npessoas=@np WHERE plano_id=@idPlan";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conexao.conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("idPlan", planid);
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("p", per);
            cmd.Parameters.AddWithValue("v", valor);
            cmd.Parameters.AddWithValue("np", nPes);
            cmd.ExecuteNonQuery();
            conexao.desconectar();
            this.Close();
        }
    }
}
