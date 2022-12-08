namespace auladodia8dezenbro
{
    partial class Form2
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
            this.butaolinpar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tela1 = new System.Windows.Forms.TextBox();
            this.inputtexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butaolinpar
            // 
            this.butaolinpar.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butaolinpar.Location = new System.Drawing.Point(534, 24);
            this.butaolinpar.Name = "butaolinpar";
            this.butaolinpar.Size = new System.Drawing.Size(100, 55);
            this.butaolinpar.TabIndex = 0;
            this.butaolinpar.Text = "linpar";
            this.butaolinpar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.MaximumSize = new System.Drawing.Size(399, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 0);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tela1
            // 
            this.tela1.Location = new System.Drawing.Point(82, 137);
            this.tela1.Multiline = true;
            this.tela1.Name = "tela1";
            this.tela1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tela1.Size = new System.Drawing.Size(383, 294);
            this.tela1.TabIndex = 2;
            // 
            // inputtexto
            // 
            this.inputtexto.Location = new System.Drawing.Point(82, 92);
            this.inputtexto.Name = "inputtexto";
            this.inputtexto.Size = new System.Drawing.Size(190, 20);
            this.inputtexto.TabIndex = 5;
            this.inputtexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(646, 483);
            this.Controls.Add(this.inputtexto);
            this.Controls.Add(this.tela1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butaolinpar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butaolinpar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tela1;
        private System.Windows.Forms.TextBox inputtexto;
    }
}