using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Principal.Models
{
    public class Sala
    {
        public int id;
        public string Nome;
        public int Colunas;
        public int Filas;
        public Cinema Cinema;

        public Sala(string nome, int colunas, int filas, Cinema cinema) 
        {
            this.Nome = nome;
            this.Colunas = colunas;
            this.Filas = filas;
            this.Cinema = cinema;
        }
    }
}