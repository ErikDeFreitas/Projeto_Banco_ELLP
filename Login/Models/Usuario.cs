using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    internal class Usuario
    {
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; set; }

    }
}
