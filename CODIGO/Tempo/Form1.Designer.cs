namespace Tempo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.converterTempo = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Valor
            // 
            this.Valor.Location = new System.Drawing.Point(311, 50);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(154, 22);
            this.Valor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "DIGITE O TEMPO EM SEGUNDOS:";
            // 
            // converterTempo
            // 
            this.converterTempo.Location = new System.Drawing.Point(189, 146);
            this.converterTempo.Name = "converterTempo";
            this.converterTempo.Size = new System.Drawing.Size(116, 23);
            this.converterTempo.TabIndex = 2;
            this.converterTempo.Text = "CONVERTER";
            this.converterTempo.UseVisualStyleBackColor = true;
            this.converterTempo.Click += new System.EventHandler(this.converterTempo_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(228, 295);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 16);
            this.Resultado.TabIndex = 3;
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Limpar
            // 
            this.Limpar.Location = new System.Drawing.Point(388, 145);
            this.Limpar.Name = "Limpar";
            this.Limpar.Size = new System.Drawing.Size(102, 23);
            this.Limpar.TabIndex = 4;
            this.Limpar.Text = "LIMPAR";
            this.Limpar.UseVisualStyleBackColor = true;
            this.Limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpar);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.converterTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Valor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TEMPO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button converterTempo;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button Limpar;
    }
}

