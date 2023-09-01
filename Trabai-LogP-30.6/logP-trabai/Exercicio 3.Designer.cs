namespace logP_trabai
{
    partial class exercicio3
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
            this.rdbCorVerde = new System.Windows.Forms.RadioButton();
            this.rdbCorVermelho = new System.Windows.Forms.RadioButton();
            this.rdbCorAmarelo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMudarDeCor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbCorVerde
            // 
            this.rdbCorVerde.AutoSize = true;
            this.rdbCorVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorVerde.Location = new System.Drawing.Point(30, 119);
            this.rdbCorVerde.Name = "rdbCorVerde";
            this.rdbCorVerde.Size = new System.Drawing.Size(64, 24);
            this.rdbCorVerde.TabIndex = 0;
            this.rdbCorVerde.TabStop = true;
            this.rdbCorVerde.Text = "cinza";
            this.rdbCorVerde.UseVisualStyleBackColor = true;
            // 
            // rdbCorVermelho
            // 
            this.rdbCorVermelho.AutoSize = true;
            this.rdbCorVermelho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorVermelho.Location = new System.Drawing.Point(212, 119);
            this.rdbCorVermelho.Name = "rdbCorVermelho";
            this.rdbCorVermelho.Size = new System.Drawing.Size(58, 24);
            this.rdbCorVermelho.TabIndex = 1;
            this.rdbCorVermelho.TabStop = true;
            this.rdbCorVermelho.Text = "rosa";
            this.rdbCorVermelho.UseVisualStyleBackColor = true;
            // 
            // rdbCorAmarelo
            // 
            this.rdbCorAmarelo.AutoSize = true;
            this.rdbCorAmarelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorAmarelo.Location = new System.Drawing.Point(402, 119);
            this.rdbCorAmarelo.Name = "rdbCorAmarelo";
            this.rdbCorAmarelo.Size = new System.Drawing.Size(57, 24);
            this.rdbCorAmarelo.TabIndex = 2;
            this.rdbCorAmarelo.TabStop = true;
            this.rdbCorAmarelo.Text = "roxo";
            this.rdbCorAmarelo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mude a cor de fundo :";
            // 
            // btnMudarDeCor
            // 
            this.btnMudarDeCor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMudarDeCor.Location = new System.Drawing.Point(81, 236);
            this.btnMudarDeCor.Margin = new System.Windows.Forms.Padding(10);
            this.btnMudarDeCor.Name = "btnMudarDeCor";
            this.btnMudarDeCor.Padding = new System.Windows.Forms.Padding(10);
            this.btnMudarDeCor.Size = new System.Drawing.Size(304, 96);
            this.btnMudarDeCor.TabIndex = 4;
            this.btnMudarDeCor.Text = "mude a cor de fundo";
            this.btnMudarDeCor.UseVisualStyleBackColor = true;
            this.btnMudarDeCor.Click += new System.EventHandler(this.btnMudarDeCor_Click);
            // 
            // exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.btnMudarDeCor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbCorAmarelo);
            this.Controls.Add(this.rdbCorVermelho);
            this.Controls.Add(this.rdbCorVerde);
            this.Name = "exercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbCorVerde;
        private System.Windows.Forms.RadioButton rdbCorVermelho;
        private System.Windows.Forms.RadioButton rdbCorAmarelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMudarDeCor;
    }
}