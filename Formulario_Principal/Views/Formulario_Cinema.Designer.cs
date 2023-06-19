namespace Formulario_Principal.Views
{
    partial class Formulario_Cinema
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
            this.btnAlterarCinema = new System.Windows.Forms.Button();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxCinema = new System.Windows.Forms.ListBox();
            this.btnObterSala = new System.Windows.Forms.Button();
            this.listBoxSalas = new System.Windows.Forms.ListBox();
            this.btnObterCinema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlterarCinema
            // 
            this.btnAlterarCinema.Location = new System.Drawing.Point(92, 187);
            this.btnAlterarCinema.Name = "btnAlterarCinema";
            this.btnAlterarCinema.Size = new System.Drawing.Size(122, 26);
            this.btnAlterarCinema.TabIndex = 21;
            this.btnAlterarCinema.Text = "Alterar Cinema";
            this.btnAlterarCinema.UseVisualStyleBackColor = true;
            this.btnAlterarCinema.Click += new System.EventHandler(this.btnAlterarCinema_Click);
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(114, 137);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(100, 20);
            this.txtMorada.TabIndex = 20;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(106, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Morada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // listBoxCinema
            // 
            this.listBoxCinema.FormattingEnabled = true;
            this.listBoxCinema.Location = new System.Drawing.Point(608, 42);
            this.listBoxCinema.Name = "listBoxCinema";
            this.listBoxCinema.Size = new System.Drawing.Size(120, 95);
            this.listBoxCinema.TabIndex = 29;
            // 
            // btnObterSala
            // 
            this.btnObterSala.Location = new System.Drawing.Point(624, 317);
            this.btnObterSala.Name = "btnObterSala";
            this.btnObterSala.Size = new System.Drawing.Size(95, 23);
            this.btnObterSala.TabIndex = 39;
            this.btnObterSala.Text = "Obter Sala";
            this.btnObterSala.UseVisualStyleBackColor = true;
            // 
            // listBoxSalas
            // 
            this.listBoxSalas.FormattingEnabled = true;
            this.listBoxSalas.Location = new System.Drawing.Point(608, 206);
            this.listBoxSalas.Name = "listBoxSalas";
            this.listBoxSalas.Size = new System.Drawing.Size(120, 95);
            this.listBoxSalas.TabIndex = 38;
            // 
            // btnObterCinema
            // 
            this.btnObterCinema.Location = new System.Drawing.Point(606, 153);
            this.btnObterCinema.Name = "btnObterCinema";
            this.btnObterCinema.Size = new System.Drawing.Size(122, 26);
            this.btnObterCinema.TabIndex = 44;
            this.btnObterCinema.Text = "Obter Cinema";
            this.btnObterCinema.UseVisualStyleBackColor = true;
            this.btnObterCinema.Click += new System.EventHandler(this.btnObterCinema_Click);
            // 
            // Formulario_Cinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObterCinema);
            this.Controls.Add(this.btnObterSala);
            this.Controls.Add(this.listBoxSalas);
            this.Controls.Add(this.listBoxCinema);
            this.Controls.Add(this.btnAlterarCinema);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Cinema";
            this.Text = "Formulario_Cinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarCinema;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxCinema;
        private System.Windows.Forms.Button btnObterSala;
        private System.Windows.Forms.ListBox listBoxSalas;
        private System.Windows.Forms.Button btnObterCinema;
    }
}