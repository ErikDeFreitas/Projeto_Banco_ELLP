using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.DataBase;
using Login.Extensões;

namespace Login
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();

            var Header = new Header();

            Header.ExtClicked += Header_ExtClicked;
            Header.DepoClicked += Header_DepoClicked;
            Header.HomeClicked += Header_HomeClicked;
            Header.TransClicked += Header_TransClicked;
            Header.SairClicked += Header_SairClicked;

            Header.Dock = DockStyle.Top;
            Controls.Add(Header);
        }

        private void Header_SairClicked()
        {
            Program.TrocarTela(this, new Form_Login());

        }

        private void Header_TransClicked()
        {
            Program.TrocarTela(this, new Form_Trasferencia());
        }

        private void Header_HomeClicked()
        {
            Program.TrocarTela(this, new Form_Home());
        }

        private void Header_DepoClicked()
        {
            MessageBox.Show("Você já esta na tela de Deposito!", "Aviso");
        }

        private void Header_ExtClicked()
        {
            Program.TrocarTela(this, new Form_Extrato());
        }

        private void btn_ConfirmarEnviar_Click(object sender, EventArgs e)
        {
            var texto = txtBox_ValorTrasferencia.Text;

            texto = texto.Replace(",", ".");

            var valor = double.Parse(texto, System.Globalization.CultureInfo.InvariantCulture);

            if (valor <= 0)
            {
                MessageBox.Show("Ta doido? Quer depositar divida?");
                return;
            }

            DataBaseController.Deposito(valor);

            DataBaseController.UsuarioLogin(Program.usuarioLogado.CPF, Program.usuarioLogado.Senha);

            MessageBox.Show("Deposito feito com sucesso!");

            Program.TrocarTela(this, new Form_Home());

        }
    }
}
