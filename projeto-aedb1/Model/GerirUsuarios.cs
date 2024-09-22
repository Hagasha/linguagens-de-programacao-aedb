using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace projeto_aedb1.Model
{
    public class Pessoa
    {
        private int _id;
        private string _Nome;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get => _Nome;
            set => _Nome = value.Replace("'", " ");
        }

        // Método para listar todas as pessoas
        public static List<Pessoa> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Pessoa> Retorno = new List<Pessoa>();
                string SQL = "SELECT Id, Nome FROM Pessoa";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Id = oDr.GetInt32(oDr.GetOrdinal("Id"));
                    pessoa.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    DataHelper.ListaPessoa.Add(pessoa);
                    Retorno.Add(pessoa);
                }
                oDr.Close();
                return Retorno;
            }
        }

        // Método para selecionar uma pessoa pelo Id
        public static Pessoa? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"SELECT Id, Nome FROM Pessoa WHERE Id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Id = oDr.GetInt32(oDr.GetOrdinal("Id"));
                    pessoa.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    return pessoa;
                }
                else
                {
                    return null;
                }
            }
        }

        // Método para incluir uma nova pessoa
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                if (string.IsNullOrEmpty(this.Nome))
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }

                string SQL = $"INSERT INTO Pessoa (Nome) VALUES ('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        // Método para alterar uma pessoa existente
        public static void Alterar(Pessoa pessoa)
        {
            using (var oCn = DataHelper.Conexao())
            {
                if (string.IsNullOrEmpty(pessoa.Nome))
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }

                string SQL = $"UPDATE Pessoa SET Nome = '{pessoa.Nome.Replace("'", "")}' WHERE Id = {pessoa.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        // Método para excluir uma pessoa
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Pessoa WHERE Id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        // Método para incluir uma pessoa de forma estática
        public static void IncluirPessoaEstatico(Pessoa pessoa)
        {
            Pessoa? pessoaSelecionada = Pessoa.Seleciona(pessoa.Id);
            if (pessoaSelecionada != null)
            {
                throw new Exception($"O código informado está sendo utilizado pela pessoa {pessoaSelecionada.Nome}");
            }
            else
            {
                DataHelper.ListaPessoa.Add(pessoa);
            }
        }
    }
}
