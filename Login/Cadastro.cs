using Login.DataBase;
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
    public partial class Form_Cadastro : Form
    {
        public Form_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Program.TrocarTela(this, new Form_Login());

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var nome = txtBox_Nome.Text;
            var senha1 = txtBox_Senha.Text;
            var senha2 = txtBox_ConfirmeSenha.Text;
            var cpf = txtBox_CPF.Text;

            if(nome.Length < 3)
            {
                MessageBox.Show("Nome pequeno hein...");
                return;
            }
            if(!ValidarCpf(cpf))
            {
                MessageBox.Show("Cpf errado hein...");
                return;
            }

            if(senha1 != senha2)
            {
                MessageBox.Show("As senhas precisam ser iguais!");
                return;
            }
            DataBaseController.Cadastrar(nome,cpf,senha1);
            MessageBox.Show($"{nome}, cadastrado com sucesso. \nBem Vindo!");
            Program.TrocarTela(this, new Form_Login());

        }

        private bool ValidarCpf(string cpf)
        {
            var trueCpf = new List<int>();

            foreach(var c in cpf)
            {
                if (char.IsDigit(c))
                {
                    trueCpf.Add(int.Parse(c.ToString()));
                }
                else
                {
                    return false;
                }
            }
            return trueCpf.Count == 5;
        }
    }
}
