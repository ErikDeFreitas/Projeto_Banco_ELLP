using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Extensões
{
    public partial class Header : UserControl
    {

        internal delegate void Home();
        internal event Home HomeClicked;


        internal delegate void Trans();
        internal event Trans TransClicked;

        internal delegate void Depo();
        internal event Depo DepoClicked;

        internal delegate void Ext();
        internal event Ext ExtClicked;

        internal delegate void Sair();
        internal event Ext SairClicked;


        public Header()
        {
            InitializeComponent();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            HomeClicked?.Invoke();
        }

        private void btn_Trasferencia_Click(object sender, EventArgs e)
        {
            TransClicked?.Invoke();
        }

        private void btn_Deposito_Click(object sender, EventArgs e)
        {
            DepoClicked?.Invoke();
        }

        private void btn_Extrato_Click(object sender, EventArgs e)
        {
            ExtClicked?.Invoke(); 
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            SairClicked?.Invoke();
        }
    }
}
