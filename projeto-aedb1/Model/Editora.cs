using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace projeto_aedb1.Model
{
    public class Editora
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

        // Listar todas as editoras
        public static List<Editora> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Editora> Retorno = new List<Editora>();
                string SQL = "SELECT id, Nome FROM Editora";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Editora editora = new Editora();
                    editora.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    editora.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    DataHelper.ListaEditora.Add(editora);
                    Retorno.Add(editora);
                }
                oDr.Close();
                return Retorno;
            }
        }

        // Seleciona uma editora pelo código
        public static Editora? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"SELECT id, Nome FROM Editora WHERE id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                if (oDr.Read())
                {
                    Editora editora = new Editora();
                    editora.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    editora.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    return editora;
                }
                else
                {
                    return null;
                }
            }
        }

        // Incluir editora estática na lista
        public static void IncluirEditoraEstatico(Editora editora)
        {
            Editora? editoraSelecionada = Editora.Seleciona(editora.id);
            if (editoraSelecionada != null)
            {
                throw new Exception($"O código informado está sendo utilizado na editora {editoraSelecionada.Nome}");
            }
            else
            {
                DataHelper.ListaEditora.Add(editora);
            }
        }

        // Incluir editora no banco de dados
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Editora (Nome) VALUES('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        // Alterar editora no banco de dados
        public static void Alterar(Editora editora)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Editora SET Nome = '{editora.Nome.Replace("'", "")}' WHERE id = {editora.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        // Excluir editora do banco de dados
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Editora WHERE id = {this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
