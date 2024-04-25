using Login.DataBase;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form_Login : Form
    {

        public Form_Login()
        {
            InitializeComponent();

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            if (Conectar()) {
                //Conexao bem sucedida
            }

        }

        private bool Conectar()
        {
            var result = false;

            try
            {
                using (var cn = new MySqlConnection(Conn.strConn)) {
                cn.Open();
                result = true;
                }
            }
            catch (Exception ex)
            {

                result = false;
                MessageBox.Show("Falha" + ex.Message);
            }
            return result;
        }

        private void Btn_Cadastro_Click(object sender, EventArgs e)
        {
            Program.TrocarTela(this, new Form_Cadastro());
        }

        private void txtBox_Usuario_TextChanged(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente números");
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            DataBaseController.UsuarioLogin(txtBox_Usuario.Text, txtBox_Senha.Text);

            if(Program.usuarioLogado == null)
            {
                MessageBox.Show("Usuario ou senha invalidos!");
                return;
            }
            Program.TrocarTela(this, new Form_Home());

        }
    }
}
