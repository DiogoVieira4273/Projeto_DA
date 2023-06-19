using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Principal.Models
{
    public class Categoria
    {
        public int id;
        public string Nome;
        public bool Activa;

        public Categoria(string nome) 
        {
            this.Nome = nome;
        }
    }
}
