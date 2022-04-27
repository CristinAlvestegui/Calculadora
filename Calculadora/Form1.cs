using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        ModelCalculadora model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculadora();
        }//Fim do construtor

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox3.Text);
                double resultado = model.Multiplicar(num1, num2);
                label3.Text = "" + resultado;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Nenhum foi número não foi digitado\n\n" + erro);
            }
            

        }//Fim do botão multiplicar

        private void Soma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);//Coletando o 1ro num
                double num2 = Convert.ToDouble(textBox3.Text);//Colentando o 2do num
                double resultado = model.Somar(num1, num2);//
                label3.Text = "" + resultado;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Nenhum número foi digitado\n\n" + erro);
            }
            

        }//Fim do botão Soma

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox3.Text);
                double resultado = model.Subtrair(num1, num2);
                label3.Text = "" + resultado;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Por favor digite um número\n\n" + erro);
            }
            

        }//Fim do botão menos

        private void label1_Click(object sender, EventArgs e)
        {

        }//Primeiro Numero em texto

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim d caixa de text do num1

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim da caixa de texto para num2

        private void Divisao_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox3.Text);
                double resultado = model.Dividir(num1, num2);
                if (resultado == -1)
                {
                    label3.Text = "Não é possivel dividir";
                }
                else
                {
                    label3.Text = "" + resultado;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi digitano nenhum número" + erro);
            }            

        }//Fim do botão divisão

        private void Raiz_Click(object sender, EventArgs e)
        {
            
        }//fim do botão Raiz
    }//Fim da classe
}//Fim do projeto
