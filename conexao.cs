using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Pilates_CS
{
    class conexao
    {
        public NpgsqlConnection con = new NpgsqlConnection();

        public void conectar() {
            con.ConnectionString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            con.Open();
        }

        public void desconectar()
        {
            con.Close();
        }
    }
}
