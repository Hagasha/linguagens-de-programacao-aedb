using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace projeto_aedb1.Model
{
    public class Livro
    {
        private int _id;
        private string _Nome;
        private int _idEditora;
        private int _idGenero;
        private int _idIdioma;
        private string _ISBN;                // Nova variável
        private string _Descricao;           // Nova variável
        private int _Edicao;                 // Alterado para int
        private int _QtdPaginas;             // Nova variável

        // Propriedades
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

        public int IdEditora
        {
            get { return _idEditora; }
            set { _idEditora = value; }
        }

        public int IdGenero
        {
            get { return _idGenero; }
            set { _idGenero = value; }
        }

        public int IdIdioma
        {
            get { return _idIdioma; }
            set { _idIdioma = value; }
        }

        public string ISBN                      
        {
            get => _ISBN;
            set => _ISBN = value.Replace("'", " ");
        }

        public string Descricao                 
        {
            get => _Descricao;
            set => _Descricao = value.Replace("'", " ");
        }

        public int Edicao                       
        {
            get => _Edicao;
            set => _Edicao = value; 
        }

        public int QtdPaginas                   
        {
            get => _QtdPaginas;
            set => _QtdPaginas = value;
        }
        public static List<Livro> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Livro> Retorno = new List<Livro>();
                string SQL = "SELECT Id, Nome, IdEditora, IdGenero, IdIdioma, ISBN, Descricao, Edicao, QtdPaginas FROM Livro";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    Livro livro = new Livro();
                    livro.Id = oDr.GetInt32(oDr.GetOrdinal("Id"));
                    livro.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    livro.IdEditora = oDr.GetInt32(oDr.GetOrdinal("IdEditora"));
                    livro.IdGenero = oDr.GetInt32(oDr.GetOrdinal("IdGenero"));
                    livro.IdIdioma = oDr.GetInt32(oDr.GetOrdinal("IdIdioma"));
                    livro.ISBN = oDr.GetString(oDr.GetOrdinal("ISBN"));
                    livro.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    livro.Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")); 
                    livro.QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas"));
                    Retorno.Add(livro);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Livro? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"SELECT Id, Nome, IdEditora, IdGenero, IdIdioma, ISBN, Descricao, Edicao, QtdPaginas FROM Livro WHERE Id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();

                if (oDr.Read())
                {
                    Livro livro = new Livro();
                    livro.Id = oDr.GetInt32(oDr.GetOrdinal("Id"));
                    livro.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    livro.IdEditora = oDr.GetInt32(oDr.GetOrdinal("IdEditora"));
                    livro.IdGenero = oDr.GetInt32(oDr.GetOrdinal("IdGenero"));
                    livro.IdIdioma = oDr.GetInt32(oDr.GetOrdinal("IdIdioma"));
                    livro.ISBN = oDr.GetString(oDr.GetOrdinal("ISBN"));
                    livro.Descricao = oDr.GetString(oDr.GetOrdinal("Descricao"));
                    livro.Edicao = oDr.GetInt32(oDr.GetOrdinal("Edicao")); 
                    livro.QtdPaginas = oDr.GetInt32(oDr.GetOrdinal("QtdPaginas"));
                    return livro;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                if (string.IsNullOrEmpty(this.Nome))
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }

                string SQL = $"INSERT INTO Livro (Nome, IdEditora, IdGenero, IdIdioma, ISBN, Descricao, Edicao, QtdPaginas) " +
                             $"VALUES ('{this.Nome.Replace("'", "")}', {this.IdEditora}, {this.IdGenero}, {this.IdIdioma}, " +
                             $"'{this.ISBN.Replace("'", "")}', '{this.Descricao.Replace("'", "")}', {this.Edicao}, " + // Ajustado para int
                             $"{this.QtdPaginas})";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Livro livro)
        {
            using (var oCn = DataHelper.Conexao())
            {
                if (string.IsNullOrEmpty(livro.Nome))
                {
                    throw new Exception("O campo Nome é obrigatório.");
                }

                string SQL = $"UPDATE Livro SET Nome = '{livro.Nome.Replace("'", "")}', " +
                             $"IdEditora = {livro.IdEditora}, IdGenero = {livro.IdGenero}, IdIdioma = {livro.IdIdioma}, " +
                             $"ISBN = '{livro.ISBN.Replace("'", "")}', Descricao = '{livro.Descricao.Replace("'", "")}', " +
                             $"Edicao = {livro.Edicao}, QtdPaginas = {livro.QtdPaginas} " + // Ajustado para int
                             $"WHERE Id = {livro.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Livro WHERE Id = {this.Id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
