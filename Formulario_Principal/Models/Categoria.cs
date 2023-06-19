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
        public int id {  get; set; }
        public string Nome { get; set; }
        public bool Activa { get; set; }

        public Categoria(string nome) 
        {
            this.Nome = nome;
        }
    }
}