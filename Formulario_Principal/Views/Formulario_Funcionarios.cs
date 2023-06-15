using Formulario_Principal.Controller;
using Formulario_Principal.Models;
using Formulario_Principal;
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
    public partial class Formulario_Funcionarios : Form
    {
        public Formulario_Funcionarios()
        {
            InitializeComponent();
        }

        private void btnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            CinemaController.AddFuncionario(tbNome.Text, tbMorada.Text, decimal.Parse(tbSalario.Text), tbFuncao.Text);
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            CinemaController.UpdateFuncionario();
        }

        private void btnRemoverFuncionario_Click(object sender, EventArgs e)
        {
            CinemaController.RemoveFuncionario();
        }
    }
}
