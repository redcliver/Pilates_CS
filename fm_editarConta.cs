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
    public partial class fm_editarConta : Form
    {
        public fm_editarConta(string id)
        {
            InitializeComponent();
            int contId = Int32.Parse(id);
            string query = "SELECT * FROM conta WHERE conta_id=@idCont";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexao.conn);
            cmd.Parameters.AddWithValue("@idCont", contId);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lb_id.Text = (dr["conta_id"].ToString());
                tb_nome.Text = (dr["nome"].ToString());
                tb_valor.Text = (dr["valor"].ToString());
                dp_data.Text = (dr["data_venc"].ToString());
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

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            DateTime data = dp_data.Value;
            Decimal valor = Convert.ToDecimal(tb_valor.Text);
            int conid = Int32.Parse(lb_id.Text);
            string query = "UPDATE conta SET nome=@n, data_venc=@dv, valor=@v WHERE conta_id=@idCont";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conexao.conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("idCont", conid);
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("dv", data);
            cmd.Parameters.AddWithValue("v", valor);
            cmd.ExecuteNonQuery();
            conexao.desconectar();
            this.Close();
        }

        private void fm_editarConta_Load(object sender, EventArgs e)
        {

        }
    }
}
