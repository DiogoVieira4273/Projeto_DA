using Formulario_Principal.Controller;
using Formulario_Principal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Principal.Views
{
    public partial class Formulario_Categorias : Form
    {
        public Formulario_Categorias()
        {
            InitializeComponent();
        }

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            CinemaController.AddCategoria(tbNome.Text);
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            var categoria = (Categoria)listBoxCategoria.SelectedItem;
            CinemaController.RemoveCategoria(categoria);
        }

        private void btnObterCategoria_Click(object sender, EventArgs e)
        {
            var categoria = CinemaController.GetCategorias();
            listBoxCategoria.DataSource = categoria;
        }
    }
}
