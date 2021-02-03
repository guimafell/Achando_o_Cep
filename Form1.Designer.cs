namespace Consulta_de_cep
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
            this.button1 = new System.Windows.Forms.Button();
            this.Cep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DDD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Siafi = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.Label();
            this.Localidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IBGE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.GIA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cep
            // 
            this.Cep.Location = new System.Drawing.Point(17, 27);
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(138, 20);
            this.Cep.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cep*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "DDD";
            // 
            // DDD
            // 
            this.DDD.Location = new System.Drawing.Point(190, 74);
            this.DDD.Name = "DDD";
            this.DDD.Size = new System.Drawing.Size(138, 20);
            this.DDD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Siafi";
            // 
            // Siafi
            // 
            this.Siafi.Location = new System.Drawing.Point(190, 119);
            this.Siafi.Name = "Siafi";
            this.Siafi.Size = new System.Drawing.Size(138, 20);
            this.Siafi.TabIndex = 5;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(0, 208);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(40, 13);
            this.Cidade.TabIndex = 12;
            this.Cidade.Text = "Cidade";
            // 
            // Localidade
            // 
            this.Localidade.Location = new System.Drawing.Point(17, 228);
            this.Localidade.Name = "Localidade";
            this.Localidade.Size = new System.Drawing.Size(138, 20);
            this.Localidade.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Bairro";
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(17, 170);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(138, 20);
            this.Bairro.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Complemento";
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(17, 119);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(138, 20);
            this.Complemento.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Logradouro";
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(17, 74);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(138, 20);
            this.Logradouro.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Estado";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(17, 286);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(138, 20);
            this.Estado.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "IBGE";
            // 
            // IBGE
            // 
            this.IBGE.Location = new System.Drawing.Point(17, 353);
            this.IBGE.Name = "IBGE";
            this.IBGE.Size = new System.Drawing.Size(138, 20);
            this.IBGE.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "GIA";
            // 
            // GIA
            // 
            this.GIA.Location = new System.Drawing.Point(17, 417);
            this.GIA.Name = "GIA";
            this.GIA.Size = new System.Drawing.Size(138, 20);
            this.GIA.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 442);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.GIA);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IBGE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Logradouro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Localidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Siafi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DDD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cep);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Pesquisa pelo Cep";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Cep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DDD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Siafi;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.TextBox Localidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IBGE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox GIA;
    }
}

