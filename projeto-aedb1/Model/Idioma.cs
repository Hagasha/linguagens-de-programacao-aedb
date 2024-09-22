using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace projeto_aedb1.Model
{
    public class Idioma
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

        
        public static List<Idioma> ListarTodos()
        {
            using (var oCn = DataHelper.Conexao())
            {
                List<Idioma> Retorno = new List<Idioma>();
                string SQL = "SELECT id, Nome FROM Idioma";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                while (oDr.Read())
                {
                    Idioma idioma = new Idioma();
                    idioma.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    idioma.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    DataHelper.ListaIdioma.Add(idioma);
                    Retorno.Add(idioma);
                }
                oDr.Close();
                return Retorno;
            }
        }

        
        public static Idioma? Seleciona(int Codigo)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"SELECT id, Nome FROM Idioma WHERE id = {Codigo}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                SqlDataReader oDr = comando.ExecuteReader();
                if (oDr.Read())
                {
                    Idioma idioma = new Idioma();
                    idioma.id = oDr.GetInt32(oDr.GetOrdinal("id"));
                    idioma.Nome = oDr.GetString(oDr.GetOrdinal("Nome"));
                    return idioma;
                }
                else
                {
                    return null;
                }
            }
        }

        
        public static void IncluirIdiomaEstatico(Idioma idioma)
        {
            Idioma? idiomaSelecionado = Idioma.Seleciona(idioma.id);
            if (idiomaSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no idioma {idiomaSelecionado.Nome}");
            }
            else
            {
                DataHelper.ListaIdioma.Add(idioma);
            }
        }

        
        public void Incluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"INSERT INTO Idioma VALUES('{this.Nome.Replace("'", "")}')";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        
        public static void Alterar(Idioma idioma)
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"UPDATE Idioma SET Nome = '{idioma.Nome.Replace("'", "")}' WHERE id = {idioma.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }

        
        public void Excluir()
        {
            using (var oCn = DataHelper.Conexao())
            {
                string SQL = $"DELETE FROM Idioma WHERE id = {this.id}";
                SqlCommand comando = new SqlCommand(SQL, oCn);
                comando.ExecuteNonQuery();
            }
        }
    }
}
