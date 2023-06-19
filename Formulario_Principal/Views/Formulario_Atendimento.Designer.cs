namespace Formulario_Principal.Views
{
    partial class Formulario_Atendimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnObterBilhete = new System.Windows.Forms.Button();
            this.listBoxBilhetes = new System.Windows.Forms.ListBox();
            this.btnObterSessao = new System.Windows.Forms.Button();
            this.listBoxSessao = new System.Windows.Forms.ListBox();
            this.btnObterFuncionarios = new System.Windows.Forms.Button();
            this.listBoxFuncionario = new System.Windows.Forms.ListBox();
            this.btnObterFilme = new System.Windows.Forms.Button();
            this.listBoxFilmes = new System.Windows.Forms.ListBox();
            this.btnObterCliente = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnObterBilhete
            // 
            this.btnObterBilhete.Location = new System.Drawing.Point(642, 203);
            this.btnObterBilhete.Name = "btnObterBilhete";
            this.btnObterBilhete.Size = new System.Drawing.Size(100, 27);
            this.btnObterBilhete.TabIndex = 6;
            this.btnObterBilhete.Text = "Obter Bilhete";
            this.btnObterBilhete.UseVisualStyleBackColor = true;
            this.btnObterBilhete.Click += new System.EventHandler(this.btnObterBilhete_Click);
            // 
            // listBoxBilhetes
            // 
            this.listBoxBilhetes.FormattingEnabled = true;
            this.listBoxBilhetes.Location = new System.Drawing.Point(642, 69);
            this.listBoxBilhetes.Name = "listBoxBilhetes";
            this.listBoxBilhetes.Size = new System.Drawing.Size(120, 95);
            this.listBoxBilhetes.TabIndex = 5;
            // 
            // btnObterSessao
            // 
            this.btnObterSessao.Location = new System.Drawing.Point(26, 189);
            this.btnObterSessao.Name = "btnObterSessao";
            this.btnObterSessao.Size = new System.Drawing.Size(114, 22);
            this.btnObterSessao.TabIndex = 9;
            this.btnObterSessao.Text = "Obter Sessao";
            this.btnObterSessao.UseVisualStyleBackColor = true;
            this.btnObterSessao.Click += new System.EventHandler(this.btnObterSessao_Click);
            // 
            // listBoxSessao
            // 
            this.listBoxSessao.FormattingEnabled = true;
            this.listBoxSessao.Location = new System.Drawing.Point(26, 69);
            this.listBoxSessao.Name = "listBoxSessao";
            this.listBoxSessao.Size = new System.Drawing.Size(120, 95);
            this.listBoxSessao.TabIndex = 8;
            // 
            // btnObterFuncionarios
            // 
            this.btnObterFuncionarios.Location = new System.Drawing.Point(200, 189);
            this.btnObterFuncionarios.Name = "btnObterFuncionarios";
            this.btnObterFuncionarios.Size = new System.Drawing.Size(122, 26);
            this.btnObterFuncionarios.TabIndex = 26;
            this.btnObterFuncionarios.Text = "Obter Funcionarios";
            this.btnObterFuncionarios.UseVisualStyleBackColor = true;
            this.btnObterFuncionarios.Click += new System.EventHandler(this.btnObterFuncionarios_Click);
            // 
            // listBoxFuncionario
            // 
            this.listBoxFuncionario.FormattingEnabled = true;
            this.listBoxFuncionario.Location = new System.Drawing.Point(200, 71);
            this.listBoxFuncionario.Name = "listBoxFuncionario";
            this.listBoxFuncionario.Size = new System.Drawing.Size(122, 95);
            this.listBoxFuncionario.TabIndex = 25;
            // 
            // btnObterFilme
            // 
            this.btnObterFilme.Location = new System.Drawing.Point(422, 187);
            this.btnObterFilme.Name = "btnObterFilme";
            this.btnObterFilme.Size = new System.Drawing.Size(100, 30);
            this.btnObterFilme.TabIndex = 28;
            this.btnObterFilme.Text = "Obter Filme";
            this.btnObterFilme.UseVisualStyleBackColor = true;
            this.btnObterFilme.Click += new System.EventHandler(this.btnObterFilme_Click);
            // 
            // listBoxFilmes
            // 
            this.listBoxFilmes.FormattingEnabled = true;
            this.listBoxFilmes.Location = new System.Drawing.Point(411, 69);
            this.listBoxFilmes.Name = "listBoxFilmes";
            this.listBoxFilmes.Size = new System.Drawing.Size(120, 95);
            this.listBoxFilmes.TabIndex = 27;
            // 
            // btnObterCliente
            // 
            this.btnObterCliente.Location = new System.Drawing.Point(411, 360);
            this.btnObterCliente.Name = "btnObterCliente";
            this.btnObterCliente.Size = new System.Drawing.Size(121, 33);
            this.btnObterCliente.TabIndex = 30;
            this.btnObterCliente.Text = "Obter Cliente";
            this.btnObterCliente.UseVisualStyleBackColor = true;
            this.btnObterCliente.Click += new System.EventHandler(this.btnObterCliente_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.Location = new System.Drawing.Point(411, 246);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(120, 95);
            this.listBoxClientes.TabIndex = 29;
            // 
            // Formulario_Atendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObterCliente);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.btnObterFilme);
            this.Controls.Add(this.listBoxFilmes);
            this.Controls.Add(this.btnObterFuncionarios);
            this.Controls.Add(this.listBoxFuncionario);
            this.Controls.Add(this.btnObterSessao);
            this.Controls.Add(this.listBoxSessao);
            this.Controls.Add(this.btnObterBilhete);
            this.Controls.Add(this.listBoxBilhetes);
            this.Name = "Formulario_Atendimento";
            this.Text = "Formulario_Atendimento";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObterBilhete;
        private System.Windows.Forms.ListBox listBoxBilhetes;
        private System.Windows.Forms.Button btnObterSessao;
        private System.Windows.Forms.ListBox listBoxSessao;
        private System.Windows.Forms.Button btnObterFuncionarios;
        private System.Windows.Forms.ListBox listBoxFuncionario;
        private System.Windows.Forms.Button btnObterFilme;
        private System.Windows.Forms.ListBox listBoxFilmes;
        private System.Windows.Forms.Button btnObterCliente;
        private System.Windows.Forms.ListBox listBoxClientes;
    }
}