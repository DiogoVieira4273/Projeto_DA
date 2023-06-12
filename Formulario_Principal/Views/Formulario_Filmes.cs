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
    public partial class Formulario_Filmes : Form
    {
        public Formulario_Filmes()
        {
            InitializeComponent();
        }

        private void btnAdicionarFilme_Click(object sender, EventArgs e)
        {
            CinemaController.AddFilme(tbNome.Text, DateTime.Parse(tbDuracao.Text));
        }

        private void btnAlterarFilme_Click(object sender, EventArgs e)
        {
            CinemaController.UpdateFilme();
        }

        private void btnRemoverFilme_Click(object sender, EventArgs e)
        {
            CinemaController.RemoveFilme();
        }

        private void btnObterFilme_Click(object sender, EventArgs e)
        {
            var filme = CinemaController.GetFilmes();
            listBoxFilmes.DataSource = filme;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CinemaController.GetCategorias();
        }
    }
}
