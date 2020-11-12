using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizarriaSysAcessoDados.Interface
{
    public interface IRepositorio<T> where T: class
    {
        string Salvar(T entidade);
        string Deletar(T entidade);
        T BuscarId(int id);
        IEnumerable<T> ListarTodos();

    }
}
