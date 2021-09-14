
namespace WinFormsApp2
{
    partial class FormMain
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
            this.buttonFormulario = new System.Windows.Forms.Button();
            this.buttonVisualizador = new System.Windows.Forms.Button();
            this.buttonTabuada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormulario
            // 
            this.buttonFormulario.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFormulario.Location = new System.Drawing.Point(113, 41);
            this.buttonFormulario.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonFormulario.Name = "buttonFormulario";
            this.buttonFormulario.Size = new System.Drawing.Size(260, 100);
            this.buttonFormulario.TabIndex = 0;
            this.buttonFormulario.Text = "Formulário";
            this.buttonFormulario.UseVisualStyleBackColor = true;
            this.buttonFormulario.Click += new System.EventHandler(this.buttonFormulario_Click);
            // 
            // buttonVisualizador
            // 
            this.buttonVisualizador.Location = new System.Drawing.Point(113, 166);
            this.buttonVisualizador.Name = "buttonVisualizador";
            this.buttonVisualizador.Size = new System.Drawing.Size(260, 107);
            this.buttonVisualizador.TabIndex = 1;
            this.buttonVisualizador.Text = "Visualizador de Imagens";
            this.buttonVisualizador.UseVisualStyleBackColor = true;
            this.buttonVisualizador.Click += new System.EventHandler(this.buttonVisualizador_Click);
            // 
            // buttonTabuada
            // 
            this.buttonTabuada.Location = new System.Drawing.Point(112, 290);
            this.buttonTabuada.Name = "buttonTabuada";
            this.buttonTabuada.Size = new System.Drawing.Size(260, 116);
            this.buttonTabuada.TabIndex = 2;
            this.buttonTabuada.Text = "Tabuada";
            this.buttonTabuada.UseVisualStyleBackColor = true;
            this.buttonTabuada.Click += new System.EventHandler(this.buttonTabuada_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 451);
            this.Controls.Add(this.buttonTabuada);
            this.Controls.Add(this.buttonVisualizador);
            this.Controls.Add(this.buttonFormulario);
            this.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormMain";
            this.Text = "Formulário";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormulario;
        private System.Windows.Forms.Button buttonVisualizador;
        private System.Windows.Forms.Button buttonTabuada;
    }
}