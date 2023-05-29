using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Filme
    {
        public int Id;
        public string Nome;
        public DateTime Duracao;
        public bool Activo;
        public Categoria Categoria;

        public Filme(string nome, DateTime duracao, bool activo, Categoria categoria) 
        {
            this.Nome = nome;
            this.Duracao = duracao;
            this.Activo = activo;
            this.Categoria = categoria;
        }
    }
}
