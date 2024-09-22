using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_aedb1.Model;

namespace projeto_aedb1.Mock
{
    public class MockLivro
    {
        public static void CarregaLivro()
        {
            List<Livro> lista = new List<Livro>();

            DataHelper.ListaLivro = lista;
        }
    }
}
