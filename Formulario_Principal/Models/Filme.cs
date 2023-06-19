using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Filme
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public DateTime Duracao { get; set; }
        public bool Activo { get; set; }
        public Categoria Categoria { get; set; }

        public Filme(string nome, DateTime duracao, Categoria categoria) 
        {
            this.Nome = nome;
            this.Duracao = duracao;
            this.Categoria = categoria;
        }
    }
}