using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace projeto_aedb1.Model
{
    public class Autor
    {
        private int _id;
        private string _Nome;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get => _Nome;
            set => _Nome = value.Replace("'", " ");
        }

        // Listar todos os autores
        public static List<Autor> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Autor> Retorno = new List<Autor>();
                string SQL = "SELECT id, Nome FROM Autor";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Autor autor = new Autor();
                    autor.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    autor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    DataHelper.ListaAutor.Add(autor);
                    Retorno.Add(autor);
                }
                oDr.Close();
                return Retorno;
            }
        }

        // Seleciona um autor pelo código
        public static Autor? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"SELECT id, Nome FROM Autor WHERE id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                if (oDr.Read())
                {
                    Autor autor = new Autor();
                    autor.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    autor.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    return autor;
                }
                else
                {
                    return null;
                }
            }
        }

        // Incluir autor estático na lista
        public static void IncluirAutorEstatico(Autor autor)
        {
            Autor? autorSelecionado = Autor.Seleciona(autor.id);
            if (autorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no autor {autorSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaAutor.Add(autor);
            }
        }

        // Incluir autor no banco de dados
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Autor (Nome) VALUES('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        // Alterar autor no banco de dados
        public static void Alterar(Autor autor)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Autor SET Nome = '{autor.Nome.Replace("'", "")}' WHERE id = {autor.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        // Excluir autor do banco de dados
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Autor WHERE id = {this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
