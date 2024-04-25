using Login.Builder;
using Login.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Login.Extensões.Header;

namespace Login.DataBase
{
    internal static class DataBaseController
    {
        internal static void InicializarUsuarios() 
        {
            var connection = new MySqlConnection(Conn.strConn);

            MySqlCommand query = new MySqlCommand("select * from usuario", connection);

            connection.Open();

            MySqlDataReader reader = query.ExecuteReader();

            Program.usuariosComCadastro = UsuarioBuilder.Build(reader);

            connection.Close();
        }

        internal static Usuario ConsultaUsuarioCpf(string cpf) 
        {
            var connection = new MySqlConnection(Conn.strConn);

            MySqlCommand query = new MySqlCommand("select * from usuario where cpf = '" + cpf + "'", connection);

            connection.Open();

            MySqlDataReader reader = query.ExecuteReader();

            var listUsuarios = UsuarioBuilder.Build(reader);

            connection.Close();

            if (listUsuarios.Count == 0)
            {
                return null;
            }

            return listUsuarios[0];
        }

        internal static void UsuarioLogin(string cpf, string senha)
        {
            var connection = new MySqlConnection(Conn.strConn);

            MySqlCommand query = new MySqlCommand("select * from usuario " +
                "where cpf = '" + cpf + "' and senha = '" + senha + "'", connection);

            connection.Open();

            MySqlDataReader reader = query.ExecuteReader();

            var listUsuarios = UsuarioBuilder.Build(reader);

            connection.Close();

            if (listUsuarios.Count == 0)
            {
                Program.usuarioLogado = null;
                return;
            }

            Program.usuarioLogado = listUsuarios[0];
        }

        internal static void Cadastrar(string nome, string cpf, string senha)
        {
            var connection = new MySqlConnection(Conn.strConn);

            MySqlCommand query = new MySqlCommand($"insert into usuario (nome, cpf, senha, saldo) values ('{nome}', '{cpf}', '{senha}', 0)", connection);
            MySqlCommand query2 = new MySqlCommand($"insert into extrato (cpf, Valor) values ({cpf}, 0)", connection);



            connection.Open();

            query.ExecuteNonQuery();
            query2.ExecuteNonQuery();

            connection.Close();
        }

        internal static void Transferir(Usuario usuarioAlvo, double valor)
        {
            var connection = new MySqlConnection(Conn.strConn);

            var saldoFinalAlvo = usuarioAlvo.Saldo + valor;
            var saldoFinalAtual = Program.usuarioLogado.Saldo - valor;


            MySqlCommand query1 = new MySqlCommand($"update usuario set saldo = @valor where cpf = {usuarioAlvo.CPF}", connection);
            MySqlCommand query2 = new MySqlCommand($"update usuario set saldo = @valor where cpf = {Program.usuarioLogado.CPF}", connection);
            

            query1.Parameters.AddWithValue("@valor", saldoFinalAlvo);
            query2.Parameters.AddWithValue("@valor", saldoFinalAtual);

            connection.Open();

            query1.ExecuteNonQuery();
            query2.ExecuteNonQuery();

            connection.Close();

            UpdateExtrato(usuarioAlvo.CPF, valor);
            UpdateExtrato(Program.usuarioLogado.CPF, -valor);


        }

        internal static void Deposito(double valor)
        {
            var connection = new MySqlConnection(Conn.strConn);

            var saldoFinal = Program.usuarioLogado.Saldo + valor;

            MySqlCommand query = new MySqlCommand($"update usuario set saldo = @valor where cpf = {Program.usuarioLogado.CPF}", connection);

            query.Parameters.AddWithValue("@valor", saldoFinal);

            connection.Open();

            query.ExecuteNonQuery();

            connection.Close();

            UpdateExtrato(Program.usuarioLogado.CPF, valor);

        }

        internal static List<Extrato> ConsultaExtrato(string cpf)
        {
            var connection = new MySqlConnection(Conn.strConn);

            string sql = $"select * from extrato where cpf = '{Program.usuarioLogado.CPF}';";

            MySqlCommand comando = new MySqlCommand(sql, connection);
            connection.Open();

            MySqlDataReader reader = comando.ExecuteReader();

            return ExtratoBuilder.Build(reader);
        }

        internal static void UpdateExtrato(string cpf, double valor)
        {
            var connection = new MySqlConnection(Conn.strConn);


            string sql = "insert into extrato (cpf, Valor) values (@cpf, @valor)";

            MySqlCommand comando = new MySqlCommand(sql, connection);

            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@cpf", cpf);

            connection.Open();

            comando.ExecuteNonQuery();

        }
    }
}
