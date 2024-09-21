using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_aedb1.Helper;
using projeto_aedb1.Model;

namespace projeto_aedb1.Mock
{
    internal class MockEditora
    {
        public static void CarregaEditora()
        {
            List<Editora> lista = new List<Editora>();

            DataHelper.ListaEditora = lista;

        }
    }
}
