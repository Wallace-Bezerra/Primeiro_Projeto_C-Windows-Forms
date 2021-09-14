using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
        }

        private void checkBox_Fisica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Fisica.Checked == true)
            {
                panel_CPF.Visible = true;
            }
            else
            {
                panel_CPF.Visible = false;
            }
        }

        private void checkBox_Juridica_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Juridica.Checked == true)
            {
                panel_CNPJ.Visible = true;

            }
            else
            {
                panel_CNPJ.Visible = false;
            }
        }
    }
}
