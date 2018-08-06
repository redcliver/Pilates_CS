using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilates_CS
{
    static class autenticacao
    {
        static string usuario;
        static string senha;

        public static void login(string usuario1, string senha1) {
            usuario = usuario1;
            senha = senha1;
        }

        public static void logout()
        {
            usuario = null;
            senha = null;
        }

        public static void getUsuario()
        {
            usuario = null;
            senha = null;
        }

    }
}
