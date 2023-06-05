using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Pessoa
    {
        public int id;
        public string Nome;
        public string Morada;

        public Pessoa(string nome, string morada)
        {
            this.Nome = nome;
            this.Morada = morada;
        }
    }
}
