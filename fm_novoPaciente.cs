using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Npgsql;


namespace Pilates_CS
{
    public partial class fm_novoPaciente : Form
    {
        public fm_novoPaciente()
        {
            InitializeComponent();
        }
        static IntPtr phandler = IntPtr.Zero;
        static UInt32 nAddr = 0xffffffff;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            string nome = tb_nome.Text;
            string tel = tb_tel.Text;
            string cel = tb_cel.Text;
            DateTime data = dp_data_nasc.Value;
            DateTime agora = DateTime.Now;
            string que = tb_queixa.Text;
            string obj = tb_objetivo.Text;
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string query = "INSERT INTO paciente (nome, telefone, celular, data_nasc, data_cadastro, queixa, objetivo) VALUES (@n, @t, @c, @d, @dc, @q, @o)";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("n", nome);
            cmd.Parameters.AddWithValue("t", tel);
            cmd.Parameters.AddWithValue("c", cel);
            cmd.Parameters.AddWithValue("d", data);
            cmd.Parameters.AddWithValue("dc", agora);
            cmd.Parameters.AddWithValue("q", que);
            cmd.Parameters.AddWithValue("o", obj);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
            resposta =  MessageBox.Show("Deseja cadastrar a biometria do paciente?", "Biometria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == System.Windows.Forms.DialogResult.Yes)
            {
                int ret = -1;
                ret = biometria.PSOpenDeviceEx(ref phandler, 2, 1, 1, 2, 0);
                ret = biometria.PSGetImage(phandler, nAddr);
                if (ret == 0)
                {
                    fm_MsgCadBiometria msg = new fm_MsgCadBiometria();
                    msg.ShowDialog();
                    ret = biometria.PSCloseDeviceEx(phandler);
                }
                else
                {
                    MessageBox.Show("Erro ao coletar a biometria.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();

                }
                
            }
            else {
                this.Close();
            }

        }

        private void fm_novoPaciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ret = -1;
            int i = 0;
            byte[] ImageData = new byte[256 * 288];
            int ImageLength = 0;
            string ImagePath = "C://teste/Digital.bmp";
            ret = biometria.PSOpenDeviceEx(ref phandler, 2, 1, 1, 2, 0);
            ret = biometria.PSGetImage(phandler, nAddr);
            if (ret == 0)
            {
                ret = biometria.PSUpImage(phandler, nAddr, ImageData, ref ImageLength);
                if (ret == 0)
                {
                    ret = biometria.PSImgData2BMP(ImageData, ImagePath);
                    if (ret == 0)
                    {
                        MessageBox.Show("Biometria coletada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Erro ao coletar a biometria.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
