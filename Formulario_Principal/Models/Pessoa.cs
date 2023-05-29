using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Pessoa
    {
        string Nome;
        string Morada;

        public Pessoa(string Nome, string Morada)
        {
            this.Nome = Nome;
            this.Morada = Morada;
        }
    }
}
