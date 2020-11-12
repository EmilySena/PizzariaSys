using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzariaDominio;
using PizzariaDominio.Interfaces;
using PizzariaDominio.Negocios;
using PizzariaSys.Web.Models;

namespace PizzariaSys.Web.Controllers
{
    public class ClienteController : Controller
    {
        private IClienteNegocios _clienteNegocios = new ClienteNegocios();
        // GET: Cliente
        public ActionResult Index()
        {
            var clientes = _clienteNegocios.ListarTodos();
            return View(clientes);
        }

        [HttpGet]
        public ActionResult Inserir()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Inserir(ClienteViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var cliente = new Cliente()
            {
                Nome = model.Nome,
                Logradouro = model.Logradouro,
                Numero = model.Numero,
                Bairro = model.Bairro,
                Telefone = model.Telefone
            };
            _clienteNegocios.Salvar(cliente);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ConsultarTelefone()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConsultarTelefone(string telefone)
        {
            var cliente = _clienteNegocios.ListarClienteTelefone(telefone);
            if (cliente == null)
            {
                return View(telefone);
            }
            return View("Detalhes", new ClienteViewModel(cliente));
        }

        public ActionResult Detalhes(int id)
        {
            var cliente = _clienteNegocios.BuscarId(id);
            return View(new ClienteViewModel(cliente));
        }
    }
}