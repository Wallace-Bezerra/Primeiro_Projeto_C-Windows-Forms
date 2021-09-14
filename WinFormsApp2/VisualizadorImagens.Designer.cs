
namespace WinFormsApp2
{
    partial class Visualizador
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
            this.pictureBox_Imagem = new System.Windows.Forms.PictureBox();
            this.button_Mostrar_imagem = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Imagem
            // 
            this.pictureBox_Imagem.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Imagem.Name = "pictureBox_Imagem";
            this.pictureBox_Imagem.Size = new System.Drawing.Size(612, 360);
            this.pictureBox_Imagem.TabIndex = 0;
            this.pictureBox_Imagem.TabStop = false;
            // 
            // button_Mostrar_imagem
            // 
            this.button_Mostrar_imagem.ForeColor = System.Drawing.Color.Crimson;
            this.button_Mostrar_imagem.Location = new System.Drawing.Point(77, 388);
            this.button_Mostrar_imagem.Name = "button_Mostrar_imagem";
            this.button_Mostrar_imagem.Size = new System.Drawing.Size(180, 44);
            this.button_Mostrar_imagem.TabIndex = 1;
            this.button_Mostrar_imagem.Text = "Selecione a Imagem";
            this.button_Mostrar_imagem.UseVisualStyleBackColor = true;
            this.button_Mostrar_imagem.Click += new System.EventHandler(this.button_Mostrar_imagem_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(357, 388);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(169, 44);
            this.button_limpar.TabIndex = 2;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(636, 472);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_Mostrar_imagem);
            this.Controls.Add(this.pictureBox_Imagem);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Visualizador";
            this.Text = "Visualizador de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Imagem;
        private System.Windows.Forms.Button button_Mostrar_imagem;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}