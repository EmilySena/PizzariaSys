using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PizzariaDominio;

namespace PizzariaSys.Web.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage=" *Campo Obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = " *Campo Obrigatorio")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = " *Campo Obrigatorio")]
        [DataType(DataType.Text)]
        [RegularExpression(@"^[A-Za-z0-9]*\d+[A-Za-z0-9]*$", ErrorMessage= "Digite apenas números")]
        public int Numero { get; set; }
        [Required(ErrorMessage = " *Campo Obrigatorio")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = " *Campo Obrigatorio")]
        public string Telefone { get; set; }

        public ClienteViewModel()
        {

        }

        public ClienteViewModel(Cliente cliente)
        {
            Id = cliente.Id;
            Nome = cliente.Nome;
            Logradouro = cliente.Logradouro;
            Numero = cliente.Numero;
            Bairro = cliente.Bairro;
            Telefone = cliente.Telefone;
        }
    }
}