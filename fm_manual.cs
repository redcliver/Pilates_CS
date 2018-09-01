using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Pilates_CS
{
    public partial class fm_manual : Form
    {
        public fm_manual()
        {
            InitializeComponent();
        }

        private void fm_manual_Load(object sender, EventArgs e)
        {
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "SELECT * FROM paciente ORDER BY nome";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("nome", typeof(string));
            dt.Load(reader);

            cb_paciente.ValueMember = "nome";
            cb_paciente.DisplayMember = "nome";
            cb_paciente.DataSource = dt;

            conn.Close();
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            string pac_nome = cb_paciente.GetItemText(cb_paciente.SelectedItem);
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "SELECT * FROM agenda WHERE pac=@pc AND presenca=@pr ORDER BY data";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;
            cmd.Parameters.AddWithValue("pc", pac_nome);
            cmd.Parameters.AddWithValue("pr", "nao");
            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("hora", typeof(string));
            dt.Load(reader);
            cb_paciente.Enabled = false;
            bt_buscar.Visible = false;
            bt_presenca.Visible = true;
            cb_agenda.Visible = true;
            lb_aulas.Visible = true;
            bt_presenca.Enabled = true;
            cb_agenda.Enabled = true;
            cb_agenda.ValueMember = "id";
            cb_agenda.DisplayMember = ("hora");
            cb_agenda.DataSource = dt;
            
            conn.Close();
        }

        private void bt_presenca_Click(object sender, EventArgs e)
        {
            string pac_nome = cb_paciente.GetItemText(cb_paciente.SelectedItem);
            string ag_id = cb_agenda.SelectedValue.ToString();
            string hr = cb_agenda.GetItemText(cb_agenda.SelectedItem);
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "UPDATE agenda SET \"presenca\"=:pre WHERE id=" + ag_id;
            
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            string query1 = "SELECT * FROM paciente WHERE nome=@pnome";
            NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("pnome", pac_nome);
            NpgsqlDataReader dr = cmd1.ExecuteReader();
            dr.Read();
            string n_aulas = (dr["aulas"].ToString());
            string pId = (dr["paciente_id"].ToString());
            conn.Close();
            int nAulas = 0;
            Int32.TryParse(n_aulas, out nAulas);
            if (nAulas >= 1)
            {
                int prese = nAulas - 1;
                conn.Open();
                string query2 = "UPDATE paciente SET \"aulas\"=:preAtual WHERE \"paciente_id\"= "+ pId;
                NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
                cmd2.Parameters.Add(new NpgsqlParameter("preAtual", NpgsqlTypes.NpgsqlDbType.Integer));
                cmd2.Parameters[0].Value = prese;
                cmd2.ExecuteNonQuery();
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                cmd.Parameters.Add(new NpgsqlParameter("pre", NpgsqlTypes.NpgsqlDbType.Text));
                cmd.Parameters[0].Value = "sim";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Presença registrada om sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            else {
                MessageBox.Show("Ops, favor verificar se o aluno tem aulas disponíveis.", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.Close();
        }
    }
}
