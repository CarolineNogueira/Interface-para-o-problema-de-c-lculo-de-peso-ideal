using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_para_o_problema_de_cálculo_de_peso_ideal
{
    public partial class frmPesoIdeal : Form
    {
        RadioButton rbnSelecionado = null;

        public frmPesoIdeal()
        {
            InitializeComponent();
        }

        private void radioButtonMasc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();

            }

        }

        private void radioButtonFem_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }
       
        



    private void SetPesoIdeal()
    {
        try
        {
            double altura = Convert.ToDouble(txtAltura.Text);
            double pesoIdeal;
            if (rbnSelecionado.Text.Equals("Masculino"))
                pesoIdeal = (72.7 * altura) - 58;
            else
                pesoIdeal = (62.1 * altura) - 44.7;
            lblResultado.Text = pesoIdeal.ToString("N");
        }
        catch (Exception e)
        {
            MessageBox.Show("Selecione o sexo e informe a altura corretamente", "Atenção!",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            SetPesoIdeal();
        }
    }

}