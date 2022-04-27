
namespace Calculadora
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Raiz = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.Subtrair = new System.Windows.Forms.Button();
            this.Multiplicação = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(163, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(163, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(261, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Primeiro Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Segundo Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Violet;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado";
            // 
            // Raiz
            // 
            this.Raiz.BackColor = System.Drawing.Color.HotPink;
            this.Raiz.BackgroundImage = global::Calculadora.Properties.Resources.raiz;
            this.Raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Raiz.Location = new System.Drawing.Point(649, 77);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(57, 54);
            this.Raiz.TabIndex = 10;
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Divisao
            // 
            this.Divisao.BackColor = System.Drawing.Color.Aqua;
            this.Divisao.BackgroundImage = global::Calculadora.Properties.Resources.divisao1;
            this.Divisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Divisao.Location = new System.Drawing.Point(712, 77);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(54, 54);
            this.Divisao.TabIndex = 3;
            this.Divisao.UseVisualStyleBackColor = false;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Soma
            // 
            this.Soma.BackColor = System.Drawing.Color.Wheat;
            this.Soma.BackgroundImage = global::Calculadora.Properties.Resources.soma;
            this.Soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soma.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soma.ForeColor = System.Drawing.Color.HotPink;
            this.Soma.Location = new System.Drawing.Point(712, 258);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(54, 50);
            this.Soma.TabIndex = 2;
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Subtrair
            // 
            this.Subtrair.BackColor = System.Drawing.Color.YellowGreen;
            this.Subtrair.BackgroundImage = global::Calculadora.Properties.Resources.Menos;
            this.Subtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Subtrair.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtrair.ForeColor = System.Drawing.Color.Fuchsia;
            this.Subtrair.Location = new System.Drawing.Point(712, 197);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Subtrair.Size = new System.Drawing.Size(54, 55);
            this.Subtrair.TabIndex = 1;
            this.Subtrair.UseVisualStyleBackColor = false;
            this.Subtrair.Click += new System.EventHandler(this.button2_Click);
            // 
            // Multiplicação
            // 
            this.Multiplicação.BackColor = System.Drawing.Color.HotPink;
            this.Multiplicação.BackgroundImage = global::Calculadora.Properties.Resources.muti;
            this.Multiplicação.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Multiplicação.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicação.ForeColor = System.Drawing.Color.Aquamarine;
            this.Multiplicação.Location = new System.Drawing.Point(712, 137);
            this.Multiplicação.Name = "Multiplicação";
            this.Multiplicação.Size = new System.Drawing.Size(54, 54);
            this.Multiplicação.TabIndex = 0;
            this.Multiplicação.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Multiplicação.UseVisualStyleBackColor = false;
            this.Multiplicação.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::Calculadora.Properties.Resources.flores;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.Multiplicação);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Multiplicação;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Raiz;
    }
}

