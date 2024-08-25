using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_aedb1.Model;
using projeto_aedb1.Helper;

namespace projeto_aedb1.Mock
{
    public class MockGenero
    {
        public static void CarregaGenero()
        {
            List<Genero> lista = new List<Genero>();

            for (int i = 1; i < 11; i++)
            {
                Genero genero = new Genero
                {
                    id = i,
                    Nome = $"Gênero {i}"
                };
                lista.Add(genero);
            }

            DataHelper.ListaGenero = lista;
        }
    }
}
