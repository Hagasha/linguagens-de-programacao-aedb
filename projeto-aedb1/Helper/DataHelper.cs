using projeto_aedb1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace projeto_aedb1.Helper
{
    public static class DataHelper
    {
        public static List<Genero> ListaGenero { get; set; }
        public static List<Autor> ListaAutor { get; set; }
        public static List<Editora> ListaEditora { get; set; }
        public static List<Idioma> ListaIdioma { get; set; }
        public static List<Livro> ListaLivro { get; set; }
        public static List<Pessoa> ListaPessoa { get; set; }
        public static SqlConnection Conexao()
        {
            string strconnection = "Data Source = LOYAL\\SQLEXPRESS; Initial Catalog = Livraria; Integrated Security = True; Integrated Security = True; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True;";
            SqlConnection oCn = new SqlConnection(strconnection);
            oCn.Open();
            return oCn;


        }
    }
}
