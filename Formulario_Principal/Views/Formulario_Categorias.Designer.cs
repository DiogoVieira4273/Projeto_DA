namespace Formulario_Principal.Views
{
    partial class Formulario_Categorias
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
            this.btnAdicionarCategoria = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.listBoxCategoria = new System.Windows.Forms.ListBox();
            this.btnObterCategoria = new System.Windows.Forms.Button();
            this.btnRemoverCategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // btnAdicionarCategoria
            // 
            this.btnAdicionarCategoria.Location = new System.Drawing.Point(210, 224);
            this.btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            this.btnAdicionarCategoria.Size = new System.Drawing.Size(122, 25);
            this.btnAdicionarCategoria.TabIndex = 1;
            this.btnAdicionarCategoria.Text = "Adicionar Categoria";
            this.btnAdicionarCategoria.UseVisualStyleBackColor = true;
            this.btnAdicionarCategoria.Click += new System.EventHandler(this.btnAdicionarCategoria_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(306, 136);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(100, 20);
            this.tbNome.TabIndex = 2;
            // 
            // listBoxCategoria
            // 
            this.listBoxCategoria.FormattingEnabled = true;
            this.listBoxCategoria.Location = new System.Drawing.Point(558, 86);
            this.listBoxCategoria.Name = "listBoxCategoria";
            this.listBoxCategoria.Size = new System.Drawing.Size(120, 95);
            this.listBoxCategoria.TabIndex = 3;
            // 
            // btnObterCategoria
            // 
            this.btnObterCategoria.Location = new System.Drawing.Point(558, 211);
            this.btnObterCategoria.Name = "btnObterCategoria";
            this.btnObterCategoria.Size = new System.Drawing.Size(122, 25);
            this.btnObterCategoria.TabIndex = 4;
            this.btnObterCategoria.Text = "Obter Categoria";
            this.btnObterCategoria.UseVisualStyleBackColor = true;
            this.btnObterCategoria.Click += new System.EventHandler(this.btnObterCategoria_Click);
            // 
            // btnRemoverCategoria
            // 
            this.btnRemoverCategoria.Location = new System.Drawing.Point(377, 224);
            this.btnRemoverCategoria.Name = "btnRemoverCategoria";
            this.btnRemoverCategoria.Size = new System.Drawing.Size(122, 25);
            this.btnRemoverCategoria.TabIndex = 5;
            this.btnRemoverCategoria.Text = "Remover Categoria";
            this.btnRemoverCategoria.UseVisualStyleBackColor = true;
            this.btnRemoverCategoria.Click += new System.EventHandler(this.btnRemoverCategoria_Click);
            // 
            // Formulario_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoverCategoria);
            this.Controls.Add(this.btnObterCategoria);
            this.Controls.Add(this.listBoxCategoria);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btnAdicionarCategoria);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Categorias";
            this.Text = "Formulario_Categorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionarCategoria;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.ListBox listBoxCategoria;
        private System.Windows.Forms.Button btnObterCategoria;
        private System.Windows.Forms.Button btnRemoverCategoria;
    }
}