using Formulario_Principal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Formulario_Principal.Controller;
using System.Windows.Forms;

namespace Formulario_Principal.Views
{
    public partial class Formulario_Clientes : Form
    {
        public Formulario_Clientes()
        {
            InitializeComponent();
        }

        private void btnAdicionarCliente_Click(object sender, EventArgs e)
        {
            CinemaController.AddCliente(tbNome.Text, tbMorada.Text, int.Parse(tbNIF.Text));
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            CinemaController.UpdateCliente();
        }

        private void btnRemoverCliente_Click(object sender, EventArgs e)
        {
            CinemaController.RemoveCliente();
        }

        private void btnObterCliente_Click(object sender, EventArgs e)
        {
            var cliente = CinemaController.GetClientes();
            listBoxClientes.DataSource = cliente;
        }
    }
}
