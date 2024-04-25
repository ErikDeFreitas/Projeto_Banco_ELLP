using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    static class Conn
    {
        static private string servidor = "localhost";
        static private string bancoDeDados = "BancoELLP";
        static private string usuario = "root";
        static private string senha = "admin";
        static public string strConn = $"server={servidor }; User Id =" +
            $"{ usuario }; database = {bancoDeDados}; password = {senha}";
    }
}
