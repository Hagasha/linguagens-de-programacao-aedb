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

            for (int i = 1; i < 11; i++)
            {
                Autor autor = new Autor
                {
                    id = i,
                    Nome = $"Autor {i}"
                };
                lista.Add(autor);
            }

            DataHelper.ListaAutor = lista;
        }
    }
}

