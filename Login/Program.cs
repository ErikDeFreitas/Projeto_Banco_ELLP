using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    internal static class Program
    {

        internal static List<Usuario> usuariosComCadastro;
        internal static Usuario usuarioLogado;
        internal static Extrato extratoLogado;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Login());
        }

        internal static void TrocarTela (Form formAtual, Form formAlvo)
        {
            formAtual.Hide();
            formAtual.Enabled = false;
            formAtual.ShowInTaskbar = false;
            formAlvo.Show();
            formAlvo.Enabled = true;
            formAlvo.ShowInTaskbar = true;

            formAlvo.Closed += (s,e) => formAtual.Close();
        }
    }
  
}
