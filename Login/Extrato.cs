using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Builder;
using Login.DataBase;
using Login.Extensões;
using Login.Models;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.LinkLabel;

namespace Login
{
    public partial class Form_Extrato : Form
    {
        public Form_Extrato()
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
            Program.TrocarTela(this, new Form_Home());
        }

        private void Header_DepoClicked()
        {
            Program.TrocarTela(this, new Deposito());
        }

        private void Header_ExtClicked()
        {
            
            MessageBox.Show("Você já esta na tela de Extrato!", "Aviso");
        }

        private void Header_SairClicked()
        {
            Program.TrocarTela(this, new Form_Login());
        }

        private void btn_ConsulteExtrato_Click(object sender, EventArgs e)
        {
            var extratos = DataBaseController.ConsultaExtrato(Program.usuarioLogado.CPF);

            foreach (var extrato in extratos)
            {

                lstExtrato.Items.Add(new ListViewItem()
                {
                    Text = $"Valor: {extrato}"
                });
            
            }
        }
    }
}
