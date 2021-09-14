
namespace WinFormsApp2
{
    partial class formulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (!disposing || components == null)
            {
            }
            else
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_CPF = new System.Windows.Forms.Panel();
            this.textBox_CPF = new System.Windows.Forms.TextBox();
            this.textBox_nome_CPF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_CNPJ = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CNPJ = new System.Windows.Forms.TextBox();
            this.textBox_nome_CNPJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_Fisica = new System.Windows.Forms.CheckBox();
            this.checkBox_Juridica = new System.Windows.Forms.CheckBox();
            this.panel_CPF.SuspendLayout();
            this.panel_CNPJ.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_CPF
            // 
            this.panel_CPF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CPF.Controls.Add(this.textBox_CPF);
            this.panel_CPF.Controls.Add(this.textBox_nome_CPF);
            this.panel_CPF.Controls.Add(this.label2);
            this.panel_CPF.Controls.Add(this.label1);
            this.panel_CPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_CPF.Location = new System.Drawing.Point(338, 43);
            this.panel_CPF.Name = "panel_CPF";
            this.panel_CPF.Size = new System.Drawing.Size(232, 101);
            this.panel_CPF.TabIndex = 0;
            this.panel_CPF.Visible = false;
            // 
            // textBox_CPF
            // 
            this.textBox_CPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_CPF.Location = new System.Drawing.Point(80, 61);
            this.textBox_CPF.Name = "textBox_CPF";
            this.textBox_CPF.Size = new System.Drawing.Size(106, 25);
            this.textBox_CPF.TabIndex = 3;
            // 
            // textBox_nome_CPF
            // 
            this.textBox_nome_CPF.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_nome_CPF.Location = new System.Drawing.Point(81, 15);
            this.textBox_nome_CPF.Name = "textBox_nome_CPF";
            this.textBox_nome_CPF.Size = new System.Drawing.Size(105, 25);
            this.textBox_nome_CPF.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // panel_CNPJ
            // 
            this.panel_CNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_CNPJ.Controls.Add(this.label5);
            this.panel_CNPJ.Controls.Add(this.textBox_CNPJ);
            this.panel_CNPJ.Controls.Add(this.textBox_nome_CNPJ);
            this.panel_CNPJ.Controls.Add(this.label3);
            this.panel_CNPJ.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel_CNPJ.Location = new System.Drawing.Point(338, 193);
            this.panel_CNPJ.Name = "panel_CNPJ";
            this.panel_CNPJ.Size = new System.Drawing.Size(232, 99);
            this.panel_CNPJ.TabIndex = 1;
            this.panel_CNPJ.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CNPJ:";
            // 
            // textBox_CNPJ
            // 
            this.textBox_CNPJ.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_CNPJ.Location = new System.Drawing.Point(80, 56);
            this.textBox_CNPJ.Name = "textBox_CNPJ";
            this.textBox_CNPJ.Size = new System.Drawing.Size(94, 25);
            this.textBox_CNPJ.TabIndex = 3;
            // 
            // textBox_nome_CNPJ
            // 
            this.textBox_nome_CNPJ.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_nome_CNPJ.Location = new System.Drawing.Point(83, 13);
            this.textBox_nome_CNPJ.Name = "textBox_nome_CNPJ";
            this.textBox_nome_CNPJ.Size = new System.Drawing.Size(92, 25);
            this.textBox_nome_CNPJ.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome:";
            // 
            // checkBox_Fisica
            // 
            this.checkBox_Fisica.AutoSize = true;
            this.checkBox_Fisica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Fisica.ForeColor = System.Drawing.Color.Blue;
            this.checkBox_Fisica.Location = new System.Drawing.Point(139, 106);
            this.checkBox_Fisica.Name = "checkBox_Fisica";
            this.checkBox_Fisica.Size = new System.Drawing.Size(120, 21);
            this.checkBox_Fisica.TabIndex = 2;
            this.checkBox_Fisica.Text = "Pessoa Física";
            this.checkBox_Fisica.UseVisualStyleBackColor = true;
            this.checkBox_Fisica.CheckedChanged += new System.EventHandler(this.checkBox_Fisica_CheckedChanged);
            // 
            // checkBox_Juridica
            // 
            this.checkBox_Juridica.AutoSize = true;
            this.checkBox_Juridica.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_Juridica.ForeColor = System.Drawing.Color.Blue;
            this.checkBox_Juridica.Location = new System.Drawing.Point(134, 178);
            this.checkBox_Juridica.Name = "checkBox_Juridica";
            this.checkBox_Juridica.Size = new System.Drawing.Size(131, 21);
            this.checkBox_Juridica.TabIndex = 3;
            this.checkBox_Juridica.Text = "Pessoa Júridica";
            this.checkBox_Juridica.UseVisualStyleBackColor = true;
            this.checkBox_Juridica.CheckedChanged += new System.EventHandler(this.checkBox_Juridica_CheckedChanged);
            // 
            // formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 388);
            this.Controls.Add(this.checkBox_Juridica);
            this.Controls.Add(this.checkBox_Fisica);
            this.Controls.Add(this.panel_CNPJ);
            this.Controls.Add(this.panel_CPF);
            this.Name = "formulario";
            this.Text = "Formulário";
            this.panel_CPF.ResumeLayout(false);
            this.panel_CPF.PerformLayout();
            this.panel_CNPJ.ResumeLayout(false);
            this.panel_CNPJ.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_CPF;
        private System.Windows.Forms.TextBox textBox_CPF;
        private System.Windows.Forms.TextBox textBox_nome_CPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_CNPJ;
        private System.Windows.Forms.TextBox textBox_CNPJ;
        private System.Windows.Forms.TextBox textBox_nome_CNPJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_Fisica;
        private System.Windows.Forms.CheckBox checkBox_Juridica;
        private System.Windows.Forms.Label label5;
    }
}

