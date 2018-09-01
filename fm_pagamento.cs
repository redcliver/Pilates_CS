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
    public partial class fm_pagamento : Form
    {
        public fm_pagamento()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_pagamento_Load(object sender, EventArgs e)
        {
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            string query = "SELECT * FROM paciente ORDER BY nome";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("paciente_id", typeof(int));
            dt.Columns.Add("nome", typeof(string));
            dt.Load(reader);

            cb_paciente.ValueMember = "paciente_id";
            cb_paciente.DisplayMember = "nome";
            cb_paciente.DataSource = dt;

            conn.Close();

            cb_plano.Items.Add("Avulso");
            cb_plano.Items.Add("Mensal");
            cb_plano.Items.Add("Trimesrtal");
            cb_plano.SelectedItem = "Avulso";

            rb_individual.Select();
            rb_dinheiro.Select();
        }

        private void bt_pagamento_Click(object sender, EventArgs e)
        {
            bool ind = rb_individual.Checked;
            bool dup = rb_dupla.Checked;
            bool din = rb_dinheiro.Checked;
            bool cre = rb_credito.Checked;
            bool deb = rb_debito.Checked;
            string pla = cb_plano.SelectedItem.ToString();
            string pacId = cb_paciente.SelectedValue.ToString();
            if (ind)
            {
                if (pla == "Avulso")
                {
                    int pessoas = 1;
                    string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
                    string query = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
                    string query2 = "SELECT * FROM plano WHERE periodo=@peri AND npessoas=@np";
                    NpgsqlConnection conn = new NpgsqlConnection(connString);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string total = (dr["total"].ToString());
                    conn.Close();
                    conn.Open();
                    NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@np", pessoas);
                    cmd2.Parameters.AddWithValue("@peri", pla);
                    NpgsqlDataReader dr1 = cmd2.ExecuteReader();
                    dr1.Read();
                    int val = 0;
                    string val1 = (dr1["valor"].ToString());
                    Int32.TryParse(val1, out val);
                    string pac = cb_paciente.GetItemText(cb_paciente.SelectedItem);
                    int tot = 0;
                    string met = "";
                    Int32.TryParse(total, out tot);
                    int tot_final = tot + val;
                    string tip = "Entrada";
                    DateTime agora = DateTime.Now;
                    string des = "Pagamento - " + pac + " - " + pla;
                    if (din)
                    {
                        met = "Dinheiro";
                    }
                    if (deb)
                    {
                        met = "Debito";
                    }
                    if (cre)
                    {
                        met = "Credito";
                    }
                    conn.Close();
                    string query1 = "INSERT INTO caixa_geral (tipo, descricao, data, total, valor, metodo) VALUES (@ti, @de, @da, @to, @va, @me)";
                    conn.Open();
                    NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("ti", tip);
                    cmd1.Parameters.AddWithValue("de", des);
                    cmd1.Parameters.AddWithValue("da", agora);
                    cmd1.Parameters.AddWithValue("to", tot_final);
                    cmd1.Parameters.AddWithValue("va", val);
                    cmd1.Parameters.AddWithValue("me", met);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    string query3 = "SELECT * FROM paciente WHERE paciente_id=@idPac";
                    conn.Open();
                    int pId = 0;
                    Int32.TryParse(pacId, out pId);
                    NpgsqlCommand cmd3 = new NpgsqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@idPac", pId);
                    NpgsqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();
                    string au = (dr3["aulas"].ToString());
                    int total_aulas = 0;
                    Int32.TryParse(au, out total_aulas);
                    conn.Close();
                    int tAulas = total_aulas + 1;
                    string query4 = "UPDATE paciente SET aulas=@au WHERE paciente_id=@idPac";
                    conn.Open();
                    NpgsqlCommand cmd4 = new NpgsqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@idPac", pId);
                    cmd4.Parameters.AddWithValue("@au", tAulas);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (pla == "Mensal")
                {
                    int pessoas = 1;
                    string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
                    string query = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
                    string query2 = "SELECT * FROM plano WHERE periodo=@peri AND npessoas=@np";
                    NpgsqlConnection conn = new NpgsqlConnection(connString);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string total = (dr["total"].ToString());
                    conn.Close();
                    conn.Open();
                    NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@np", pessoas);
                    cmd2.Parameters.AddWithValue("@peri", pla);
                    NpgsqlDataReader dr1 = cmd2.ExecuteReader();
                    dr1.Read();
                    int val = 0;
                    string val1 = (dr1["valor"].ToString());
                    Int32.TryParse(val1, out val);
                    string pac = cb_paciente.GetItemText(cb_paciente.SelectedItem);
                    int tot = 0;
                    string met = "";
                    Int32.TryParse(total, out tot);
                    int tot_final = tot + val;
                    string tip = "Entrada";
                    DateTime agora = DateTime.Now;
                    string des = "Pagamento - " + pac + " - " + pla;
                    if (din)
                    {
                        met = "Dinheiro";
                    }
                    if (deb)
                    {
                        met = "Debito";
                    }
                    if (cre)
                    {
                        met = "Credito";
                    }
                    conn.Close();
                    string query1 = "INSERT INTO caixa_geral (tipo, descricao, data, total, valor, metodo) VALUES (@ti, @de, @da, @to, @va, @me)";
                    conn.Open();
                    NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("ti", tip);
                    cmd1.Parameters.AddWithValue("de", des);
                    cmd1.Parameters.AddWithValue("da", agora);
                    cmd1.Parameters.AddWithValue("to", tot_final);
                    cmd1.Parameters.AddWithValue("va", val);
                    cmd1.Parameters.AddWithValue("me", met);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    string query3 = "SELECT * FROM paciente WHERE paciente_id=@idPac";
                    conn.Open();
                    int pId = 0;
                    Int32.TryParse(pacId, out pId);
                    NpgsqlCommand cmd3 = new NpgsqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@idPac", pId);
                    NpgsqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();
                    string au = (dr3["aulas"].ToString());
                    int total_aulas = 0;
                    Int32.TryParse(au, out total_aulas);
                    conn.Close();
                    int tAulas = total_aulas + 4;
                    string query4 = "UPDATE paciente SET aulas=@au WHERE paciente_id=@idPac";
                    conn.Open();
                    NpgsqlCommand cmd4 = new NpgsqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@idPac", pId);
                    cmd4.Parameters.AddWithValue("@au", tAulas);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (pla == "Trimestral")
                {
                    int pessoas = 1;
                    string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
                    string query = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
                    string query2 = "SELECT * FROM plano WHERE periodo=@peri AND npessoas=@np";
                    NpgsqlConnection conn = new NpgsqlConnection(connString);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string total = (dr["total"].ToString());
                    conn.Close();
                    conn.Open();
                    NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@np", pessoas);
                    cmd2.Parameters.AddWithValue("@peri", pla);
                    NpgsqlDataReader dr1 = cmd2.ExecuteReader();
                    dr1.Read();
                    int val = 0;
                    string val1 = (dr1["valor"].ToString());
                    Int32.TryParse(val1, out val);
                    string pac = cb_paciente.GetItemText(cb_paciente.SelectedItem);
                    int tot = 0;
                    string met = "";
                    Int32.TryParse(total, out tot);
                    int tot_final = tot + val;
                    string tip = "Entrada";
                    DateTime agora = DateTime.Now;
                    string des = "Pagamento - " + pac + " - " + pla;
                    if (din)
                    {
                        met = "Dinheiro";
                    }
                    if (deb)
                    {
                        met = "Debito";
                    }
                    if (cre)
                    {
                        met = "Credito";
                    }
                    conn.Close();
                    string query1 = "INSERT INTO caixa_geral (tipo, descricao, data, total, valor, metodo) VALUES (@ti, @de, @da, @to, @va, @me)";
                    conn.Open();
                    NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("ti", tip);
                    cmd1.Parameters.AddWithValue("de", des);
                    cmd1.Parameters.AddWithValue("da", agora);
                    cmd1.Parameters.AddWithValue("to", tot_final);
                    cmd1.Parameters.AddWithValue("va", val);
                    cmd1.Parameters.AddWithValue("me", met);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    string query3 = "SELECT * FROM paciente WHERE paciente_id=@idPac";
                    conn.Open();
                    int pId = 0;
                    Int32.TryParse(pacId, out pId);
                    NpgsqlCommand cmd3 = new NpgsqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@idPac", pId);
                    NpgsqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();
                    string au = (dr3["aulas"].ToString());
                    int total_aulas = 0;
                    Int32.TryParse(au, out total_aulas);
                    conn.Close();
                    int tAulas = total_aulas + 12;
                    string query4 = "UPDATE paciente SET aulas=@au WHERE paciente_id=@idPac";
                    conn.Open();
                    NpgsqlCommand cmd4 = new NpgsqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@idPac", pId);
                    cmd4.Parameters.AddWithValue("@au", tAulas);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            if (dup)
            {
                if (pla == "Avulso")
                {
                    int pessoas = 2;
                    string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
                    string query = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
                    string query2 = "SELECT * FROM plano WHERE periodo=@peri AND npessoas=@np";
                    NpgsqlConnection conn = new NpgsqlConnection(connString);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string total = (dr["total"].ToString());
                    conn.Close();
                    conn.Open();
                    NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@np", pessoas);
                    cmd2.Parameters.AddWithValue("@peri", pla);
                    NpgsqlDataReader dr1 = cmd2.ExecuteReader();
                    dr1.Read();
                    int val = 0;
                    string val1 = (dr1["valor"].ToString());
                    Int32.TryParse(val1, out val);
                    string pac = cb_paciente.GetItemText(cb_paciente.SelectedItem);
                    int tot = 0;
                    string met = "";
                    Int32.TryParse(total, out tot);
                    int tot_final = tot + val;
                    string tip = "Entrada";
                    DateTime agora = DateTime.Now;
                    string des = "Pagamento - " + pac + " - " + pla;
                    if (din)
                    {
                        met = "Dinheiro";
                    }
                    if (deb)
                    {
                        met = "Debito";
                    }
                    if (cre)
                    {
                        met = "Credito";
                    }
                    conn.Close();
                    string query1 = "INSERT INTO caixa_geral (tipo, descricao, data, total, valor, metodo) VALUES (@ti, @de, @da, @to, @va, @me)";
                    conn.Open();
                    NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("ti", tip);
                    cmd1.Parameters.AddWithValue("de", des);
                    cmd1.Parameters.AddWithValue("da", agora);
                    cmd1.Parameters.AddWithValue("to", tot_final);
                    cmd1.Parameters.AddWithValue("va", val);
                    cmd1.Parameters.AddWithValue("me", met);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    string query3 = "SELECT * FROM paciente WHERE paciente_id=@idPac";
                    conn.Open();
                    int pId = 0;
                    Int32.TryParse(pacId, out pId);
                    NpgsqlCommand cmd3 = new NpgsqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@idPac", pId);
                    NpgsqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();
                    string au = (dr3["aulas"].ToString());
                    int total_aulas = 0;
                    Int32.TryParse(au, out total_aulas);
                    conn.Close();
                    int tAulas = total_aulas + 1;
                    string query4 = "UPDATE paciente SET aulas=@au WHERE paciente_id=@idPac";
                    conn.Open();
                    NpgsqlCommand cmd4 = new NpgsqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@idPac", pId);
                    cmd4.Parameters.AddWithValue("@au", tAulas);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (pla == "Mensal")
                {
                    int pessoas = 2;
                    string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
                    string query = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
                    string query2 = "SELECT * FROM plano WHERE periodo=@peri AND npessoas=@np";
                    NpgsqlConnection conn = new NpgsqlConnection(connString);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string total = (dr["total"].ToString());
                    conn.Close();
                    conn.Open();
                    NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@np", pessoas);
                    cmd2.Parameters.AddWithValue("@peri", pla);
                    NpgsqlDataReader dr1 = cmd2.ExecuteReader();
                    dr1.Read();
                    int val = 0;
                    string val1 = (dr1["valor"].ToString());
                    Int32.TryParse(val1, out val);
                    string pac = cb_paciente.GetItemText(cb_paciente.SelectedItem);
                    int tot = 0;
                    string met = "";
                    Int32.TryParse(total, out tot);
                    int tot_final = tot + val;
                    string tip = "Entrada";
                    DateTime agora = DateTime.Now;
                    string des = "Pagamento - " + pac + " - " + pla;
                    if (din)
                    {
                        met = "Dinheiro";
                    }
                    if (deb)
                    {
                        met = "Debito";
                    }
                    if (cre)
                    {
                        met = "Credito";
                    }
                    conn.Close();
                    string query1 = "INSERT INTO caixa_geral (tipo, descricao, data, total, valor, metodo) VALUES (@ti, @de, @da, @to, @va, @me)";
                    conn.Open();
                    NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("ti", tip);
                    cmd1.Parameters.AddWithValue("de", des);
                    cmd1.Parameters.AddWithValue("da", agora);
                    cmd1.Parameters.AddWithValue("to", tot_final);
                    cmd1.Parameters.AddWithValue("va", val);
                    cmd1.Parameters.AddWithValue("me", met);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    string query3 = "SELECT * FROM paciente WHERE paciente_id=@idPac";
                    conn.Open();
                    int pId = 0;
                    Int32.TryParse(pacId, out pId);
                    NpgsqlCommand cmd3 = new NpgsqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@idPac", pId);
                    NpgsqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();
                    string au = (dr3["aulas"].ToString());
                    int total_aulas = 0;
                    Int32.TryParse(au, out total_aulas);
                    conn.Close();
                    int tAulas = total_aulas + 4;
                    string query4 = "UPDATE paciente SET aulas=@au WHERE paciente_id=@idPac";
                    conn.Open();
                    NpgsqlCommand cmd4 = new NpgsqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@idPac", pId);
                    cmd4.Parameters.AddWithValue("@au", tAulas);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                if (pla == "Trimestral")
                {
                    int pessoas = 2;
                    string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
                    string query = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
                    string query2 = "SELECT * FROM plano WHERE periodo=@peri AND npessoas=@np";
                    NpgsqlConnection conn = new NpgsqlConnection(connString);
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                    NpgsqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string total = (dr["total"].ToString());
                    conn.Close();
                    conn.Open();
                    NpgsqlCommand cmd2 = new NpgsqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@np", pessoas);
                    cmd2.Parameters.AddWithValue("@peri", pla);
                    NpgsqlDataReader dr1 = cmd2.ExecuteReader();
                    dr1.Read();
                    int val = 0;
                    string val1 = (dr1["valor"].ToString());
                    Int32.TryParse(val1, out val);
                    string pac = cb_paciente.GetItemText(cb_paciente.SelectedItem);
                    int tot = 0;
                    string met = "";
                    Int32.TryParse(total, out tot);
                    int tot_final = tot + val;
                    string tip = "Entrada";
                    DateTime agora = DateTime.Now;
                    string des = "Pagamento - " + pac + " - " + pla;
                    if (din)
                    {
                        met = "Dinheiro";
                    }
                    if (deb)
                    {
                        met = "Debito";
                    }
                    if (cre)
                    {
                        met = "Credito";
                    }
                    conn.Close();
                    string query1 = "INSERT INTO caixa_geral (tipo, descricao, data, total, valor, metodo) VALUES (@ti, @de, @da, @to, @va, @me)";
                    conn.Open();
                    NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("ti", tip);
                    cmd1.Parameters.AddWithValue("de", des);
                    cmd1.Parameters.AddWithValue("da", agora);
                    cmd1.Parameters.AddWithValue("to", tot_final);
                    cmd1.Parameters.AddWithValue("va", val);
                    cmd1.Parameters.AddWithValue("me", met);
                    cmd1.ExecuteNonQuery();
                    conn.Close();
                    string query3 = "SELECT * FROM paciente WHERE paciente_id=@idPac";
                    conn.Open();
                    int pId = 0;
                    Int32.TryParse(pacId, out pId);
                    NpgsqlCommand cmd3 = new NpgsqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("@idPac", pId);
                    NpgsqlDataReader dr3 = cmd3.ExecuteReader();
                    dr3.Read();
                    string au = (dr3["aulas"].ToString());
                    int total_aulas = 0;
                    Int32.TryParse(au, out total_aulas);
                    conn.Close();
                    int tAulas = total_aulas + 12;
                    string query4 = "UPDATE paciente SET aulas=@au WHERE paciente_id=@idPac";
                    conn.Open();
                    NpgsqlCommand cmd4 = new NpgsqlCommand(query4, conn);
                    cmd4.Parameters.AddWithValue("@idPac", pId);
                    cmd4.Parameters.AddWithValue("@au", tAulas);
                    cmd4.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Pagamento registrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Ops, algo saiu errado, favor entrar em contato com o suporte.", "Ops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
