using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Visualizador : Form
    {
        public Visualizador()
        {
            InitializeComponent();
        }

        private void button_Mostrar_imagem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK);
            pictureBox_Imagem.Load(openFileDialog.FileName);
            pictureBox_Imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            button_Mostrar_imagem.Enabled = false;

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            pictureBox_Imagem.Image = null;
            button_Mostrar_imagem.Enabled = true;


        }
    }
}
