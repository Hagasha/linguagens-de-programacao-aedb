using projeto_aedb1.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_aedb1.Model
{
    public class Autor
    {
        private int _id;
        private string _Nome;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome { get => _Nome; set => _Nome = value.Replace("'", " "); }

        public static List<Autor> ListarTodos()
        {
         return (from p in DataHelper.ListaAutor select p).ToList();
        }

        public static Autor? Seleciona(int Codigo)
        {
            return (from p in DataHelper.ListaAutor where p.id == Codigo select p).FirstOrDefault();
        }

        public void Incluir()
        {
            Autor? autorSelecionado = Autor.Seleciona(this.id);
            if (autorSelecionado != null)
            {
                throw new Exception($"O código informado está sendo utilizado no autor {autorSelecionado.Nome}.");
            }
            else
            {
                DataHelper.ListaAutor.Add(this);
            }
        }

        public static void Alterar(Autor autor)
        {
            Autor? AutorColecao = Seleciona(autor.id);
            if (AutorColecao == null)
            {
                throw new Exception("Autor não encontrado.");
            }
            else
            {
                AutorColecao.Nome = autor.Nome;
            }
        }

        public void Excluir()
        {
                DataHelper.ListaAutor.Remove(this);
        }
    }
}
