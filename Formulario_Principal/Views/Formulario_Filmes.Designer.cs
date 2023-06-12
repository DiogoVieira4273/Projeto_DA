namespace Formulario_Principal.Views
{
    partial class Formulario_Filmes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbDuracao = new System.Windows.Forms.TextBox();
            this.btnAdicionarFilme = new System.Windows.Forms.Button();
            this.btnAlterarFilme = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoverFilme = new System.Windows.Forms.Button();
            this.listBoxFilmes = new System.Windows.Forms.ListBox();
            this.btnObterFilme = new System.Windows.Forms.Button();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duracao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categoria";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(241, 90);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 3;
            // 
            // tbDuracao
            // 
            this.tbDuracao.Location = new System.Drawing.Point(241, 142);
            this.tbDuracao.Name = "tbDuracao";
            this.tbDuracao.Size = new System.Drawing.Size(100, 20);
            this.tbDuracao.TabIndex = 4;
            // 
            // btnAdicionarFilme
            // 
            this.btnAdicionarFilme.Location = new System.Drawing.Point(212, 236);
            this.btnAdicionarFilme.Name = "btnAdicionarFilme";
            this.btnAdicionarFilme.Size = new System.Drawing.Size(100, 30);
            this.btnAdicionarFilme.TabIndex = 6;
            this.btnAdicionarFilme.Text = "Adicionar Filme";
            this.btnAdicionarFilme.UseVisualStyleBackColor = true;
            this.btnAdicionarFilme.Click += new System.EventHandler(this.btnAdicionarFilme_Click);
            // 
            // btnAlterarFilme
            // 
            this.btnAlterarFilme.Location = new System.Drawing.Point(415, 239);
            this.btnAlterarFilme.Name = "btnAlterarFilme";
            this.btnAlterarFilme.Size = new System.Drawing.Size(100, 30);
            this.btnAlterarFilme.TabIndex = 13;
            this.btnAlterarFilme.Text = "Alterar Filme";
            this.btnAlterarFilme.UseVisualStyleBackColor = true;
            this.btnAlterarFilme.Click += new System.EventHandler(this.btnAlterarFilme_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(444, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Duracao";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome";
            // 
            // btnRemoverFilme
            // 
            this.btnRemoverFilme.Location = new System.Drawing.Point(608, 239);
            this.btnRemoverFilme.Name = "btnRemoverFilme";
            this.btnRemoverFilme.Size = new System.Drawing.Size(100, 30);
            this.btnRemoverFilme.TabIndex = 20;
            this.btnRemoverFilme.Text = "Remover Filme";
            this.btnRemoverFilme.UseVisualStyleBackColor = true;
            this.btnRemoverFilme.Click += new System.EventHandler(this.btnRemoverFilme_Click);
            // 
            // listBoxFilmes
            // 
            this.listBoxFilmes.FormattingEnabled = true;
            this.listBoxFilmes.Location = new System.Drawing.Point(31, 90);
            this.listBoxFilmes.Name = "listBoxFilmes";
            this.listBoxFilmes.Size = new System.Drawing.Size(120, 95);
            this.listBoxFilmes.TabIndex = 21;
            // 
            // btnObterFilme
            // 
            this.btnObterFilme.Location = new System.Drawing.Point(42, 208);
            this.btnObterFilme.Name = "btnObterFilme";
            this.btnObterFilme.Size = new System.Drawing.Size(100, 30);
            this.btnObterFilme.TabIndex = 22;
            this.btnObterFilme.Text = "Obter Filme";
            this.btnObterFilme.UseVisualStyleBackColor = true;
            this.btnObterFilme.Click += new System.EventHandler(this.btnObterFilme_Click);
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(245, 188);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategorias.TabIndex = 23;
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(444, 194);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 24;
            // 
            // Formulario_Filmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.comboBoxCategorias);
            this.Controls.Add(this.btnObterFilme);
            this.Controls.Add(this.listBoxFilmes);
            this.Controls.Add(this.btnRemoverFilme);
            this.Controls.Add(this.btnAlterarFilme);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAdicionarFilme);
            this.Controls.Add(this.tbDuracao);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Filmes";
            this.Text = "Formulario_Filmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbDuracao;
        private System.Windows.Forms.Button btnAdicionarFilme;
        private System.Windows.Forms.Button btnAlterarFilme;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoverFilme;
        private System.Windows.Forms.ListBox listBoxFilmes;
        private System.Windows.Forms.Button btnObterFilme;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
    }
}