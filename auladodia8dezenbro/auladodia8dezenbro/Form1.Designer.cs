namespace auladodia8dezenbro
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
            this.input = new System.Windows.Forms.TextBox();
            this.nome1 = new System.Windows.Forms.Label();
            this.labelenviar = new System.Windows.Forms.Button();
            this.mensagemfinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(29, 70);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(187, 20);
            this.input.TabIndex = 0;
            // 
            // nome1
            // 
            this.nome1.AutoSize = true;
            this.nome1.Location = new System.Drawing.Point(38, 23);
            this.nome1.Name = "nome1";
            this.nome1.Size = new System.Drawing.Size(83, 13);
            this.nome1.TabIndex = 1;
            this.nome1.Text = "Digite um nome:";
            // 
            // labelenviar
            // 
            this.labelenviar.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelenviar.Location = new System.Drawing.Point(29, 116);
            this.labelenviar.Name = "labelenviar";
            this.labelenviar.Size = new System.Drawing.Size(104, 45);
            this.labelenviar.TabIndex = 2;
            this.labelenviar.Text = "enviar";
            this.labelenviar.UseVisualStyleBackColor = true;
            this.labelenviar.Click += new System.EventHandler(this.enviar_Click);
            // 
            // mensagemfinal
            // 
            this.mensagemfinal.AutoSize = true;
            this.mensagemfinal.Location = new System.Drawing.Point(34, 196);
            this.mensagemfinal.Name = "mensagemfinal";
            this.mensagemfinal.Size = new System.Drawing.Size(99, 13);
            this.mensagemfinal.TabIndex = 3;
            this.mensagemfinal.Text = "o nome digitado foi ";
            this.mensagemfinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1171, 473);
            this.Controls.Add(this.mensagemfinal);
            this.Controls.Add(this.labelenviar);
            this.Controls.Add(this.nome1);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label nome1;
        private System.Windows.Forms.Button labelenviar;
        private System.Windows.Forms.Label mensagemfinal;
    }
}

