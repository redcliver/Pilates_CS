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
    public partial class fm_pag_final : Form
    {
        public fm_pag_final(string id)
        {
            InitializeComponent();
            int contId = Int32.Parse(id);
            string query = "SELECT * FROM conta WHERE conta_id=@idCont ";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexao.conn);
            cmd.Parameters.AddWithValue("@idCont", contId);
            cmd.Parameters.AddWithValue("@est", "aberto");
            NpgsqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            DateTime data;
            lb_id.Text = (dr["conta_id"].ToString());
            string dt = (dr["data_venc"].ToString());
            lb_valor.Text = (dr["valor"].ToString());
            tb_nome.Text = (dr["nome"].ToString());
            DateTime.TryParse(dt, out data);
            lb_data_venc.Text = data.ToString("dd/MM/yyyy");
            conexao.desconectar();

        }
        private void fm_pag_final_Load(object sender, EventArgs e)
        {

        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            string contaId = lb_id.Text;
            string val = lb_valor.Text;
            string dt = lb_data_venc.Text;
            int valor = 0;
            int total = 0;
            Int32.TryParse(val, out valor);
            int contId = Int32.Parse(lb_id.Text);
            string query = "UPDATE conta SET estado=@est WHERE conta_id=@idCont";
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@idCont", contId);
            cmd.Parameters.AddWithValue("@est", "paga");
            cmd.ExecuteNonQuery();
            conn.Close();
            string query1 = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
            conn.Open();
            NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
            NpgsqlDataReader dr = cmd1.ExecuteReader();
            dr.Read();
            string tot = (dr["total"].ToString());
            conn.Close();
            Int32.TryParse(tot, out total);
            int total_final = total - valor;
            DateTime agora = DateTime.Now;
            string query2 = "INSERT INTO caixa_geral (tipo, descricao, data, total, valor, metodo) VALUES (@ti, @de, @da, @to, @va, @me)";
            conn.Open();
            NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("ti", "Saida");
            cmd2.Parameters.AddWithValue("de", "Pagamento -" + tb_nome.Text + " - R$" + valor);
            cmd2.Parameters.AddWithValue("da", agora);
            cmd2.Parameters.AddWithValue("to", total_final);
            cmd2.Parameters.AddWithValue("va", valor);
            cmd2.Parameters.AddWithValue("me", "Dinheiro");
            cmd2.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
    
}
