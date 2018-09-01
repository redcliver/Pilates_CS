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
    public partial class fm_add_agenda : Form
    {
        public fm_add_agenda()
        {
            InitializeComponent();
        }

        private void fm_add_agenda_Load(object sender, EventArgs e)
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
            string query1 = "SELECT * FROM profissional ORDER BY nome";
            conn.Open();
            NpgsqlCommand cmd1 = new NpgsqlCommand(query1, conn);
            NpgsqlDataReader reader1;

            reader1 = cmd1.ExecuteReader();
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("prof_id", typeof(int));
            dt1.Columns.Add("nome", typeof(string));
            dt1.Load(reader1);

            cb_prof.ValueMember = "prof_id";
            cb_prof.DisplayMember = "nome";
            cb_prof.DataSource = dt1;

            conn.Close();
            
            cb_horario.Items.Add("07:00");
            cb_horario.Items.Add("08:00");
            cb_horario.Items.Add("09:00");
            cb_horario.Items.Add("10:00");
            cb_horario.Items.Add("11:00");
            cb_horario.Items.Add("--:--");
            cb_horario.Items.Add("15:00");
            cb_horario.Items.Add("16:00");
            cb_horario.Items.Add("17:00");
            cb_horario.Items.Add("18:00");
            cb_horario.Items.Add("19:00");
            cb_horario.Items.Add("20:00");
            cb_horario.SelectedItem = "07:00";

            cb_plano.Items.Add("Avulso");
            cb_plano.Items.Add("Mensal");
            cb_plano.Items.Add("Trimesrtal");
            cb_plano.Items.Add("Experimental");
            cb_plano.SelectedItem = "Avulso";
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_paciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            int pacId = 0;
            Int32.TryParse(cb_paciente.SelectedValue.ToString(), out pacId);
            int profId = 0;
            Int32.TryParse(cb_prof.SelectedValue.ToString(), out profId);
            string data = mc_data.SelectionRange.Start.ToShortDateString();
            string hora = cb_horario.SelectedItem.ToString();
            string plano = cb_plano.SelectedItem.ToString();
            string data_hora = data + " " + hora;
            DateTime myDate;
            DateTime.TryParse(data_hora, out myDate);
            DateTime today = DateTime.Today;
            var myDate1 = myDate.AddDays(7);
            var myDate2 = myDate.AddDays(14);
            var myDate3 = myDate.AddDays(21);
            var myDate4 = myDate.AddDays(28);
            var myDate5 = myDate.AddDays(35);
            var myDate6 = myDate.AddDays(42);
            var myDate7 = myDate.AddDays(49);
            var myDate8 = myDate.AddDays(56);
            var myDate9 = myDate.AddDays(63);
            var myDate10 = myDate.AddDays(70);
            var myDate11 = myDate.AddDays(77);

            if (plano == "Experimental")
            {
                string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
                string query = "INSERT INTO agenda (pac, prof, data, hora, presenca) VALUES ((SELECT nome FROM paciente WHERE paciente_id = @paid),(SELECT nome FROM profissional WHERE prof_id = @poid), @data, @hora, @pre)";
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("paid", pacId);
                cmd.Parameters.AddWithValue("poid", profId);
                cmd.Parameters.AddWithValue("data", myDate);
                cmd.Parameters.AddWithValue("hora", hora);
                cmd.Parameters.AddWithValue("pre", "nao");
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }

            if (plano == "Avulso"){
                string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
                string query = "INSERT INTO agenda (pac, prof, data, hora, presenca) VALUES ((SELECT nome FROM paciente WHERE paciente_id = @paid),(SELECT nome FROM profissional WHERE prof_id = @poid), @data, @hora, @pre)";
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("paid", pacId);
                cmd.Parameters.AddWithValue("poid", profId);
                cmd.Parameters.AddWithValue("data", myDate);
                cmd.Parameters.AddWithValue("hora", hora);
                cmd.Parameters.AddWithValue("pre", "nao");
                cmd.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }

            if (plano == "Mensal")
            {
                string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
                string query = "INSERT INTO agenda (pac, prof, data, hora, presenca) VALUES ((SELECT nome FROM paciente WHERE paciente_id = @paid),(SELECT nome FROM profissional WHERE prof_id = @poid), @data, @hora, @pre)";
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("paid", pacId);
                cmd.Parameters.AddWithValue("poid", profId);
                cmd.Parameters.AddWithValue("data", myDate);
                cmd.Parameters.AddWithValue("hora", hora);
                cmd.Parameters.AddWithValue("pre", "nao");
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd1 = new NpgsqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = query;
                cmd1.Parameters.AddWithValue("paid", pacId);
                cmd1.Parameters.AddWithValue("poid", profId);
                cmd1.Parameters.AddWithValue("data", myDate1);
                cmd1.Parameters.AddWithValue("hora", hora);
                cmd1.Parameters.AddWithValue("pre", "nao");
                cmd1.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd2 = new NpgsqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = query;
                cmd2.Parameters.AddWithValue("paid", pacId);
                cmd2.Parameters.AddWithValue("poid", profId);
                cmd2.Parameters.AddWithValue("data", myDate2);
                cmd2.Parameters.AddWithValue("hora", hora);
                cmd2.Parameters.AddWithValue("pre", "nao");
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd3 = new NpgsqlCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = query;
                cmd3.Parameters.AddWithValue("paid", pacId);
                cmd3.Parameters.AddWithValue("poid", profId);
                cmd3.Parameters.AddWithValue("data", myDate3);
                cmd3.Parameters.AddWithValue("hora", hora);
                cmd3.Parameters.AddWithValue("pre", "nao");
                cmd3.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }

            if (plano == "Trimestral")
            {
                string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
                string query = "INSERT INTO agenda (pac, prof, data, hora, presenca) VALUES ((SELECT nome FROM paciente WHERE paciente_id = @paid),(SELECT nome FROM profissional WHERE prof_id = @poid), @data, @hora, @pre)";
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("paid", pacId);
                cmd.Parameters.AddWithValue("poid", profId);
                cmd.Parameters.AddWithValue("data", myDate);
                cmd.Parameters.AddWithValue("hora", hora);
                cmd.Parameters.AddWithValue("pre", "nao");
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd1 = new NpgsqlCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = query;
                cmd1.Parameters.AddWithValue("paid", pacId);
                cmd1.Parameters.AddWithValue("poid", profId);
                cmd1.Parameters.AddWithValue("data", myDate1);
                cmd1.Parameters.AddWithValue("hora", hora);
                cmd1.Parameters.AddWithValue("pre", "nao");
                cmd1.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd2 = new NpgsqlCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = query;
                cmd2.Parameters.AddWithValue("paid", pacId);
                cmd2.Parameters.AddWithValue("poid", profId);
                cmd2.Parameters.AddWithValue("data", myDate2);
                cmd2.Parameters.AddWithValue("hora", hora);
                cmd2.Parameters.AddWithValue("pre", "nao");
                cmd2.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd3 = new NpgsqlCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = query;
                cmd3.Parameters.AddWithValue("paid", pacId);
                cmd3.Parameters.AddWithValue("poid", profId);
                cmd3.Parameters.AddWithValue("data", myDate3);
                cmd3.Parameters.AddWithValue("hora", hora);
                cmd3.Parameters.AddWithValue("pre", "nao");
                cmd3.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd4 = new NpgsqlCommand();
                cmd4.Connection = conn;
                cmd4.CommandText = query;
                cmd4.Parameters.AddWithValue("paid", pacId);
                cmd4.Parameters.AddWithValue("poid", profId);
                cmd4.Parameters.AddWithValue("data", myDate4);
                cmd4.Parameters.AddWithValue("hora", hora);
                cmd4.Parameters.AddWithValue("pre", "nao");
                cmd4.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd5 = new NpgsqlCommand();
                cmd5.Connection = conn;
                cmd5.CommandText = query;
                cmd5.Parameters.AddWithValue("paid", pacId);
                cmd5.Parameters.AddWithValue("poid", profId);
                cmd5.Parameters.AddWithValue("data", myDate5);
                cmd5.Parameters.AddWithValue("hora", hora);
                cmd5.Parameters.AddWithValue("pre", "nao");
                cmd5.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd6 = new NpgsqlCommand();
                cmd6.Connection = conn;
                cmd6.CommandText = query;
                cmd6.Parameters.AddWithValue("paid", pacId);
                cmd6.Parameters.AddWithValue("poid", profId);
                cmd6.Parameters.AddWithValue("data", myDate6);
                cmd6.Parameters.AddWithValue("hora", hora);
                cmd6.Parameters.AddWithValue("pre", "nao");
                cmd6.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd7 = new NpgsqlCommand();
                cmd7.Connection = conn;
                cmd7.CommandText = query;
                cmd7.Parameters.AddWithValue("paid", pacId);
                cmd7.Parameters.AddWithValue("poid", profId);
                cmd7.Parameters.AddWithValue("data", myDate7);
                cmd7.Parameters.AddWithValue("hora", hora);
                cmd7.Parameters.AddWithValue("pre", "nao");
                cmd7.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd8 = new NpgsqlCommand();
                cmd8.Connection = conn;
                cmd8.CommandText = query;
                cmd8.Parameters.AddWithValue("paid", pacId);
                cmd8.Parameters.AddWithValue("poid", profId);
                cmd8.Parameters.AddWithValue("data", myDate8);
                cmd8.Parameters.AddWithValue("hora", hora);
                cmd8.Parameters.AddWithValue("pre", "nao");
                cmd8.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd9 = new NpgsqlCommand();
                cmd9.Connection = conn;
                cmd9.CommandText = query;
                cmd9.Parameters.AddWithValue("paid", pacId);
                cmd9.Parameters.AddWithValue("poid", profId);
                cmd9.Parameters.AddWithValue("data", myDate9);
                cmd9.Parameters.AddWithValue("hora", hora);
                cmd9.Parameters.AddWithValue("pre", "nao");
                cmd9.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd10 = new NpgsqlCommand();
                cmd10.Connection = conn;
                cmd10.CommandText = query;
                cmd10.Parameters.AddWithValue("paid", pacId);
                cmd10.Parameters.AddWithValue("poid", profId);
                cmd10.Parameters.AddWithValue("data", myDate10);
                cmd10.Parameters.AddWithValue("hora", hora);
                cmd10.Parameters.AddWithValue("pre", "nao");
                cmd10.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                NpgsqlCommand cmd11 = new NpgsqlCommand();
                cmd11.Connection = conn;
                cmd11.CommandText = query;
                cmd11.Parameters.AddWithValue("paid", pacId);
                cmd11.Parameters.AddWithValue("poid", profId);
                cmd11.Parameters.AddWithValue("data", myDate11);
                cmd11.Parameters.AddWithValue("hora", hora);
                cmd11.Parameters.AddWithValue("pre", "nao");
                cmd11.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }

        }
    }
}
