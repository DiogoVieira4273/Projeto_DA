using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Cinema
    {
        public int id;
        public string Nome;
        public string Morada;
        public string Email;

        public Cinema(string nome, string morada, string email)
        {
            this.Nome = nome;
            this.Morada = morada;
            this.Email = email;
        }
    }
}
