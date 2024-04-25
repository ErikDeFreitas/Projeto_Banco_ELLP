using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Builder
{
    internal static class ExtratoBuilder
    {
        internal static List<Extrato> Build(MySql.Data.MySqlClient.MySqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                return new List<Extrato>();
            }
            var retorno = new List<Extrato>();

            while (reader.Read())
            {
                retorno.Add(
                    new Extrato()
                    {
                        
                        CPF = (string)reader["cpf"],
                        Valor = (double)reader["Valor"],
                        
                    });
            }
            return retorno;
        }
    }
}
