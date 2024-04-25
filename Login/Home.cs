using Login.Builder;
using Login.Extensões;
using MySql.Data.MySqlClient;
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
    public partial class Form_Home : Form
    {
        public Form_Home()
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

        private void Header_TransClicked()
        {
            Program.TrocarTela(this, new Form_Trasferencia());
        }

        private void Header_HomeClicked()
        {
            MessageBox.Show("Você já esta na tela Principal!", "Aviso");
        }

        private void Header_DepoClicked()
        {
            Program.TrocarTela(this, new Deposito());
        }

        private void Header_ExtClicked()
        {
            Program.TrocarTela(this, new Form_Extrato());
        }

        private void Header_SairClicked()
        {
            Program.TrocarTela(this, new Form_Login());
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            lbl_Nome.Text = Program.usuarioLogado.Nome.ToString();
            lbl_Saldo.Text = Program.usuarioLogado.Saldo.ToString();
        }
    }
}
