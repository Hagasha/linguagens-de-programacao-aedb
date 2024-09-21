using projeto_aedb1.Helper;
using projeto_aedb1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_aedb1.Mock
{
    internal class MockAutor
    {
     public static void CarregaAutor()
        {
            List<Autor> lista = new List<Autor>();

            DataHelper.ListaAutor = lista;
            
        }
    }
}

