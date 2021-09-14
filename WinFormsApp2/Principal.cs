using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonFormulario_Click(object sender, EventArgs e)
        {
            formulario formulario = new formulario();

            formulario.ShowDialog();

        }

        private void buttonVisualizador_Click(object sender, EventArgs e)
        {
            Visualizador visualizador = new Visualizador();
            visualizador.ShowDialog();

        }

        private void buttonTabuada_Click(object sender, EventArgs e)
        {
            Tabuada tabuada = new Tabuada();
            tabuada.ShowDialog();
        }
    }
}
