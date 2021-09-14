using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Tabuada : Form
    {
        public Tabuada()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            if (textBox_NumeroTabuada.Text == "")
            {
                MessageBox.Show("Insira um número para realizar o cálculo","Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                double numero, resultado;

                numero = double.Parse(textBox_NumeroTabuada.Text);
               

                for(int i = 0; i <= 10; i++)
                {
                    resultado = numero * i;

                    textBox_ResultadoTabuada.Text += numero + "x" + i + "=" + resultado+ "\r\n";

                }
                button_Calcular.Enabled = false;
            }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            textBox_NumeroTabuada.Text = "";
            textBox_ResultadoTabuada.Text = "";
            button_Calcular.Enabled = true;

        }


    }
}
