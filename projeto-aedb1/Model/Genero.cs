using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace projeto_aedb1.Model
{
    public class Genero
    {
        private int _id;

        private string _Nome;
        public int id {
            get { return _id; }
            set { _id = value;  } 
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", " ");  }

        public static List<Genero> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Genero> Retorno = new List<Genero>();
                string SQL = "SELECT id, Nome FROM Genero";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Genero genero = new Genero();
                    genero.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    genero.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    DataHelper.ListaGenero.Add(genero);
                    Retorno.Add(genero);
                }
                oDr.Close();
                return Retorno;
            }
        }

        public static Genero? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"SELECT id, Nome FROM Genero WHERE id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                if (oDr.Read())
                {
                    Genero genero = new Genero();
                    genero.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    genero.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    return genero;
                }
                else
                {
                    return null;
                }
            }
        }

        public static void IncluirGeneroEstatico(Genero genero)
        {
            Genero? generoSelecionado = Genero.Seleciona(genero.id);
            if (generoSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no gênero {generoSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaGenero.Add(genero);
            }
        }
        public void Incluir()
        {
            using(var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Genero VALUES('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public static void Alterar(Genero genero)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Genero SET Nome = '{genero.Nome.Replace("'", "")}' WHERE id = {genero.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Genero WHERE id = {this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
    