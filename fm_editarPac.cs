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
    public partial class fm_editarPac : Form
    {
        public fm_editarPac(string id)
        {
            InitializeComponent();
            int pacId = Int32.Parse(id);
            string query = "SELECT * FROM paciente WHERE paciente_id=@idPac";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexao.con);
            cmd.Parameters.AddWithValue("@idPac", pacId);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                tb_nome.Text = (dr["nome"].ToString());
                tb_tel.Text = (dr["telefone"].ToString());
                tb_cel.Text = (dr["celular"].ToString());
                dp_data_nasc.Text = (dr["data_nasc"].ToString());
                tb_queixa.Text = (dr["queixa"].ToString());
                tb_objetivo.Text = (dr["objetivo"].ToString());
            }
            else
            {
                tb_nome.Text = id;
            }
            
            conexao.desconectar();



        }

        private void fm_editarPac_Load(object sender, EventArgs e)
        {
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }
    }
}
