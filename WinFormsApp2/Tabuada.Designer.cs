
namespace WinFormsApp2
{
    partial class Tabuada
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
            this.label_TextoDaTabuada = new System.Windows.Forms.Label();
            this.textBox_NumeroTabuada = new System.Windows.Forms.TextBox();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.textBox_ResultadoTabuada = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_TextoDaTabuada
            // 
            this.label_TextoDaTabuada.AutoSize = true;
            this.label_TextoDaTabuada.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_TextoDaTabuada.Location = new System.Drawing.Point(28, 75);
            this.label_TextoDaTabuada.Name = "label_TextoDaTabuada";
            this.label_TextoDaTabuada.Size = new System.Drawing.Size(357, 27);
            this.label_TextoDaTabuada.TabIndex = 0;
            this.label_TextoDaTabuada.Text = "Insira qual tabuada ira calcular :";
            // 
            // textBox_NumeroTabuada
            // 
            this.textBox_NumeroTabuada.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_NumeroTabuada.Location = new System.Drawing.Point(403, 67);
            this.textBox_NumeroTabuada.Name = "textBox_NumeroTabuada";
            this.textBox_NumeroTabuada.Size = new System.Drawing.Size(120, 35);
            this.textBox_NumeroTabuada.TabIndex = 0;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Location = new System.Drawing.Point(42, 162);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(170, 43);
            this.button_Calcular.TabIndex = 2;
            this.button_Calcular.Text = "CALCULAR";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // button_Limpar
            // 
            this.button_Limpar.Location = new System.Drawing.Point(46, 257);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(165, 44);
            this.button_Limpar.TabIndex = 3;
            this.button_Limpar.Text = "LIMPAR";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // textBox_ResultadoTabuada
            // 
            this.textBox_ResultadoTabuada.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox_ResultadoTabuada.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_ResultadoTabuada.HideSelection = false;
            this.textBox_ResultadoTabuada.Location = new System.Drawing.Point(318, 126);
            this.textBox_ResultadoTabuada.Multiline = true;
            this.textBox_ResultadoTabuada.Name = "textBox_ResultadoTabuada";
            this.textBox_ResultadoTabuada.ReadOnly = true;
            this.textBox_ResultadoTabuada.Size = new System.Drawing.Size(259, 372);
            this.textBox_ResultadoTabuada.TabIndex = 4;
            // 
            // Tabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 510);
            this.Controls.Add(this.textBox_ResultadoTabuada);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.textBox_NumeroTabuada);
            this.Controls.Add(this.label_TextoDaTabuada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Tabuada";
            this.Text = "Programa Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_TextoDaTabuada;
        private System.Windows.Forms.TextBox textBox_NumeroTabuada;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.TextBox textBox_ResultadoTabuada;
    }
}