using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_aedb1.Model;
using projeto_aedb1.Helper;

namespace projeto_aedb1.Mock
{
    public class MockIdioma
    {
        public static void CarregaIdioma()
        {
            List<Idioma> lista = new List<Idioma>();

            DataHelper.ListaIdioma = lista;

        }
    }
}
