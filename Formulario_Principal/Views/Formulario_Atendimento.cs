using Formulario_Principal.Controller;
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
    public partial class Formulario_Atendimento : Form
    {
        public Formulario_Atendimento()
        {
            InitializeComponent();
        }

        private void btnObterBilhete_Click(object sender, EventArgs e)
        {
            var bilhete = CinemaController.GetBilhetes();
            listBoxBilhetes.DataSource = bilhete;
        }

        private void btnObterSessao_Click(object sender, EventArgs e)
        {
            var sessao = CinemaController.GetSessoes();
            listBoxSessao.DataSource = sessao;
        }

        private void btnObterFuncionarios_Click(object sender, EventArgs e)
        {
            var funcionario = CinemaController.GetFuncionarios();
            listBoxFuncionario.DataSource = funcionario;
        }

        private void btnObterFilme_Click(object sender, EventArgs e)
        {
            var filme = CinemaController.GetFilmes();
            listBoxFilmes.DataSource = filme;
        }

        private void btnObterCliente_Click(object sender, EventArgs e)
        {
            var cliente = CinemaController.GetClientes();
            listBoxClientes.DataSource = cliente;
        }
    }
}