using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Sala
    {
        public int id {  get; set; }
        public string Nome { get; set; }
        public int Colunas { get; set; }
        public int Filas { get; set; }
        public Cinema Cinema { get; set; }

        public Sala(string nome, int colunas, int filas, Cinema cinema) 
        {
            this.Nome = nome;
            this.Colunas = colunas;
            this.Filas = filas;
            this.Cinema = cinema;
        }
    }
}