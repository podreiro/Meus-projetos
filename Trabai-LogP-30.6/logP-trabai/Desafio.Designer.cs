namespace logP_trabai
{
    partial class Desafio
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lstElementos = new System.Windows.Forms.ListBox();
            this.btncriar = new System.Windows.Forms.Button();
            this.btnpreencher = new System.Windows.Forms.Button();
            this.btnMaiorValor = new System.Windows.Forms.Button();
            this.btnMenorValor = new System.Windows.Forms.Button();
            this.BtnZeros = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 42);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(341, 49);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "quantidades de elementos do vetor:";
            // 
            // lstElementos
            // 
            this.lstElementos.FormattingEnabled = true;
            this.lstElementos.Location = new System.Drawing.Point(374, 23);
            this.lstElementos.Name = "lstElementos";
            this.lstElementos.Size = new System.Drawing.Size(170, 355);
            this.lstElementos.TabIndex = 3;
            // 
            // btncriar
            // 
            this.btncriar.Location = new System.Drawing.Point(26, 97);
            this.btncriar.Name = "btncriar";
            this.btncriar.Size = new System.Drawing.Size(300, 43);
            this.btncriar.TabIndex = 4;
            this.btncriar.Text = "Criar o Vetor";
            this.btncriar.UseVisualStyleBackColor = true;
            this.btncriar.Click += new System.EventHandler(this.btncriar_Click);
            // 
            // btnpreencher
            // 
            this.btnpreencher.Location = new System.Drawing.Point(26, 146);
            this.btnpreencher.Name = "btnpreencher";
            this.btnpreencher.Size = new System.Drawing.Size(300, 43);
            this.btnpreencher.TabIndex = 5;
            this.btnpreencher.Text = "Preencher o vetor";
            this.btnpreencher.UseVisualStyleBackColor = true;
            // 
            // btnMaiorValor
            // 
            this.btnMaiorValor.Location = new System.Drawing.Point(26, 195);
            this.btnMaiorValor.Name = "btnMaiorValor";
            this.btnMaiorValor.Size = new System.Drawing.Size(300, 43);
            this.btnMaiorValor.TabIndex = 6;
            this.btnMaiorValor.Text = "Maior Valor";
            this.btnMaiorValor.UseVisualStyleBackColor = true;
            // 
            // btnMenorValor
            // 
            this.btnMenorValor.Location = new System.Drawing.Point(26, 244);
            this.btnMenorValor.Name = "btnMenorValor";
            this.btnMenorValor.Size = new System.Drawing.Size(300, 42);
            this.btnMenorValor.TabIndex = 7;
            this.btnMenorValor.Text = "Menor Valor";
            this.btnMenorValor.UseVisualStyleBackColor = true;
            // 
            // BtnZeros
            // 
            this.BtnZeros.Location = new System.Drawing.Point(26, 292);
            this.BtnZeros.Name = "BtnZeros";
            this.BtnZeros.Size = new System.Drawing.Size(300, 46);
            this.BtnZeros.TabIndex = 8;
            this.BtnZeros.Text = "Média";
            this.BtnZeros.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Resultados";
            // 
            // Desafio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnZeros);
            this.Controls.Add(this.btnMenorValor);
            this.Controls.Add(this.btnMaiorValor);
            this.Controls.Add(this.btnpreencher);
            this.Controls.Add(this.btncriar);
            this.Controls.Add(this.lstElementos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Desafio";
            this.Text = "Desafio";
            this.Load += new System.EventHandler(this.Desafio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.Button btncriar;
        private System.Windows.Forms.Button btnpreencher;
        private System.Windows.Forms.Button btnMaiorValor;
        private System.Windows.Forms.Button btnMenorValor;
        private System.Windows.Forms.Button BtnZeros;
        private System.Windows.Forms.Label label2;
    }
}