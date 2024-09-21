using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projeto_aedb1.Model;


namespace projeto_aedb1.Interfaces
{
    public interface IRepositorioEditora
    {
        Editora Incluir(Editora editora);

        void Alterar(Editora editora);

        void Excluir(Editora editora);

        void Excluir(int id);

        List<Editora> ListarTodos();
        Editora Selecionar(int id);
    }
}
