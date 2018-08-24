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
    public partial class fm_MsgCadBiometria : Form
    {
        
        public fm_MsgCadBiometria()
        {
            InitializeComponent();
            
        }
        static IntPtr phandler = IntPtr.Zero;
        static UInt32 nAddr = 0xffffffff;

        private void fm_MsgCadBiometria_Load(object sender, EventArgs e)
        {
            string id_str;
            string connString = "Server = 127.0.0.1; Port = 5432; Database = pilates; Uid=postgres; Pwd=igor3355;";
            string ultimo = "SELECT * FROM paciente ORDER BY paciente_id DESC LIMIT 1";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(ultimo, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            id_str = (dr["paciente_id"].ToString());
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

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Biometria salva com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bt_img_Click(object sender, EventArgs e)
        {

        }
    }
}
