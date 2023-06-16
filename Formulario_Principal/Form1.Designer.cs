namespace Formulario_Principal
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.btnAdicionarCinema = new System.Windows.Forms.Button();
            this.listBoxFuncionario = new System.Windows.Forms.ListBox();
            this.btnObterFuncionarios = new System.Windows.Forms.Button();
            this.btnObterSessao = new System.Windows.Forms.Button();
            this.listBoxSessao = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinemaToolStripMenuItem,
            this.filmesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.sessõesToolStripMenuItem,
            this.funcionáriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.cinemaToolStripMenuItem.Text = "Cinema";
            this.cinemaToolStripMenuItem.Click += new System.EventHandler(this.cinemaToolStripMenuItem_Click);
            // 
            // filmesToolStripMenuItem
            // 
            this.filmesToolStripMenuItem.Name = "filmesToolStripMenuItem";
            this.filmesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.filmesToolStripMenuItem.Text = "Filmes";
            this.filmesToolStripMenuItem.Click += new System.EventHandler(this.filmesToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // sessõesToolStripMenuItem
            // 
            this.sessõesToolStripMenuItem.Name = "sessõesToolStripMenuItem";
            this.sessõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sessõesToolStripMenuItem.Text = "Sessões";
            this.sessõesToolStripMenuItem.Click += new System.EventHandler(this.sessõesToolStripMenuItem_Click);
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.funcionáriosToolStripMenuItem.Text = "Funcionários";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Morada";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(356, 43);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(356, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(364, 138);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(100, 20);
            this.txtMorada.TabIndex = 6;
            // 
            // btnAdicionarCinema
            // 
            this.btnAdicionarCinema.Location = new System.Drawing.Point(342, 188);
            this.btnAdicionarCinema.Name = "btnAdicionarCinema";
            this.btnAdicionarCinema.Size = new System.Drawing.Size(122, 26);
            this.btnAdicionarCinema.TabIndex = 7;
            this.btnAdicionarCinema.Text = "Adicionar Cinema";
            this.btnAdicionarCinema.UseVisualStyleBackColor = true;
            this.btnAdicionarCinema.Click += new System.EventHandler(this.btnAdicionarCinema_Click);
            // 
            // listBoxFuncionario
            // 
            this.listBoxFuncionario.FormattingEnabled = true;
            this.listBoxFuncionario.Location = new System.Drawing.Point(12, 234);
            this.listBoxFuncionario.Name = "listBoxFuncionario";
            this.listBoxFuncionario.Size = new System.Drawing.Size(156, 134);
            this.listBoxFuncionario.TabIndex = 9;
            // 
            // btnObterFuncionarios
            // 
            this.btnObterFuncionarios.Location = new System.Drawing.Point(34, 386);
            this.btnObterFuncionarios.Name = "btnObterFuncionarios";
            this.btnObterFuncionarios.Size = new System.Drawing.Size(122, 26);
            this.btnObterFuncionarios.TabIndex = 10;
            this.btnObterFuncionarios.Text = "Obter Funcionarios";
            this.btnObterFuncionarios.UseVisualStyleBackColor = true;
            this.btnObterFuncionarios.Click += new System.EventHandler(this.btnObterFuncionarios_Click);
            // 
            // btnObterSessao
            // 
            this.btnObterSessao.Location = new System.Drawing.Point(34, 167);
            this.btnObterSessao.Name = "btnObterSessao";
            this.btnObterSessao.Size = new System.Drawing.Size(122, 26);
            this.btnObterSessao.TabIndex = 11;
            this.btnObterSessao.Text = "Obter Sessao";
            this.btnObterSessao.UseVisualStyleBackColor = true;
            this.btnObterSessao.Click += new System.EventHandler(this.btnObterSessao_Click);
            // 
            // listBoxSessao
            // 
            this.listBoxSessao.FormattingEnabled = true;
            this.listBoxSessao.Location = new System.Drawing.Point(12, 27);
            this.listBoxSessao.Name = "listBoxSessao";
            this.listBoxSessao.Size = new System.Drawing.Size(156, 134);
            this.listBoxSessao.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObterSessao);
            this.Controls.Add(this.btnObterFuncionarios);
            this.Controls.Add(this.listBoxFuncionario);
            this.Controls.Add(this.listBoxSessao);
            this.Controls.Add(this.btnAdicionarCinema);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formulario_Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Button btnAdicionarCinema;
        private System.Windows.Forms.ListBox listBoxFuncionario;
        private System.Windows.Forms.Button btnObterFuncionarios;
        private System.Windows.Forms.Button btnObterSessao;
        private System.Windows.Forms.ListBox listBoxSessao;
    }
}

