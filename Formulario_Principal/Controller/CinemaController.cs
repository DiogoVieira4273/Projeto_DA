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
        public static string AddCliente(string nome, string morada, int numeroFiscal)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var cliente = new Cliente (nome, morada, numeroFiscal); 
                db.Cliente.Add(cliente); 
                db.SaveChanges();
            }
        }

        public static string AddCinema(string nome, string morada, string email)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var cinema = new Cinema (nome, morada, email); 
                db.Cinema.Add(cinema); 
                db.SaveChanges();
            }
        }

        public static string AddFilme(string nome, DateTime duracao, Categoria categoria)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var filme = new Filme (nome, duracao, categoria); 
                db.Filme.Add(filme); 
                db.SaveChanges();
            }
        }

        public static string AddCategoria(string nome)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var categoria = new Categoria(nome); 
                db.Categoria.Add(categoria); 
                db.SaveChanges();
            }
        }

        public static string AddSala(string nome, int colunas, int filas, Cinema cinema)
        {
            using (var db = new CinemaDbContext())
            {
                var sala = new Sala(nome, colunas, filas, cinema);
                db.Sala.Add(sala);
                db.SaveChanges();
            }
        }

        public static string AddSessao(DateTime dataHora, decimal preco)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var sessao = new Sessao (dataHora, preco); 
                db.Sessao.Add(sessao); 
                db.SaveChanges();
            }
        }

        public static string AddFuncionario(string nome, string morada, decimal salario, string funcao)
        {
            using (var db = new CinemaDbContext())
            {
                var funcionario = new Funcionario(nome, morada, salario, funcao);
                db.Funcionario.Add(funcionario);
                db.SaveChanges();
            }
        }

        public static string AddBilhete(string lugar)
        {
            using (var db = new CinemaDbContext()) 
            { 
                var bilhete = new Bilhete (lugar); 
                db.Bilhete.Add(bilhete); 
                db.SaveChanges();
            }
        }
        
        public static string UpdateCliente(Cliente cliente)
        {
            using (var db = new CinemaDbContext()) 
            {
                db.Cliente.AddOrUpdate(cliente); 
                db.SaveChanges();
            }
        }

        public static string UpdateCinema(Cinema cinema)
        {
            using (var db = new CinemaDbContext())
            {
                db.Cinema.AddOrUpdate(cinema);
                db.SaveChanges();
            }
        }

        public static string UpdateFilme(Filme filme)
        {
            using (var db = new CinemaDbContext())
            {
                db.Filme.AddOrUpdate(filme);
                db.SaveChanges();
            }
        }

        public static string UpdateCategoria(Categoria categoria)
        {
            using (var db = new CinemaDbContext())
            {
                db.Categoria.AddOrUpdate(categoria);
                db.SaveChanges();
            }
        }

        public static string UpdateSala(Sala sala)   
        {
            using (var db = new CinemaDbContext())
            {
                db.Sala.AddOrUpdate(sala);
                db.SaveChanges();
            }
        }

        public static string UpdateSessao(Sessao sessao)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Sessao.AddOrUpdate(sessao); 
                db.SaveChanges();
            }
        }

        public static string UpdateFuncionario(Funcionario funcionario)
        {
            using (var db = new CinemaDbContext())
            {
                db.Funcionario.AddOrUpdate(funcionario);
                db.SaveChanges();
            }
        }

        public static string UpdateBilhete(Bilhete bilhete)
        {
            using (var db = new CinemaDbContext())
            {
                db.Bilhete.AddOrUpdate(bilhete);
                db.SaveChanges();
            }
        }

        public static string RemoveCliente(Cliente cliente)
        {
            using (var db = new CinemaDbContext()) 
            {
                db.Cliente.Remove(cliente); 
                db.SaveChanges();
            }
        }

        public static string RemoveCinema(Cinema cinema)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Cinema.Remove(cinema); 
                db.SaveChanges();
            }
        }

        public static string RemoveFilme(Filme filme)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Filme.Remove(filme); 
                db.SaveChanges();
            }
        }

        public static string RemoveCategoria(Categoria categoria)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Categoria.Remove(categoria); 
                db.SaveChanges();
            }
        }

        public static string RemoveSala(Sala sala)
        {
            using (var db = new CinemaDbContext())
            {
                db.Sala.Remove(sala);
                db.SaveChanges();
            }
        }

        public static string RemoveSessao(Sessao sessao)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Sessao.Remove(sessao); 
                db.SaveChanges();
            }
        }

        public static string RemoveFuncionario(Funcionario funcionario)
        {
            using (var db = new CinemaDbContext())
            {
                db.Funcionario.Remove(funcionario);
                db.SaveChanges();
            }
        }

        public static string RemoveBilhete(Bilhete bilhete)
        {
            using (var db = new CinemaDbContext()) 
            { 
                db.Bilhete.Remove(bilhete); 
                db.SaveChanges();
            }
        }

        public static List<Cliente> GetClientes(Cliente cliente)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Cliente.ToList();
            }
        }

        public static List<Cinema> GetCinemas(Cinema cinema)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Cinema.ToList();
            }
        }

        public static List<Categoria> GetCategorias(Categoria categoria)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Categoria.ToList();
            }
        }

        public static List<Filme> GetFilmes(Filme filme)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Filme.ToList();
            }
        }

        public static List<Bilhete> GetBilhetes(Bilhete bilhete)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Bilhete.ToList();
            }
        }

        public static List<Funcionario> GetFuncionarios(Funcionario funcionario)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Funcionario.ToList();
            }
        }

        public static List<Sala> GetSalas(Sala sala)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Sala.ToList();
            }
        }

        public static List<Sessao> GetSessoes(Sessao sessao)
        {
            using (var db = new CinemaDbContext())
            {
                return db.Sessao.ToList();
            }
        }
    }
}
