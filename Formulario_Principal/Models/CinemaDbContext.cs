using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class CinemaDbContext : DbContext
    {
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Bilhete> Bilhete { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Sessao> Sessao { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
