using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Models
{
    internal class Extrato
    {
        public string CPF { get; set; }
        public double Valor { get; set; }

        public override string ToString()
        {
            return $"R${Valor}";
        }
    }
}
