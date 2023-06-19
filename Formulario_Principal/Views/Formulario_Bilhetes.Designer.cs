namespace Formulario_Principal.Views
{
    partial class Formulario_Bilhetes
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
            this.tbLugar = new System.Windows.Forms.TextBox();
            this.btnAdicionarBilhete = new System.Windows.Forms.Button();
            this.listBoxBilhetes = new System.Windows.Forms.ListBox();
            this.btnObterBilhete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lugar:";
            // 
            // tbLugar
            // 
            this.tbLugar.Location = new System.Drawing.Point(223, 74);
            this.tbLugar.Name = "tbLugar";
            this.tbLugar.Size = new System.Drawing.Size(100, 20);
            this.tbLugar.TabIndex = 1;
            // 
            // btnAdicionarBilhete
            // 
            this.btnAdicionarBilhete.Location = new System.Drawing.Point(200, 146);
            this.btnAdicionarBilhete.Name = "btnAdicionarBilhete";
            this.btnAdicionarBilhete.Size = new System.Drawing.Size(100, 27);
            this.btnAdicionarBilhete.TabIndex = 2;
            this.btnAdicionarBilhete.Text = "Adicionar Bilhete";
            this.btnAdicionarBilhete.UseVisualStyleBackColor = true;
            this.btnAdicionarBilhete.Click += new System.EventHandler(this.btnAdicionarBilhete_Click);
            // 
            // listBoxBilhetes
            // 
            this.listBoxBilhetes.FormattingEnabled = true;
            this.listBoxBilhetes.Location = new System.Drawing.Point(574, 59);
            this.listBoxBilhetes.Name = "listBoxBilhetes";
            this.listBoxBilhetes.Size = new System.Drawing.Size(120, 95);
            this.listBoxBilhetes.TabIndex = 3;
            // 
            // btnObterBilhete
            // 
            this.btnObterBilhete.Location = new System.Drawing.Point(574, 193);
            this.btnObterBilhete.Name = "btnObterBilhete";
            this.btnObterBilhete.Size = new System.Drawing.Size(100, 27);
            this.btnObterBilhete.TabIndex = 4;
            this.btnObterBilhete.Text = "Obter Bilhete";
            this.btnObterBilhete.UseVisualStyleBackColor = true;
            this.btnObterBilhete.Click += new System.EventHandler(this.btnObterBilhete_Click);
            // 
            // Formulario_Bilhetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObterBilhete);
            this.Controls.Add(this.listBoxBilhetes);
            this.Controls.Add(this.btnAdicionarBilhete);
            this.Controls.Add(this.tbLugar);
            this.Controls.Add(this.label1);
            this.Name = "Formulario_Bilhetes";
            this.Text = "Formulario_Bilhetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLugar;
        private System.Windows.Forms.Button btnAdicionarBilhete;
        private System.Windows.Forms.ListBox listBoxBilhetes;
        private System.Windows.Forms.Button btnObterBilhete;
    }
}