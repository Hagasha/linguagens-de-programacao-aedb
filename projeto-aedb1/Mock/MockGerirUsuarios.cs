using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_aedb1.Model;
using projeto_aedb1.Helper;

namespace projeto_aedb1.Mock
{
    public class MockGerirUsuarios
    {
        public static void CarregaGerirUsuarios()
        {
            List<Pessoa> lista = new List<Pessoa>();

            DataHelper.ListaPessoa= lista;

        }
    }
}
