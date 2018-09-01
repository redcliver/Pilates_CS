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
    public partial class fm_visualizar : Form
    {
        public fm_visualizar()
        {
            InitializeComponent();
           
        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fm_visualizar_Load(object sender, EventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_buscar_Click(object sender, EventArgs e)
        {
            DateTime theDate = dt_data.Value;
            string theDatestr = theDate.ToString("yyyy-MM-dd");
            DateTime data_final = DateTime.Parse(theDatestr);
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd = igor3355";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            string query = "SELECT hora, pac, prof FROM agenda WHERE data=@da ORDER BY hora";
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("da", data_final);
            NpgsqlDataReader reader;

            reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("hora", typeof(string));
            dt.Columns.Add("pac", typeof(string));
            dt.Load(reader);

            dg_agenda.DataSource = dt;

            conn.Close();
        }
    }
}
