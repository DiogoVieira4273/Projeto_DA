using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formulario_Principal.Models;

namespace Formulario_Principal.Controller
{
    public class CinemaController
    {
        public void AddClinete(string nome, string morada, int numeroFiscal)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var cliente = new Cliente (nome, morada, numeroFiscal); 
                db.Cliente.Add(cliente); 
                db.SaveChanges();
            }
        }

        public void AddCinema(string nome, string morada, string email)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var cinema = new Cinema (nome, morada, email); 
                db.Cinema.Add(cinema); 
                db.SaveChanges();
            }
        }

        public void AddFilme(string nome, DateTime duracao, Categoria categoria)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var filme = new Filme (nome, duracao, categoria); 
                db.Filme.Add(filme); 
                db.SaveChanges();
            }
        }

        public void AddCategoria(string nome)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var categoria = new Categoria(nome); 
                db.Categoria.Add(categoria); 
                db.SaveChanges();
            }
        }

        public void AddSala(string nome, int colunas, int filas, Cinema cinema)
        {
            using (var db = new CinemaDbContext())
            {
                var sala = new Sala(nome, colunas, filas, cinema);
                db.Sala.Add(sala);
                db.SaveChanges();
            }
        }

        public void AddSessao(DateTime dataHora, decimal preco)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var sessao = new Sessao (dataHora, preco); 
                db.Sessao.Add(sessao); 
                db.SaveChanges();
            }
        }

        public void AddFuncionario(string nome, string morada, decimal salario, string funcao)
        {
            using (var db = new CinemaDbContext())
            {
                var funcionario = new Funcionario(nome, morada, salario, funcao);
                db.Funcionario.Add(funcionario);
                db.SaveChanges();
            }
        }

        public void AddBilhete(string lugar)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var bilhete = new Bilhete (lugar); 
                db.Bilhete.Add(bilhete); 
                db.SaveChanges();
            }
        }
        
        public void UpdateClinete(Cliente cliente)
        {
            using (var db = new CinemaDbContext()) 
            {
                db.Cliente.AddOrUpdate(cliente); 
                db.SaveChanges();
            }
        }

        public void UpdateCinema(Cinema cinema)
        {
            using (var db = new CinemaDbContext())
            {
                db.Cinema.AddOrUpdate(cinema);
                db.SaveChanges();
            }
        }

        public void UpdateFilme(Filme filme)
        {
            using (var db = new CinemaDbContext())
            {
                db.Filme.AddOrUpdate(filme);
                db.SaveChanges();
            }
        }

        public void UpdateCategoria(Categoria categoria)
        {
            using (var db = new CinemaDbContext())
            {
                db.Categoria.AddOrUpdate(categoria);
                db.SaveChanges();
            }
        }

        public void UpdateSala(Sala sala)   
        {
            using (var db = new CinemaDbContext())
            {
                db.Sala.AddOrUpdate(sala);
                db.SaveChanges();
            }
        }

        public void UpdateSessao(Sessao sessao)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Sessao.AddOrUpdate(sessao); 
                db.SaveChanges();
            }
        }

        public void UpdateFuncionario(Funcionario funcionario)
        {
            using (var db = new CinemaDbContext())
            {
                db.Funcionario.AddOrUpdate(funcionario);
                db.SaveChanges();
            }
        }

        public void UpdateBilhete(Bilhete bilhete)
        {
            using (var db = new CinemaDbContext())
            {
                db.Bilhete.AddOrUpdate(bilhete);
                db.SaveChanges();
            }
        }

        public void RemoveClinete(Cliente cliente)
        {
            using (var db = new CinemaDbContext()) 
            {
                db.Cliente.Remove(cliente); 
                db.SaveChanges();
            }
        }

        public void RemoveCinema(Cinema cinema)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Cinema.Remove(cinema); 
                db.SaveChanges();
            }
        }

        public void RemoveFilme(Filme filme)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Filme.Remove(filme); 
                db.SaveChanges();
            }
        }

        public void RemoveCategoria(Categoria categoria)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Categoria.Remove(categoria); 
                db.SaveChanges();
            }
        }

        public void RemoveSala(Sala sala)
        {
            using (var db = new CinemaDbContext())
            {
                db.Sala.Remove(sala);
                db.SaveChanges();
            }
        }

        public void RemoveSessao(Sessao sessao)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Sessao.Remove(sessao); 
                db.SaveChanges();
            }
        }

        public void RemoveFuncionario(Funcionario funcionario)
        {
            using (var db = new CinemaDbContext())
            {
                db.Funcionario.Remove(funcionario);
                db.SaveChanges();
            }
        }

        public void RemoveBilhete(Bilhete bilhete)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Bilhete.Remove(bilhete); 
                db.SaveChanges();
            }
        }
    }
}
