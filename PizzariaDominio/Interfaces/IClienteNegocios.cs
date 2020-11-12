using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizarriaSysAcessoDados.Interface;

namespace PizzariaDominio.Interfaces
{
    public interface IClienteNegocios: IRepositorio<Cliente>
    {
        public IEnumerable<Cliente> ListarClienteTelefone(string param);
    }
}
