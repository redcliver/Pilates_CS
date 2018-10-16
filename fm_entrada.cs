﻿using System;
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
    public partial class fm_entrada : Form
    {
        public fm_entrada()
        {
            InitializeComponent();
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string desc = tb_desc.Text;
            string tip = "Entrada";
            string total_str;
            bool din = rb_dinheiro.Checked;
            bool cre = rb_credito.Checked;
            bool deb = rb_debito.Checked;
            decimal valor = Convert.ToDecimal(tb_valor.Text);
            DateTime agora = DateTime.Now;
            decimal last_caixa;
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string query = "INSERT INTO caixa_geral (tipo, descricao, total, valor, data, metodo) VALUES (@ti, @de, @to, @va, @da, @me)";
            string ultimo = "SELECT * FROM caixa_geral ORDER BY caixa_id DESC LIMIT 1";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd1 = new NpgsqlCommand(ultimo, conn);
            NpgsqlDataReader dr = cmd1.ExecuteReader();
            dr.Read();
            total_str = (dr["total"].ToString());
            last_caixa = Convert.ToDecimal(total_str);
            conn.Close();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            last_caixa = last_caixa + valor;
            cmd.Connection = conn;
            cmd.CommandText = query;
            if (din) {
                cmd.Parameters.AddWithValue("@me", "Dinheiro");
            }
            if (cre)
            {
                cmd.Parameters.AddWithValue("@me", "Credito");
            }
            if (deb)
            {
                cmd.Parameters.AddWithValue("@me", "Debito");
            }
            cmd.Parameters.AddWithValue("@ti", tip);
            cmd.Parameters.AddWithValue("@de", desc);
            cmd.Parameters.AddWithValue("@to", last_caixa);
            cmd.Parameters.AddWithValue("@va", valor);
            cmd.Parameters.AddWithValue("@da", agora);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
        }
    }
}
