using Formulario_Principal.Controller;
using Formulario_Principal.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionarCinema_Click(object sender, EventArgs e)
        {
            CinemaController.AddCinema(txtNome.Text,txtMorada.Text,txtEmail.Text);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Clientes formulario_Clientes = new Formulario_Clientes();
            formulario_Clientes.ShowDialog();
        }

        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Cinema formulario_Cinema = new Formulario_Cinema();
            formulario_Cinema.ShowDialog();
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Filmes formulario_Filmes = new Formulario_Filmes();
            formulario_Filmes.ShowDialog();
        }

        private void sessõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Sessoes formulario_Sessoes = new Formulario_Sessoes();
            formulario_Sessoes.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Funcionarios formulario_Funcionarios = new Formulario_Funcionarios();
            formulario_Funcionarios.ShowDialog();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Categorias formulario_Categorias = new Formulario_Categorias();
            formulario_Categorias.ShowDialog();
        }

        private void atendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Atendimento formulario_Atendimento = new Formulario_Atendimento();
            formulario_Atendimento.ShowDialog();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulario_Sala formulario_Sala = new Formulario_Sala();
            formulario_Sala.ShowDialog();
        }

        private void btnObterFuncionarios_Click(object sender, EventArgs e)
        {
            var funcionario = CinemaController.GetFuncionarios();
            listBoxFuncionario.DataSource = funcionario;
        }

        private void btnObterSessao_Click(object sender, EventArgs e)
        {
            var sessao = CinemaController.GetSessoes();
            listBoxSessao.DataSource = sessao;
        }
    }
}