using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzariaDominio.Interfaces;
using PizzariaDominio.Repositorios;

namespace PizzariaDominio.Negocios
{
    public class ClienteNegocios: ClienteRepositorio, IClienteNegocios
    {
        public IEnumerable<Cliente> ListarClienteTelefone(string param)
        {
            var cliente = ListarTodos().Where(x => x.Telefone == param);
            return cliente;
        }
    }
}
