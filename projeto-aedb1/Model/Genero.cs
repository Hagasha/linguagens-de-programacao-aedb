using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return (from p in DataHelper.ListaGenero select p).ToList();
        }

        public static Genero? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaGenero where p.id == Codigo select p).FirstOrDefault();
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

            Genero? generoSelecionado = Genero.Seleciona(this.id);
            if (generoSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no gênero {generoSelecionado.Nome}.");
            }
            else
            {
                DataHelper.ListaGenero.Add(this);
            }
        }

        public static void Alterar(Genero genero)
        {
            Genero? GeneroColecao = Seleciona(genero.id);
            if(GeneroColecao == null)
            {
                throw new Exception($"O objeto informado não existe mais no contexto");
            }
            else
            {
                //GeneroColecao.id = genero.id;
                GeneroColecao.Nome = genero.Nome;
            }
        }

        public void Excluir()
        {
            DataHelper.ListaGenero.Remove(this);
        }
    }
}
    