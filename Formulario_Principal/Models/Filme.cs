using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Filme
    {
        public int id;
        public string Nome;
        public DateTime Duracao;
        public bool Activo;
        public Categoria Categoria;

        public Filme(string nome, DateTime duracao, Categoria categoria) 
        {
            this.Nome = nome;
            this.Duracao = duracao;
            this.Categoria = categoria;
        }

        public override string ToString()
        {
            return "" + this.Nome + "" + this.Duracao + "" + this.Categoria + "".ToString();
        }
    }
}
