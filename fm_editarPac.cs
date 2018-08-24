using System;
using System.IO;
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
                lb_id.Text = (dr["paciente_id"].ToString());
                tb_nome.Text = (dr["nome"].ToString());
                tb_tel.Text = (dr["telefone"].ToString());
                tb_cel.Text = (dr["celular"].ToString());
                dp_data_nasc.Text = (dr["data_nasc"].ToString());
                tb_queixa.Text = (dr["queixa"].ToString());
                tb_objetivo.Text = (dr["objetivo"].ToString());
                try
                {
                    string id_str = (dr["paciente_id"].ToString());
                    int ret = -1;
                    byte[] ImageData = new byte[256 * 288];
                    string ImagePath = "C://teste/" + id_str + ".bmp";
                    ret = biometria.PSImgData2BMP(ImageData, ImagePath);
                    if (ret == 0)
                    {
                        bt_img.BackgroundImage = Image.FromFile("C://teste/" + id_str + ".bmp");
                        bt_img.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao coletar a biometria.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                catch {
                    bt_img.Text = "Sem Imagem";
                }
                
            }
            else
            {
                MessageBox.Show("Ops! Algo deu errado, favor entrar em contato com o suporte.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            conexao.desconectar();



        }
        static IntPtr phandler = IntPtr.Zero;
        static UInt32 nAddr = 0xffffffff;

        private void fm_editarPac_Load(object sender, EventArgs e)
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
            string tel = tb_tel.Text;
            string cel = tb_cel.Text;
            DateTime data = dp_data_nasc.Value;
            string que = tb_queixa.Text;
            string obj = tb_objetivo.Text;
            int pacid = Int32.Parse(lb_id.Text);
            string query = "UPDATE paciente SET nome=@n, telefone=@t, celular=@c, data_nasc=@d, queixa=@q, objetivo=@o  WHERE paciente_id=@idPac";
            conexao conexao = new conexao();
            conexao.conectar();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conexao.con;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("idPac", pacid);
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("t", tel);
            cmd.Parameters.AddWithValue("c", cel);
            cmd.Parameters.AddWithValue("d", data);
            cmd.Parameters.AddWithValue("q", que);
            cmd.Parameters.AddWithValue("o", obj);
            cmd.ExecuteNonQuery();
            conexao.desconectar();
            this.Close();
        }

        private void bt_img_Click(object sender, EventArgs e)
        {
            if (bt_img.Text == "Sem Imagem") {
                string id_str =lb_id.Text;
                string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
                string ultimo = "SELECT * FROM paciente WHERE paciente_id = ";
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(ultimo, conn);
                cmd.Parameters.AddWithValue("@idPac", id_str);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int ret = -1;
                byte[] ImageData = new byte[256 * 288];
                int ImageLength = 0;
                string ImagePath = "C://teste/" + id_str + ".bmp";
                ret = biometria.PSGetImage(phandler, nAddr);
                if (ret == 0)
                {
                    ret = biometria.PSUpImage(phandler, nAddr, ImageData, ref ImageLength);
                    if (ret == 0)
                    {
                        ret = biometria.PSImgData2BMP(ImageData, ImagePath);
                        if (ret == 0)
                        {
                            bt_img.BackgroundImage = Image.FromFile("C://teste/" + id_str + ".bmp");
                            bt_img.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Erro ao coletar a biometria.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bt_img.BackgroundImage = null;
            int pacid = Int32.Parse(lb_id.Text);
            string path = @"C://teste/" + pacid + ".bmp";
        }
    }
}
