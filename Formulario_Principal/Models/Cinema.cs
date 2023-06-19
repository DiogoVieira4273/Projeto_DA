using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Cinema
    {
        public int id {  get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string Email { get; set; }

        public Cinema(string nome, string morada, string email)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.Email = email;
        }
    }
}