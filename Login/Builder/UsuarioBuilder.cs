using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Builder
{
    internal static class UsuarioBuilder
    {
        internal static List<Usuario> Build(MySql.Data.MySqlClient.MySqlDataReader reader) 
        { 
            if (!reader.HasRows)
            {
                return new List<Usuario> ();
            }
            var retorno = new List<Usuario> ();

            while (reader.Read ())
            {
                retorno.Add(
                    new Usuario(){
                        Id = int.Parse(reader["idusuario"].ToString()),
                        Nome = (string)reader["nome"],
                        CPF = (string)reader["cpf"],
                        Senha = (string)reader["senha"],
                        Saldo = double.Parse(reader["saldo"].ToString())
                    });
            }
            return retorno;
        }   
    }
}
